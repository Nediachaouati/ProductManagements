﻿using System.Data.SQLite; 

namespace ProductManagements
{
    internal class Database
    {
        private const string ConnectionString = "Data Source=C:\\Users\\Ing.Nedia\\source\\repos\\ProductManagements\\ProductManagements\\ProductManagements\\products.db;Version=3;";

        public SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(ConnectionString);
        }
    }
}
