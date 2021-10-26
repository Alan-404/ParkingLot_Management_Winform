using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_Lot_Project
{
    class Price
    {
        public static volatile Price instance;

        static object key = new object();
        public static Price Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (key)
                    {
                        instance = new Price();
                    }
                }
                return instance;
            }
        }

        public DataTable getPricePark(int x)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM PRICE_PARK WHERE ID = @ID", Database.Instance.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = x;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            return table;
        }

        public bool updatePriceFix(int id, int price)
        {
            SqlCommand cmd = new SqlCommand("UPDATE PRICE_SERVICE SET PRICE = @PRICE  WHERE ID = @ID", Database.Instance.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;

            cmd.Parameters.Add("@PRICE", SqlDbType.Int).Value = price;
            Database.Instance.openConnect();

            if (cmd.ExecuteNonQuery() == 1)
            {
                Database.Instance.closeConnection();
                return true;
            }
            else
            {
                Database.Instance.closeConnection();
                return false;
            }
        }

        public bool updatePricePark(int id, int hour, int day, int month, int year)
        {
            SqlCommand cmd = new SqlCommand("UPDATE PRICE_PARK SET PRICE_HOUR = @HOUR, PRICE_DAY = @DAY, PRICE_MONTH = @MONTH, PRICE_YEAR = @YEAR WHERE ID = @ID", Database.Instance.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@DAY", SqlDbType.Int).Value = day;
            cmd.Parameters.Add("@HOUR", SqlDbType.Int).Value = hour;
            cmd.Parameters.Add("@MONTH", SqlDbType.Int).Value = month;
            cmd.Parameters.Add("@YEAR", SqlDbType.Int).Value = year;

            Database.Instance.openConnect();

            if (cmd.ExecuteNonQuery() == 1)
            {
                Database.Instance.closeConnection();
                return true;
            }
            else
            {
                Database.Instance.closeConnection();
                return false;
            }
        }


    }
}
