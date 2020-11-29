using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;


static class Server
{
    const int port = 666;
    public static TcpClient client;
    public static string ip = "26.161.162.158";
    public static bool bused = false;

    public static async void StartAsync()
    {
        await Task.Run(() => Start());
    }
    public static void Start()
    {
        Console.Write("Enter server ip: ");
        ip = Console.ReadLine();

        TcpListener server = null;
        try
        {
            IPAddress localAddr = IPAddress.Parse(ip);
            server = new TcpListener(localAddr, port);
            server.Start();

            Console.WriteLine($"Сервер запущен по адресу {ip}:{port}");

            while (true)
            {
                if (!bused)
                {
                    Console.WriteLine("Ожидание подключений... ");
                    client = server.AcceptTcpClient();
                    var mes = Get(client);
                    Console.WriteLine("Подключен клиент. Выполнение запроса...");
                    Console.WriteLine($"Получен запрос: {mes}");
                    var req = mes.Split('^');
                    Console.WriteLine(req[0] +".."+ req[1]);
                    bused = true;
                    PageParser.Start(MCCServer.Form1.WB, new Composition(req[0], req[1]), Result);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            if (server != null)
                server.Stop();
        }
    }
    public static void Result(bool lic)
    {
        string result = "";
        result = lic ? "Защищена авторскими правами" : "Не защищена авторскими правами";

        Send(client, result/*$"license = {lic}"*/);
        bused = false;
    }
    public static string Get(TcpClient client)
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
    public static void Send(TcpClient client, string response)
    {
        NetworkStream stream = client.GetStream();
        byte[] data = Encoding.UTF8.GetBytes(response);
        stream.Write(data, 0, data.Length);
        Console.WriteLine("Отправлено сообщение: {0}", response);
        stream.Close();
    }
}

