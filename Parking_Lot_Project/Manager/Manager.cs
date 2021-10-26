using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking_Lot_Project
{
    class Manager
    {
        #region Singleton
        public static volatile Manager instance;

        private static object key = new object();

        public static Manager Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (key)
                    {
                        instance = new Manager();
                    }
                }
                return instance;
            }
        }
        #endregion

        public bool insertManager(string emp, string id)
        {
            #region truy vấn
            SqlCommand cmd = new SqlCommand("SELECT * FROM MANAGE WHERE ID_USER = @ID AND ID_WORK = @ID_WORK", Database.Instance.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = emp;
            cmd.Parameters.Add("@ID_WORK", SqlDbType.VarChar).Value = id;
            SqlDataAdapter ad = new SqlDataAdapter();
            ad.SelectCommand = cmd;
            DataTable table = new DataTable();
            ad.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Đã tồn tại quản lý này cho công việc đó");
            }
            #endregion

            SqlCommand command = new SqlCommand("INSERT INTO MANAGE VALUES (@ID_USER, @ID_WORK)", Database.Instance.getConnection);
            command.Parameters.Add("@ID_USER", SqlDbType.VarChar).Value = emp;
            command.Parameters.Add("@ID_WORK", SqlDbType.VarChar).Value = id;

            Database.Instance.openConnect();

            if (command.ExecuteNonQuery() == 1)
            {
                Database.Instance.closeConnection();
                return true;
            }
            Database.Instance.closeConnection();
            return false;
        }

        public bool deleteManager (string id)
        {
            SqlCommand command = new SqlCommand("DELETE MANAGE WHERE ID_USER = @ID", Database.Instance.getConnection);
            command.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;

            Database.Instance.openConnect();

            if (command.ExecuteNonQuery() == 1)
            {
                Database.Instance.closeConnection();
                return true;
            }
            Database.Instance.closeConnection();
            return false;
        }
    }
}
