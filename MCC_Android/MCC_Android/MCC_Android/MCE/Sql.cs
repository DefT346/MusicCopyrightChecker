using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
namespace SqlDB
{
    public class Sql
    {
        ~Sql() => CloseDB();

        private MySqlConnection database_connection;
        public string GlobalID;
        public string GlobalUsermame;


        public bool ConnectDB()
        {
            try
            {
                var builder = new MySqlConnectionStringBuilder
                {
                    Server = "server220.hosting.reg.ru",
                    Database = "u0983904_mcc",
                    UserID = "u0983904_admin",
                    Password = "g9p-yHZ-U7N-ejt",
                    SslMode = MySqlSslMode.Required,
                };

                database_connection = new MySqlConnection(builder.ConnectionString);
                database_connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Connection failed: {ex.Message}");
                return false;
            }
        }

        public void CloseDB()
        {
            if (database_connection != null)
                database_connection.Close();
        }

        private List<List<string>> SQLRead(string sql)
        {
            List<List<string>> table_grid = new List<List<string>>();
            MySqlCommand command = new MySqlCommand(sql, database_connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                List<string> row = new List<string>();
                for (int i = 0; i < reader.FieldCount; i++)
                    row.Add(reader[i].ToString());

                table_grid.Add(row);
            }
            reader.Close(); // закрываем reader
            return table_grid;
        }

        private int SQLCounter(string sql)
        {
            int counter = 0;
            MySqlCommand command = new MySqlCommand(sql, database_connection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
                counter++;
            reader.Close();

            return counter;
        }

        private void SQLExecute(string sql) => new MySqlCommand(sql, database_connection).ExecuteNonQuery();

        public bool CreateNewAccount(string login, string password)
        {
            if (SQLCounter($"SELECT * FROM accounts WHERE login LIKE '{login}'") == 0)
            {
                SQLExecute($"INSERT INTO accounts (id, login, password, note) VALUES (NULL, '{login}', '{password}', 'Registration from client')");
                GlobalUsermame = login;
                GlobalID = Read($"SELECT id FROM accounts WHERE login LIKE '{login}' AND password LIKE '{password}'");
                ChangeMac(GetMAC());
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool ChangeUsername(string login)
        {
            if (SQLCounter($"SELECT * FROM `accounts` WHERE `id` = 3") != 0)
            {
                if (SQLCounter($"SELECT * FROM accounts WHERE login LIKE '{login}'") == 0)
                {
                    SQLExecute($"UPDATE accounts SET login = '{login}' WHERE accounts.id = {GlobalID}");
                    return true;
                }
                else return false;

            }
            else return false;

        }

        public bool Authorize(string login, string password)
        {
            if (SQLCounter($"SELECT id FROM accounts WHERE login LIKE '{login}' AND password LIKE '{password}'") == 0)
            {
                return false;
            }
            else
            {
                GlobalUsermame = login;
                GlobalID = Read($"SELECT id FROM accounts WHERE login LIKE '{login}' AND password LIKE '{password}'");
                ChangeMac(GetMAC());
                return true;
            }
        }


        public void AddHistory(string name, string artist, string album, string date, string link, string result)
        {
            if (GlobalID == null | GlobalID == "")
            {
                GlobalID = "-1";
            }
            if (SQLCounter($"SELECT* FROM `history` WHERE `account_id` = {GlobalID} AND `name` LIKE '{name}' AND `artist` LIKE '{artist}' AND `album` LIKE '{album}' AND `date` LIKE '{date}' AND `link` LIKE '{link}' AND `result` LIKE '{result}'") == 0)
            {
                SQLExecute($" INSERT INTO `history` (`id`, `account_id`, `name`, `artist`, `album`, `date`, `link`, `result`) VALUES(NULL, '{GlobalID}', '{name}', '{artist}', '{album}', '{date}', '{link}', '{result}');");

            }
        }


        public List<List<string>> GetHistory()
        {
                return SQLRead($"SELECT* FROM `history` WHERE `account_id` = {GlobalID}");
        }

        public string GetMAC()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            String sMacAddress = string.Empty;
            foreach (NetworkInterface adapter in nics)
            {
                if (sMacAddress == String.Empty)// only return MAC Address from first card  
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    sMacAddress = adapter.GetPhysicalAddress().ToString();
                }
            }
            return sMacAddress;
        }

        public void ChangeMac(string mac)
        {
            SQLExecute($"UPDATE accounts SET mac = NULL WHERE accounts.mac = '{mac}'");
            SQLExecute($"UPDATE accounts SET mac = '{mac}' WHERE accounts.id = {GlobalID}");
        }

        public string Read(string sql)
        {
            MySqlCommand command = new MySqlCommand(sql, database_connection);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            string temp = reader[0].ToString();
            reader.Close();

            return temp;
        }
    }
}
