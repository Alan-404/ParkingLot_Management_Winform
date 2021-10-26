using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_Lot_Project
{
    class Calculate
    {
        public static volatile Calculate instance;

        private static object key = new object();

        public static Calculate Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (key)
                        instance = new Calculate();
                }
                return instance;
            }
        }

        

        public int priceBike(int time, int delta, int column)
        {
            if (time == 0)
                return 5000;
            SqlCommand cmd = new SqlCommand("SELECT * FROM PRICE_PARK WHERE ID = 1", Database.Instance.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            int price = (int)table.Rows[0][column];
            if (time == 0)
                return price;
            if (delta > 0)
                return price * (time + delta);
            return price * time;
        }

        public int priceMotor(int time, int delta, int column)
        {
            if (time == 0)
                return 5000;
            SqlCommand cmd = new SqlCommand("SELECT * FROM PRICE_PARK WHERE ID = 2", Database.Instance.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            int price = (int)table.Rows[0][1];
            return price * time;
        }

        public int priceCar(int time, int delta, int column)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM PRICE_PARK WHERE ID = 3", Database.Instance.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            if (time == 0)
                return int.Parse(table.Rows[0][column].ToString());
            int price = (int)table.Rows[0][column];
            if (delta < 0)
                return price * time;
            return price * time + delta*price;
        }
    }
}
