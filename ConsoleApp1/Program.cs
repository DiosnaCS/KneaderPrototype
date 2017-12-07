using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int port;
            string IPaddress = string.Empty;
            string sPort = string.Empty;
            string DB = string.Empty;
            string table = string.Empty;
            NpgsqlConnection connection;
            Console.WriteLine("Type IP address to database");
            IPaddress = Console.ReadLine();
            Console.WriteLine("Type port to database");
            sPort = Console.ReadLine();
            port = int.Parse(sPort);
            Console.WriteLine("Type name of the database");
            DB = Console.ReadLine();

            string connstring = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};",
            IPaddress, sPort, "postgres", "Nordit0276", DB);
            connection = new NpgsqlConnection(connstring);
            connection.Open();
            if(connection.FullState == System.Data.ConnectionState.Open)
            {
                Console.WriteLine("Connection is opnned");
            }
            Console.WriteLine("Type name of the table which you want to full with random data");
            table = Console.ReadLine();
        }
    }
}
