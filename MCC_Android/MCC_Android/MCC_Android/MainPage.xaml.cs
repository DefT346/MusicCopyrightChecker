using Plugin.FilePicker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using NAudio;
using MCE;
using ClientTest;
using Xamarin.Essentials;
using SqlDB;


namespace MCC_Android
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();

        }
        string GlobalTitle, GlobalArtist;
        Composition Compos;
        private async void ImageFile_Clicked(object sender, EventArgs e)
        {
            var file = await CrossFilePicker.Current.PickFile();
            if (file != null)
            {
                Label Label1 = this.FindByName<Label>("Label1");
                Label Label2 = this.FindByName<Label>("Label2");

                Compos = MusicChecker.GetCompositionData(file.FilePath);
                if (Compos.title != null)
                {
                    Label1.Text = Compos.title;
                    GlobalTitle = Compos.title;
                }
                if (Compos.title != null)
                {
                    Label2.Text = Compos.artist;
                    GlobalArtist = Compos.artist;
                }
            }
            //Открытие файла
        }

        private void ImageMic_Clicked(object sender, EventArgs e)
        {

        }

        public async void Handle_Tapped(object sender, EventArgs e)
        {
            await Browser.OpenAsync(new Uri(AppleURL), BrowserLaunchMode.SystemPreferred);
        }

        public async void Handle_Tapped2(object sender, EventArgs e)
        {
            await Browser.OpenAsync(new Uri(SpotifyURL), BrowserLaunchMode.SystemPreferred);
        }

        Label LabelRes, InfTitle_var, InfArtist_var, InfAlbum_var, InfDate_var;
        StackLayout InfLayout_var;
        Span infSpot, infAppl;
        Sql SQL = new Sql();

        private void Button_Clicked(object sender, EventArgs e)
        {
            var login = this.FindByName<Entry>("Login");
            var pass = this.FindByName<Entry>("Pass");
            var auth = this.FindByName<Label>("Auth");
            var authPanel = this.FindByName<StackLayout>("AuthPanel");
            var exit = this.FindByName<Button>("Exit");
            var histLabel = this.FindByName<Label>("HistLabel");
            var histButton = this.FindByName<Button>("HistButton");
            var histList = this.FindByName<ListView>("HistList");
            auth.Text = "Авторизация";


            try
            {

                SQL.ConnectDB();
                if (SQL.Authorize(login.Text, pass.Text))
                {
                    auth.Text = "@" + SQL.GlobalUsermame.ToUpper();
                    authPanel.IsVisible = false;
                    exit.IsVisible = true;
                    histLabel.IsVisible = false;
                    histButton.IsVisible = true;
                    histList.IsVisible = true;
                }
                else
                {
                    auth.Text = "Введены неверные данные";

                }
                SQL.CloseDB();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message + " " + ex.HelpLink, "Ошибка авторизации");
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            var login = this.FindByName<Entry>("Login");
            var pass = this.FindByName<Entry>("Pass");
            var auth = this.FindByName<Label>("Auth");
            var authPanel = this.FindByName<StackLayout>("AuthPanel");
            var exit = this.FindByName<Button>("Exit");
            var histLabel = this.FindByName<Label>("HistLabel");
            var histButton = this.FindByName<Button>("HistButton");
            var histList = this.FindByName<ListView>("HistList");
            try
            {
                SQL.ConnectDB();
                if (SQL.CreateNewAccount(login.Text, pass.Text))
                {
                    auth.Text = "@" + SQL.GlobalUsermame.ToUpper();
                    authPanel.IsVisible = false;
                    exit.IsVisible = true;
                    histLabel.IsVisible = false;
                    histButton.IsVisible = true;
                    histList.IsVisible = true;
                }
                else
                {
                    auth.Text = "Данный логин уже существует";

                }
                SQL.CloseDB();
            }
            catch (Exception ex)
            {
            }
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            SQL.ConnectDB();

            var auth = this.FindByName<Label>("Auth");
            var authPanel = this.FindByName<StackLayout>("AuthPanel");
            var exit = this.FindByName<Button>("Exit");
            var histLabel = this.FindByName<Label>("HistLabel");
            var histButton = this.FindByName<Button>("HistButton");
            var histList = this.FindByName<ListView>("HistList");

            auth.Text = "Авторизоваться";

            authPanel.IsVisible = true;
            exit.IsVisible = false;
            SQL.GlobalID = "-1";
            histLabel.IsVisible = true;
            histButton.IsVisible = false;
            histList.IsVisible = false;
            histList.ItemsSource = null;
            SQL.CloseDB();

        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            SQL.ConnectDB();
            var histList = this.FindByName<ListView>("HistList");
            

            List<string> temp = new List<string>();
            
            foreach (var row in SQL.GetHistory())
                temp.Add($"{row[2]} - {row[3]}. {row[7]}");

            histList.ItemsSource = temp;

            SQL.CloseDB();
        }

        Image im;
        string AppleURL, SpotifyURL;
        string GlobalRes;
        private  void CheckCopyright(object sender, EventArgs e)
        {
            GlobalRes = "";
            infAppl = this.FindByName<Span>("infApple");
            //infSpot = this.FindByName<Span>("infSpotify");
            LabelRes = this.FindByName<Label>("LabelResult");
            InfTitle_var = this.FindByName<Label>("InfTitle");
            InfArtist_var = this.FindByName<Label>("InfArtist");
            InfAlbum_var = this.FindByName<Label>("InfAlbum");
            InfDate_var = this.FindByName<Label>("InfDate");

            InfLayout_var = this.FindByName<StackLayout>("InfLayout");
            InfLayout_var.IsVisible = false;
            
            im = this.FindByName<Image>("PictureBox1");
            im.IsVisible = false;
            LabelRes.IsVisible = true;
            if ((GlobalTitle!=null) && (GlobalArtist!=null))
             LicChecker.GetLicAsync(this.FindByName<Entry>("IP").Text+":666", GlobalTitle + "^" + GlobalArtist, setResult);
            LabelRes.Text = "Проверка...";

            Device.StartTimer(TimeSpan.FromSeconds(1), CheckResult);
            //Чек лицензии
        }

        private void setResult(string res)
        {

            GlobalRes = res;


        }

        private bool CheckResult()
        {
            //Временный костыль анимации текста

            if (LabelRes.Text == "Проверка...")
            {
                LabelRes.Text = "Проверка.";
            }
            else

            if (LabelRes.Text == "Проверка.")
            {
                LabelRes.Text = "Проверка..";
            }
            else

            if (LabelRes.Text == "Проверка..")
            {
                LabelRes.Text = "Проверка...";
            }

            if (GlobalRes != "")
            {
                LabelRes.Text = GlobalRes;
                if (Compos.title != null) { InfTitle_var.Text = Compos.title; } else { InfTitle_var.Text = "-"; Compos.title = "-"; };
                if (Compos.artist != null) { InfArtist_var.Text = Compos.artist; } else { InfArtist_var.Text = "-"; Compos.artist = "-"; };
                if (Compos.album != null) { InfAlbum_var.Text = Compos.album; } else { InfAlbum_var.Text = "-"; Compos.album = "-"; };
                if (Compos.release_date != null) { InfDate_var.Text = Compos.release_date; } else { InfDate_var.Text = "-"; Compos.release_date = "-"; };
                if (Compos.apple_music_url != null) { infAppl.Text = "Просмотр в Apple Music"; AppleURL = Compos.apple_music_url; } else { AppleURL = "https://www.apple.com/ru/apple-music/"; infAppl.Text = "Поиск в Apple Music"; Compos.apple_music_url = "https://www.apple.com/ru/apple-music/"; };
                //if (Compos.song_link != null) { infSpot.Text = Compos.song_link; ; SpotifyURL = Compos.song_link; } else { SpotifyURL = "https://www.spotify.com/ru-ru/";  infSpot.Text = "Поиск в Spotify"; };
                SQL.ConnectDB();
                SQL.AddHistory(Compos.title, Compos.artist, Compos.album, Compos.release_date, Compos.apple_music_url, GlobalRes);
                SQL.CloseDB();
                InfLayout_var.IsVisible = true;
                return false;
            } else
            {
                return true;
            }
        }



        
    }
}
