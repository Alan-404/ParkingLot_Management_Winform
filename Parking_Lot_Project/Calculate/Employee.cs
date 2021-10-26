using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking_Lot_Project
{
    class Employee
    {
        #region 
        Database db = new Database();
        #endregion

        //insert worker
        public bool insert_Emp(string id, string fName, string lname, string cmnd, string bdate, string addr, string gender, string work, MemoryStream pic)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM EMP", db.getConnection);
            command.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Đã tồn tại nhân viên này", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            SqlCommand cmd = new SqlCommand("INSERT INTO EMP VALUES (@ID, @FNAME, @LNAME, @CMND, @BDATE, @ADDR, @GENDER, @WORK,  @IMAGE)", db.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@FNAME", SqlDbType.NVarChar).Value = fName;
            cmd.Parameters.Add("@LNAME", SqlDbType.NVarChar).Value = lname;
            cmd.Parameters.Add("@CMND", SqlDbType.VarChar).Value = cmnd;
            cmd.Parameters.Add("@BDATE", SqlDbType.Date).Value = bdate;
            cmd.Parameters.Add("@ADDR", SqlDbType.NVarChar).Value = addr;
            cmd.Parameters.Add("@GENDER", SqlDbType.NVarChar).Value = gender;
            cmd.Parameters.Add("@WORK", SqlDbType.NVarChar).Value = work;
            cmd.Parameters.Add("@IMAGE", SqlDbType.Image).Value = pic.ToArray();

            db.openConnect();

            if (cmd.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
        //Procedure make ID for worker
        public string makeID(string work)
        {
            string strSql;
            if (work[0] == 'F')
                strSql = "EXECUTE LIST_FIXER";
            else if (work[0] == 'W')
                strSql = "EXECUTE LIST_WASHER";
            else
                strSql = "EXECUTE LIST_SERCURITY";

            SqlCommand command = new SqlCommand(strSql, db.getConnection);
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
                for (int j = 1; j < job.Length; j++)
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
            return work[0] + count.ToString();
        }
        //Delete Worker
        public bool deleteWorker(string id)
        {
            SqlCommand command = new SqlCommand("EXECUTE DELETE_WORKER @ID", db.getConnection);
            command.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
            db.openConnect();

            if (command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
        // Edit worker
        public bool editWorker(string ID, string Fname, string Lname, string cmnd, string bdate, string addr, string gender, string work, MemoryStream picture)
        {
            SqlCommand cmd = new SqlCommand("EXECUTE EDIT_WORKER @ID, @FNAME, @LNAME, @CMND, @BDATE, @ADDR, @GENDER, @WORK, @IMG", db.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = ID;
            cmd.Parameters.Add("@FNAME", SqlDbType.VarChar).Value = Fname;
            cmd.Parameters.Add("@LNAME", SqlDbType.VarChar).Value = Lname;
            cmd.Parameters.Add("@CMND", SqlDbType.VarChar).Value = cmnd;
            cmd.Parameters.Add("@BDATE", SqlDbType.VarChar).Value = bdate;
            cmd.Parameters.Add("@ADDR", SqlDbType.VarChar).Value = addr;
            cmd.Parameters.Add("@GENDER", SqlDbType.VarChar).Value = gender;
            cmd.Parameters.Add("@WORK", SqlDbType.VarChar).Value = work;
            cmd.Parameters.Add("@IMG", SqlDbType.Image).Value = picture.ToArray();

            db.openConnect();

            if (cmd.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }

        }
    }
}
