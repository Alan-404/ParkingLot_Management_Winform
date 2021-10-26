using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Parking_Lot_Project
{
    class Customer
    {

        public static volatile Customer instance;

        static object key = new object();

        public static Customer Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (key)
                    {
                        instance = new Customer();
                    }
                }
                return instance;
            }
        }

        public string makeID()
        {
            SqlCommand command = new SqlCommand("SELECT ID FROM CUSTOMER", Database.Instance.getConnection);
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
                for (int j = 8; j < job.Length; j++)
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

        public DataTable getAllCustomer()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM CUSTOMER", Database.Instance.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            return table;
        }

        public DataTable getCusByID(string id)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM CUSTOMER WHERE ID = @ID", Database.Instance.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            return table;
        }
        public DataTable getCustomerService (string id)
        {
            SqlCommand cmd = new SqlCommand("select SPECIALIZE.id, PIC_USER, PIC_TRANS,SPECIALIZE.NAME_SPEC, PRICE from SPECIALIZE, SERVICE_PARK WHERE SPECIALIZE.NAME_SPEC = SERVICE_PARK.NAME_SERVICE AND SPECIALIZE.ID_WORK = @ID", Database.Instance.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            return table;
        }

        public bool removeCustomer(string id)
        {
            SqlCommand cmd = new SqlCommand("DELETE CUSTOMER WHERE ID = @ID", Database.Instance.getConnection);
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

        public bool editCustomer(string id, string fname, string lname, DateTime bdate, string phone, string gender, string country, string addr, string mail, MemoryStream pic)
        {
            SqlCommand cmd = new SqlCommand("UPDATE CUSTOMER SET FNAME= @FNAME,LNAME =@LNAME,BDATE =@BDATE,PHONE =  @PHONE,GENDER = @GENDER,COUNTRY = @COUNTRY,ADDR = @ADDR,GMAIL= @GMAIL, IMG= @IMG WHERE ID = @ID", Database.Instance.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@FNAME", SqlDbType.NVarChar).Value = fname;
            cmd.Parameters.Add("@LNAME", SqlDbType.NVarChar).Value = lname;
            cmd.Parameters.Add("@BDATE", SqlDbType.DateTime).Value = bdate;
            cmd.Parameters.Add("@PHONE", SqlDbType.VarChar).Value = phone;
            cmd.Parameters.Add("@GENDER", SqlDbType.VarChar).Value = gender;
            cmd.Parameters.Add("@COUNTRY", SqlDbType.NVarChar).Value = country;
            cmd.Parameters.Add("@ADDR", SqlDbType.Text).Value = addr;
            cmd.Parameters.Add("@GMAIL", SqlDbType.VarChar).Value = mail;
            cmd.Parameters.Add("@IMG", SqlDbType.Image).Value = pic.ToArray();

            Database.Instance.openConnect();
            if (cmd.ExecuteNonQuery() == 1)
            {
                Database.Instance.closeConnection();
                return true;
            }
            Database.Instance.closeConnection();
            return false;
        }
        public bool addCustomer (string id, string fname, string lname, DateTime bdate, string phone, string gender, string country, string addr, string mail, MemoryStream pic)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO CUSTOMER VALUES (@ID, @FNAME, @LNAME, @BDATE, @PHONE, @GENDER, @COUNTRY, @ADDR, @GMAIL, @IMG)", Database.Instance.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@FNAME", SqlDbType.NVarChar).Value = fname;
            cmd.Parameters.Add("@LNAME", SqlDbType.NVarChar).Value = lname;
            cmd.Parameters.Add("@BDATE", SqlDbType.DateTime).Value = bdate;
            cmd.Parameters.Add("@PHONE", SqlDbType.VarChar).Value = phone;
            cmd.Parameters.Add("@GENDER", SqlDbType.VarChar).Value = gender;
            cmd.Parameters.Add("@COUNTRY", SqlDbType.NVarChar).Value = country;
            cmd.Parameters.Add("@ADDR", SqlDbType.Text).Value = addr;
            cmd.Parameters.Add("@GMAIL", SqlDbType.VarChar).Value = mail;
            cmd.Parameters.Add("@IMG", SqlDbType.Image).Value = pic.ToArray();

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
