using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace QuanLyThuVien
{
    public class clsDatabase
    {
        private string connectionString;

        public clsDatabase()
        {
            // Read connection string from dbconfig.txt
            if (File.Exists("dbconfig.txt"))
            {
                connectionString = File.ReadAllText("dbconfig.txt").Trim();
            }
            else
            {
                throw new Exception("Database configuration file not found!");
            }
        }

        public static SqlConnection con;

        public bool OpenConnection()
        {
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public static bool CloseConnection()
        {
            try
            {
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
