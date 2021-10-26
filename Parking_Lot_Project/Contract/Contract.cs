using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_Lot_Project
{
    class Contract
    {
        public static volatile Contract instance;
        private static object key = new object();
        public static Contract Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (key)
                    {
                        instance = new Contract();
                    }
                }
                return instance;
            }
        }

        public string makeIdRent()
        {
            SqlCommand command = new SqlCommand("SELECT ID FROM TRANS_RENT ORDER BY CONVERT(INT,ID)", Database.Instance.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);

            int count = 1;
            string job;
            string make = "";
            for (int i = 0; i < table.Rows.Count; ++i)
            {
                job = table.Rows[i][0].ToString();
                for (int j = 0; j < job.Length; j++)
                {
                    if (job[j] >= '0' && job[j] <= '9')
                        make += job[j];
                    else
                        break;
                }
                if (count.ToString() != make)
                    break;
                make = "";
                count++;
            }
            return count.ToString();
        }

        public bool insertRent(string id, MemoryStream pic)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO TRANS_RENT VALUES (@ID, @PIC)", Database.Instance.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@PIC", SqlDbType.Image).Value = pic.ToArray();

            Database.Instance.openConnect();

            if (cmd.ExecuteNonQuery()==1)
            {
                Database.Instance.closeConnection();
                return true;
            }
            Database.Instance.closeConnection();
            return false;
        }

        public DataTable getAllRent()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM TRANS_RENT", Database.Instance.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            return table;
        }

        public string makeID ()
        {
            SqlCommand command = new SqlCommand("SELECT ID FROM CONTRACT ORDER BY CONVERT(INT, ID)", Database.Instance.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);

            int count = 1;
            string job;
            string make = "";
            for (int i = 0; i < table.Rows.Count; ++i)
            {
                job = table.Rows[i][0].ToString();
                for (int j = 0; j < job.Length; j++)
                {
                    if (job[j] >= '0' && job[j] <= '9')
                        make += job[j];
                    else
                        break;
                }
                if (count.ToString() != make)
                    break;
                make = "";
                count++;
            }
            return count.ToString();
        }
        public DataTable getAllContract ()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM CONTRACT", Database.Instance.getConnection);

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            return table;
        }

        public bool updateParked (string id, DateTime start, string type, DateTime rental)
        {
            SqlCommand cmd = new SqlCommand("UPDATE PARKED_CAR SET TYPE_OF_CUSTOMER = @TYPE, RENTAL_TERM = @RENTAL WHERE ID = @ID AND CONVERT(DATE,TIME_START) = CONVERT(DATE,@START)", Database.Instance.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
            cmd.Parameters.Add($"@TYPE", SqlDbType.NVarChar).Value = type;
            cmd.Parameters.Add("@RENTAL", SqlDbType.DateTime).Value = rental;
            cmd.Parameters.Add("@START", SqlDbType.DateTime).Value = start;

            Database.Instance.openConnect();

            if (cmd.ExecuteNonQuery() >= 1)
            {
                Database.Instance.closeConnection();
                return true;
            }
            Database.Instance.closeConnection();
            return false;
        }
        public bool insertContract(string id, string id_cus, string trans, string type, DateTime start, DateTime rent, int price)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO CONTRACT VALUES (@ID, @CUS, @TRANS, @TYPE, @START, @RENTAL, NULL, @PRICE, 0,NULL)", Database.Instance.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@CUS", SqlDbType.VarChar).Value = id_cus;
            cmd.Parameters.Add("@TRANS", SqlDbType.VarChar).Value = trans;
            cmd.Parameters.Add($"@TYPE", SqlDbType.NVarChar).Value = type;
            cmd.Parameters.Add("@START", SqlDbType.DateTime).Value = start;
            cmd.Parameters.Add("@RENTAL", SqlDbType.DateTime).Value = rent;
            cmd.Parameters.Add("@PRICE", SqlDbType.Int).Value = price;

            Database.Instance.openConnect();

            if (cmd.ExecuteNonQuery() == 1)
            {
                Database.Instance.closeConnection();
                return true;
            }
            Database.Instance.closeConnection();
            return false;
        }
    }
}
