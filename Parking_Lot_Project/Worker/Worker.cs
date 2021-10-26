using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking_Lot_Project
{
    class Worker
    {
        #region 

        //public DataTable getEmp (string call)
        //{
        //    DataTable table = new DataTable();

        //}
        #endregion

        public static volatile Worker instance;
        private static object key = new object();

        public static Worker Instance
        {
            get
            {
                if (instance == null)
                {
                    lock(key)
                    {
                        instance = new Worker();
                    }                  
                }
                return instance;
            }
        }
        public DataTable getEmp (string id)
        {
            DataTable table = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM EMP WHERE ID = @ID", Database.Instance.getConnection);
                cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(table);
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            return table;
        }
        public void formatTable(DataTable table)
        {
            for (int i = 0; i < table.Rows.Count; ++i)
            {
                if (table.Rows[i][6].ToString() != "Male")
                    table.Rows[i][6] = "Nữ";
                else
                    table.Rows[i][6] = "Nam";
            }
        }
        public DataTable getListWork()
        {
            DataTable table = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT ID, NAME_WORK FROM WORK", Database.Instance.getConnection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(table);
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            return table;          
        }
        public DataTable listEmp()
        {
            DataTable table = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM EMP", Database.Instance.getConnection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(table);
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            return table;
        }

        public DataTable getEmpByID(string id)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM EMP WHERE ID = @ID", Database.Instance.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            return table;
        }

        public DataTable getAllSpec(string id)
        {
            SqlCommand cmd = new SqlCommand("select SPECIALIZE.NAME_SPEC  from emp, WORKING, SPECIALIZE, WORK WHERE EMP.ID = WORKING.ID_EMP AND SPECIALIZE.ID_WORK = WORK.ID AND WORKING.ID_SPEC = SPECIALIZE.ID AND EMP.ID = @ID", Database.Instance.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            return table;
        }

        public DataTable getAllEmp()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM EMP ORDER BY CONVERT(INT,ID)", Database.Instance.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            return table;
        }

        public DataTable getAllEmpWork(string id)
        {
            SqlCommand cmd = new SqlCommand("select EMP.ID, FNAME, LNAME, CMND, BDATE, PHONE, ADDR, GENDER, IMG from emp, WORKING, SPECIALIZE, WORK WHERE EMP.ID = WORKING.ID_EMP AND SPECIALIZE.ID_WORK = WORK.ID AND WORKING.ID_SPEC = SPECIALIZE.ID AND WORK.ID = @ID", Database.Instance.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            return table;
        }
        //insert worker
        public bool insert_worker(string id, string fName, string lname,string cmnd, string bdate, string phone, string addr, string gender, MemoryStream pic)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM EMP WHERE CMND = @CMND", Database.Instance.getConnection);
            command.Parameters.Add("@CMND", SqlDbType.VarChar).Value = cmnd;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Đã tồn tại nhân viên này", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            SqlCommand cmd = new SqlCommand("INSERT INTO EMP VALUES (@ID, @FNAME, @LNAME, @CMND, @BDATE,@PHONE, @ADDR, @GENDER, @IMAGE)", Database.Instance.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@FNAME", SqlDbType.NVarChar).Value = fName;
            cmd.Parameters.Add("@LNAME", SqlDbType.NVarChar).Value = lname;
            cmd.Parameters.Add("@CMND", SqlDbType.VarChar).Value = cmnd;
            cmd.Parameters.Add("@BDATE", SqlDbType.Date).Value = bdate;
            cmd.Parameters.Add("@PHONE", SqlDbType.VarChar).Value = phone;
            cmd.Parameters.Add("@ADDR", SqlDbType.NVarChar).Value = addr;
            cmd.Parameters.Add("@GENDER", SqlDbType.NVarChar).Value = gender;
            cmd.Parameters.Add("@IMAGE", SqlDbType.Image).Value = pic.ToArray();

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

        //Procedure make ID for worker
        public string makeID ()
        {
            //string strSql;
            //if (work[0] == 'F')
            //    strSql = "EXECUTE LIST_FIXER";
            //else if (work[0] == 'W')
            //    strSql = "EXECUTE LIST_WASHER";
            //else 
            //    strSql = "EXECUTE LIST_SERCURITY";
          
            SqlCommand command = new SqlCommand("SELECT ID FROM EMP ORDER BY CONVERT(INT,ID)", Database.Instance.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);

            int count = 1;
            string job;
            string make = "";
            for (int i=0; i< table.Rows.Count; ++i)
            {
                job = table.Rows[i][0].ToString();
                for (int j=0;j<job.Length ; j++)
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
        //Delete Worker
        public bool deleteWorker (string id)
        {
            SqlCommand command = new SqlCommand("EXECUTE DELETE_WORKER @ID", Database.Instance.getConnection);
            command.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
            Database.Instance.openConnect();

            if (command.ExecuteNonQuery() == 1)
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

        public DataTable getAllSerVice(int id)
        {
            SqlCommand cmd = new SqlCommand("SELECT SPECIALIZE.ID, NAME_SPEC, PRICE FROM SPECIALIZE, PRICE_SERVICE WHERE SPECIALIZE.ID = PRICE_SERVICE.ID AND SPECIALIZE.ID_WORK = @ID", Database.Instance.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            return table;
        }
        // Edit worker
        public string makeIDService ()
        {
            SqlCommand command = new SqlCommand("SELECT ID FROM SERVICE_PARK", Database.Instance.getConnection);
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
        public int getPrice(string id)
        {
            SqlCommand cmd = new SqlCommand("SELECT PRICE FROM PRICE_SERVICE WHERE ID = @ID", Database.Instance.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            return int.Parse(table.Rows[0][0].ToString());
        }
        public string[] getNameAndPrice(string id)
        {
            string[] result = new string[2];
            SqlCommand cmd = new SqlCommand("SELECT NAME_SPEC, PRICE FROM SPECIALIZE, PRICE_SERVICE WHERE SPECIALIZE.ID = PRICE_SERVICE.ID AND SPECIALIZE.ID = @ID", Database.Instance.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            result[0] = table.Rows[0][0].ToString();
            result[1] = table.Rows[0][1].ToString();
            return result;
        }
        public bool insertService (string id, MemoryStream user, MemoryStream trans, string name, int price)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO SERVICE_PARK VALUES (@ID, @USER, @TRANS, @NAME, @PRICE)", Database.Instance.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@USER", SqlDbType.Image).Value = user.ToArray();
            cmd.Parameters.Add("@TRANS", SqlDbType.Image).Value =trans.ToArray();
            cmd.Parameters.Add($"@NAME", SqlDbType.NVarChar).Value = name;
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
        public bool editWorker(string ID, string Fname, string Lname,string cmnd, string bdate, string addr, string gender,  MemoryStream picture )
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE EMP SET FNAME = @FNAME,LNAME= @LNAME,CMND = @CMND,BDATE = @BDATE,ADDR = @ADDR,GENDER = @GENDER, IMG = @IMG WHERE ID = @ID", Database.Instance.getConnection);
                cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = ID;
                cmd.Parameters.Add("@FNAME", SqlDbType.VarChar).Value = Fname;
                cmd.Parameters.Add("@LNAME", SqlDbType.VarChar).Value = Lname;
                cmd.Parameters.Add("@CMND", SqlDbType.VarChar).Value = cmnd;
                cmd.Parameters.Add("@BDATE", SqlDbType.VarChar).Value = bdate;
                cmd.Parameters.Add("@ADDR", SqlDbType.VarChar).Value = addr;
                cmd.Parameters.Add("@GENDER", SqlDbType.VarChar).Value = gender;
                cmd.Parameters.Add("@IMG", SqlDbType.Image).Value = picture.ToArray();
                Database.Instance.openConnect();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    Database.Instance.closeConnection();
                    return true;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            Database.Instance.closeConnection();
            return false;
        }
    }
}
