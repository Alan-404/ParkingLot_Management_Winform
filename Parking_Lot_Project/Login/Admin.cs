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
    class Admin
    {
        #region singleton Admin
        public static volatile Admin instance;

        static object key = new object();
        public static Admin Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (key)
                    {
                        instance = new Admin();
                    }
                }
                return instance;
            }
        }
        #endregion
        public static string userID { get; private set; }
        public static string userAccess { get; private set; }
        public static string IdWork { get; private set; }
        public static void getIdWork(string id)
        {
            IdWork = id;
        }
        
        public static void getuserID (string user, string access)
        {
            userID = user;
            userAccess = access;
        }
        public DataTable login (string username, string pass)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM ADMIN WHERE USERNAME= @USER AND PASS = @PASS",Database.Instance.getConnection);
            cmd.Parameters.Add("@USER", SqlDbType.VarChar).Value = username;
            cmd.Parameters.Add("@PASS", SqlDbType.VarChar).Value = pass;

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;

            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }
        public bool editAdmin (string pass)
        {
            SqlCommand cmd = new SqlCommand("UPDATE ADMIN SET PASS = @PASS WHERE ID = @ID", Database.Instance.getConnection);
            cmd.Parameters.Add("@PASS", SqlDbType.VarChar).Value = pass;
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = Admin.userID;

            Database.Instance.openConnect();

            if (cmd.ExecuteNonQuery() == 1)
            {
                Database.Instance.closeConnection();
                return true;
            }
            Database.Instance.closeConnection();
            return false;
        }
        public bool insertAdmin (string fullName, string userName, string passWord, string access, MemoryStream pic)
        {
            string id;
            SqlCommand cmd = new SqlCommand("SELECT * FROM ADMIN WHERE USERNAME = @USER AND PASS = @PASS", Database.Instance.getConnection);
            cmd.Parameters.Add("@USER", SqlDbType.VarChar).Value = userName;
            cmd.Parameters.Add("@PASS", SqlDbType.VarChar).Value = passWord;

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;

            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Tài khoản đã tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            SqlCommand cd = new SqlCommand("SELECT * FROM ADMIN", Database.Instance.getConnection);
            SqlDataAdapter ap = new SqlDataAdapter();
            ap.SelectCommand = cd;
            DataTable tb = new DataTable();
            ap.Fill(tb);

            if (tb.Rows.Count == 0)
                id = "1";
            else
            {
                int count = 1;
                for (int i = 0; i < tb.Rows.Count; ++i)
                {
                    if (count != int.Parse(tb.Rows[i][0].ToString()))
                        break;
                    ++count;
                }
                id = count.ToString();
            }
            

            SqlCommand command = new SqlCommand("INSERT INTO ADMIN VALUES (@ID, @NAME, @USERNAME, @PASS, @ACCESS, @IMG)", Database.Instance.getConnection);
            command.Parameters.Add("ID", SqlDbType.VarChar).Value = id;
            command.Parameters.Add("@NAME", SqlDbType.NVarChar).Value = fullName;
            command.Parameters.Add("@USERNAME", SqlDbType.VarChar).Value = userName;
            command.Parameters.Add("@PASS", SqlDbType.VarChar).Value = passWord;
            command.Parameters.Add("@ACCESS", SqlDbType.VarChar).Value = access;
            command.Parameters.Add("@IMG", SqlDbType.Image).Value = pic.ToArray();

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
        public bool deleteAdmin (string id)
        {
            SqlCommand cmd = new SqlCommand("DELETE ADMIN WHERE ID = @ID", Database.Instance.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;

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
        public string[] getName (string fullName)
        {
            string[] name = new string[2];
            string fName = "";
            string lName = "";
            int count = fullName.Length - 1;

            while (count >= 0)
            {
                if (fullName[count] == ' ')
                    break;
                --count;
            }
            for (int i = 0; i < count; ++i)
                fName += fullName[i];

            for (int i = count + 1; i < fullName.Length; ++i)
                lName += fullName[i];
            name[0] = fName;
            name[1] = lName;
            return name;
        }
        public DataTable getAdmin()
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM ADMIN WHERE ID = @ID", Database.Instance.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = userID;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            return table;
        }

        public DataTable getManager()
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM ADMIN WHERE USERNAME LIKE 'A%'", Database.Instance.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = userID;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            return table;
        }
    }
}
