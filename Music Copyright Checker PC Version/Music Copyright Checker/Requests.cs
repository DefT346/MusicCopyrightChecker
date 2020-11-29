using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace MCE
{
    public static class Requests
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task<string> POST(Dictionary<string, string> values, string requestUri)
        {
            var content = new FormUrlEncodedContent(values);

            var response = await client.PostAsync(requestUri, content);

            var responseString = await response.Content.ReadAsStringAsync();

            return responseString;
        }

        public static string AudD(string path)
        {
            using (var client = new WebClient())
            {
                Console.WriteLine("Request data...");
                NameValueCollection parameters = new NameValueCollection();
                parameters.Add("return", "apple_music,spotify");
                parameters.Add("api_token", "8565b86a0e5ce0f16eb881624f24d977");
                client.QueryString = parameters;
                var responseBytes = client.UploadFile("https://api.audd.io/", path);
                string response = Encoding.ASCII.GetString(responseBytes);
                Console.WriteLine("Succsesfull post");

                return response;
            }
        }
        
        public static string Download(string url)
        {
            string remoteUri = url;
            string fileName = "input_test.mp3", myStringWebResource = null;
            // Create a new WebClient instance.
            WebClient myWebClient = new WebClient();
            // Concatenate the domain with the Web resource filename.
            myStringWebResource = remoteUri/* + fileName*/;
            Console.WriteLine("Downloading File \"{0}\" from \"{1}\" .......\n\n", fileName, myStringWebResource);
            // Download the Web resource and save it into the current filesystem folder.
            myWebClient.DownloadFile(myStringWebResource, fileName);
            Console.WriteLine("Successfully Downloaded File \"{0}\" from \"{1}\"", fileName, myStringWebResource);
            Console.WriteLine("\nDownloaded file saved in the following file system folder:\n\t" + Application.StartupPath);
            return fileName;
        }
    }
}
