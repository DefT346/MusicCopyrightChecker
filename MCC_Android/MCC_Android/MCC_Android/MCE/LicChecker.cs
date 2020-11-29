using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClientTest
{
    class LicChecker
    {
        public delegate void ParsingComplite(string result);

        private static int port = 666;
        private static string server = "127.0.0.1";
        public static async void GetLicAsync(string address, string info, ParsingComplite parsingComplite)
        {
            var ip = address.Split(':');
            server = ip[0];
            port = int.Parse(ip[1]);

            await Task.Run(() => SendToServer(info, parsingComplite));
        }
        private static void SendToServer(string info, ParsingComplite parsingComplite)
        {
            string result = "null";
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(server, port);
                Send(client, info);
                result =  Get(client);
                client.Close();
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
            }

            parsingComplite.Invoke(result);
        }
        private static string Get(TcpClient client)
        {
            NetworkStream stream = client.GetStream();

            byte[] data = new byte[256];
            StringBuilder response = new StringBuilder();
            do
            {
                int bytes = stream.Read(data, 0, data.Length);
                response.Append(Encoding.UTF8.GetString(data, 0, bytes));
            }
            while (stream.DataAvailable);

            return response.ToString();
        }
        private static void Send(TcpClient client, string response)
        {
            NetworkStream stream = client.GetStream();
            byte[] data = Encoding.UTF8.GetBytes(response);
            stream.Write(data, 0, data.Length);
        }
    }
}
