using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_Lot_Project
{
    class Specialize
    {
        public static volatile Specialize instance;

        static object key = new object();
        public static Specialize Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (key)
                    {
                        instance = new Specialize();
                    }
                }
                return instance;
            }
        }

        public DataTable getAllSpec ()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM SPECIALIZE", Database.Instance.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getSpecByWord (string id)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM SPECIALIZE WHERE ID_WORK = @ID", Database.Instance.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool insertWorking(string id, string spec)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO WORKING VALUES (@ID, @SPEC)", Database.Instance.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@SPEC", SqlDbType.VarChar).Value = spec;


            Database.Instance.openConnect();

            if (cmd.ExecuteNonQuery() == 1)
            {
                Database.Instance.closeConnection();
                return true;
            }
            Database.Instance.closeConnection();
            return false;
        }

        public bool insertSpec(string id, string name, string work)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO SPECIALIZE VALUES (@ID, @NAME, @SPEC)", Database.Instance.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
            cmd.Parameters.Add($"@NAME", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@SPEC", SqlDbType.VarChar).Value = work;

            Database.Instance.openConnect();

            if (cmd.ExecuteNonQuery() == 1)
            {
                Database.Instance.closeConnection();
                return true;
            }
            Database.Instance.closeConnection();
            return false;
        }

        public string makeID()
        {
            SqlCommand command = new SqlCommand("SELECT ID FROM SPECIALIZE ORDER BY CONVERT (INT, ID)", Database.Instance.getConnection);
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

        public bool editSpec (string id, string name)
        {
            SqlCommand cmd = new SqlCommand("UPDATE SPECIALLIZE SET NAME_SPEC = @NAME WHERE ID = @ID", Database.Instance.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
            cmd.Parameters.Add($"@NAME", SqlDbType.NVarChar).Value = name;

            Database.Instance.openConnect();

            if (cmd.ExecuteNonQuery() == 1)
            {
                Database.Instance.closeConnection();
                return true;
            }
            Database.Instance.closeConnection();
            return false;
        }

        public bool removeSpec(string id)
        {
            SqlCommand cmd = new SqlCommand("DELETE SPECIALLIZE WHERE ID = @ID", Database.Instance.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;

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
