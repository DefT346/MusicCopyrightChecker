using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MCE
{
    public static class AudioController
    {
        public static string GetBase64(string path)
        {
            var audioBytes = File.ReadAllBytes(path);
            return GetBase64(audioBytes);
        }

        public static byte[] GetByte(string path)
        {
            var audioBytes = File.ReadAllBytes(path);
            return audioBytes;
        }

        public static string GetBase64(byte[] audioBytes)
        {
            return Convert.ToBase64String(audioBytes);
        }

        //public static List<string> LoadTrimResult()
        //{
        //    var data = new List<string>();
        //    data.Add(GetBase64("result1.wav"));
        //    data.Add(GetBase64("result2.wav"));
        //    data.Add(GetBase64("result3.wav"));
        //    data.Add(GetBase64("result3.wav"));
        //    return data;
        //}

        //public static List<byte[]> LoadTrimResultB()
        //{
        //    var data = new List<byte[]>();
        //    data.Add(GetByte("result1.wav"));
        //    data.Add(GetByte("result2.wav"));
        //    data.Add(GetByte("result3.wav"));
        //    data.Add(GetByte("result3.wav"));
        //    return data;
        //}

        private static void ConvertMp3ToWav(string _inPath_, string _outPath_)
        {
            using (Mp3FileReader mp3 = new Mp3FileReader(_inPath_))
            {
                using (WaveStream pcm = WaveFormatConversionStream.CreatePcmStream(mp3))
                {
                    WaveFileWriter.CreateWaveFile(_outPath_, pcm);
                }
            }
        }

        public static void TrimAndWrite(string inPath, int sec = 10)
        {
            if (inPath.Contains(".mp3"))
            {
                var newPath = inPath.Split('.')[0] + ".wav";
                ConvertMp3ToWav(inPath, newPath);
                TrimAndWrite(newPath, sec);
                return;
            }

            using (WaveFileReader reader = new WaveFileReader(inPath))
            {
                int bytesPerMillisecond = reader.WaveFormat.AverageBytesPerSecond / 1000;
                int duration = (int)reader.Length / bytesPerMillisecond;

                int offset = sec * 1000; //в мсекундах
                //for (int n = 1; n <= 4; n++)
                //{
                    int n = 2;

                    double f = duration / 5d * n;
                    int a = (int)(f - offset / 2d);
                    int b = (int)(f + offset / 2d);

                    int cutFromStart = a;
                    int cutFromEnd = duration - b;

                    using (WaveFileWriter writer = new WaveFileWriter($"result.wav", reader.WaveFormat))
                    {

                        int startPos = cutFromStart * bytesPerMillisecond;
                        startPos = startPos - startPos % reader.WaveFormat.BlockAlign;

                        int endBytes = cutFromEnd * bytesPerMillisecond;
                        endBytes = endBytes - endBytes % reader.WaveFormat.BlockAlign;
                        int endPos = (int)reader.Length - endBytes;

                        TrimWavFile(reader, writer, startPos, endPos);
                    }
                //}
            }
        }

        private static void TrimWavFile(WaveFileReader reader, WaveFileWriter writer, int startPos, int endPos)
        {
            reader.Position = startPos;
            byte[] buffer = new byte[1024];
            while (reader.Position < endPos)
            {
                int bytesRequired = (int)(endPos - reader.Position);
                if (bytesRequired > 0)
                {
                    int bytesToRead = Math.Min(bytesRequired, buffer.Length);
                    int bytesRead = reader.Read(buffer, 0, bytesToRead);
                    if (bytesRead > 0)
                    {
                        writer.Write(buffer, 0, bytesRead);
                    }
                }
            }
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
            if (data.status != "error" && data.result != null)
            {
      
                    this.artist = data.result.artist;
                this.title = data.result.title;
                this.album = data.result.album;
                this.release_date = data.result.release_date;
                this.label = data.result.label;
                this.song_link = data.result.song_link;
                if (data.result.apple_music != null)
                {
                    this.artwork_url = data.result.apple_music.artwork.url;
                    this.artwork_url = this.artwork_url.Split('{')[0];
                    this.apple_music_url = data.result.apple_music.url;
                }

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
}
