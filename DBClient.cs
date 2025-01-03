using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OOP_PROJECT_IC_ST82417
{
    internal class DBClient
    {

        private static DBClient instance = null;
        private static readonly object padlock = new object();
        private SqlConnection connection;

        private DBClient()
        {
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\iljac\Documents\storedb.mdf;Integrated Security=True;Connect Timeout=30");
        }

        public static DBClient Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new DBClient();
                    }
                    return instance;
                }
            }
        }

        public SqlConnection getCon()
        {
            return connection;
        }

        public void openCon()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeCon()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }   
    }
}
