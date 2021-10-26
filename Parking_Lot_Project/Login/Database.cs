using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_Lot_Project
{
    public class Database
    {
        public static volatile Database instance;

        static object key = new object();

        public static Database Instance
        {
            get
            {
                if (instance == null)
                {
                    lock(key)
                    {
                        instance = new Database();
                    }
                }
                return instance;
            }
        }
        #region Connection to database
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-6TO63R56\SQLEXPRESS;Initial Catalog=PARKING_LOT;Integrated Security=True");
        #endregion

        public SqlConnection getConnection
        {
            get { return con; }
        }

        public void openConnect()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
        }

        public void closeConnection ()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
    }
}
