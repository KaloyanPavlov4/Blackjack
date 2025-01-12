using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{

    internal class SQLiteHelper
    {
        private static string folderPath = Directory.GetCurrentDirectory();
        private string connectionString = @"Data Source=" + folderPath + "\\database.db; Version=3";
        
        public SQLiteConnection GetConnection()
        {
            if (!File.Exists("database.db"))
            {
                SQLiteConnection.CreateFile("database.db");
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    string commandString = "CREATE TABLE Users(" +
                        "username NVAR(20) NOT NULL UNIQUE, " +
                        "password NVAR(20) NOT NULL, " +
                        "balance INT DEFAULT 500)";
                    using (SQLiteCommand cmd = new SQLiteCommand(commandString, conn))
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            return new SQLiteConnection(connectionString);
        }

        public void OpenConnection(SQLiteConnection connection)
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }

        public void CloseConnection(SQLiteConnection connection)
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }
    }
}
