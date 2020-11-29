using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

public static class PageParser
{
    public delegate void ParsingComplite(bool license);
    public static event ParsingComplite parsingComplite;
    static Composition composition;
    static WebBrowser webBrowser;
    static ParsingComplite resultAction;
    static byte stage = 0;

    public static void Start(WebBrowser webBrowser, Composition composition, ParsingComplite parsingComplite)
    {
        PageParser.webBrowser = webBrowser;
        PageParser.composition = composition;
        PageParser.parsingComplite += parsingComplite;
        PageParser.resultAction = parsingComplite;
        webBrowser.DocumentCompleted += DocumentCompletedEvent;
        webBrowser.Navigate("https://www.easysonglicensing.com/pages/help/resources/search-songs.aspx");
        stage = 1;

        Console.WriteLine("PageParser started");
    }

    public static void DocumentCompletedEvent(object sender, WebBrowserDocumentCompletedEventArgs e)
    {
        Console.WriteLine("Stage select");
        switch (stage)
        {
            case 1:
                Stage1();
                break;

            case 2:
                Stage2();
                break;
        }
    }

    private static void Stage1()
    {
        stage = 2;
        webBrowser.Document.GetElementById("ContentPlaceHolderWrap_ContentPlaceHolderMain_TextBoxSearch").InnerText = composition.title;
        webBrowser.Document.GetElementById("ContentPlaceHolderWrap_ContentPlaceHolderMain_LinkButtonSearch").InvokeMember("click");

        Console.WriteLine("Stage one complited");
        Console.WriteLine("Loading table...");
    }
    private static void Stage2()
    {
        parsingComplite.Invoke(CheckLicense(GetTableTiles()));



        Console.WriteLine("Stage too complited");
        stage = 3;
        Unload();
    }

    private static void Unload()
    {
        parsingComplite -= resultAction;
        webBrowser.DocumentCompleted -= DocumentCompletedEvent;
        webBrowser = null;
        composition = null;
        Console.WriteLine("PageParser closed");
    }

    private static List<Dictionary<string, string>> GetTableTiles()
    {
        List<Dictionary<string, string>> table = new List<Dictionary<string, string>>();

        for (int i = 0; i < 100; i++)
        {
            var row = new Dictionary<string, string>();
            var Title = webBrowser.Document.GetElementById($"ContentPlaceHolderWrap_ContentPlaceHolderMain_GridViewSongs_LabelTitle_{i}");
            var ComposedBy = webBrowser.Document.GetElementById($"ContentPlaceHolderWrap_ContentPlaceHolderMain_GridViewSongs_LabelComposedBy_{i}");
            var Artists = webBrowser.Document.GetElementById($"ContentPlaceHolderWrap_ContentPlaceHolderMain_GridViewSongs_LabelArtists_{i}");
            var Publishers = webBrowser.Document.GetElementById($"ContentPlaceHolderWrap_ContentPlaceHolderMain_GridViewSongs_LabelPublishers_{i}");
            if (Title != null) row["title"] = Title.InnerText;
            if (Artists != null) if (Artists.InnerText != null) row["artists"] = Artists.InnerText; else row["artists"] = "";
            if (ComposedBy != null) row["composedby"] = ComposedBy.InnerText;
            if (Publishers != null) row["publishers"] = Publishers.InnerText;

            if (Title == null && ComposedBy == null && Publishers == null) break;

            table.Add(row);
        }
        return table;
    }

    private static bool CheckLicense(List<Dictionary<string, string>> table)
    {
        foreach (var row in table)
        {
            if (row["title"].Replace(" ", "") == composition.title.Replace(" ", ""))
            {
                Console.WriteLine(row["title"]);

                if (Check(row["artists"], composition.artist) || Check(row["composedby"], composition.artist) || Check(row["publishers"], composition.artist))
                {
                    Console.WriteLine(row["composedby"] + " | " + row["publishers"]);
                    return true;
                }
            }
        }
        return false;
    }

    public static bool Check(string row, string text)
    {
        if (row != null && text != null)
            return Regex.IsMatch(row, $@"(^|\s){text}(\s|$)");
        else return false;
    }

}

public class Composition
{
    public string status;
    public string artist;
    public string title;
    public string album;
    public string release_date;
    public string label;
    public string song_link;
    public string artwork_url;
    public string apple_music_url;

    public Composition(dynamic data)
    {
        if (data.status != "error")
        {
            this.artist = data.result.artist;
            this.title = data.result.title;
            this.album = data.result.album;
            this.release_date = data.result.release_date;
            this.label = data.result.label;
            this.song_link = data.result.song_link;
            this.artwork_url = data.result.apple_music.artwork.url;
            this.artwork_url = this.artwork_url.Split('{')[0];
            this.apple_music_url = data.result.apple_music.url;

            Console.WriteLine("Composition created");
        }
        else
            Console.WriteLine("Composition creating error: request status is error");
    }

    public Composition(string title, string artist)
    {
        this.title = title;
        this.artist = artist;
    }

    public override string ToString()
    {
        return
            "Status: " + status + "\n" +
            "Artist: " + artist + "\n" +
            "Title: " + title + "\n" +
            "Album: " + album + "\n" +
            "Release date: " + release_date + "\n" +
            "Label: " + label + "\n" +
            "Song link: " + song_link + "\n" +
            "Artwork url: " + artwork_url + "\n" +
            "Apple music url: " + apple_music_url;
    }
}
