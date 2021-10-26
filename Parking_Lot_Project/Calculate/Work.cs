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
    class Work
    {
        #region singleton
        public static volatile Work instance;
        private static object key = new object();
        
        public static Work Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (key)
                    {
                        instance = new Work();
                    }
                }
                return instance;
            }
        }
        #endregion

        public DataTable getAllWork ()
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM WORK", Database.Instance.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            return table;
        }

        public string getWorkAdmin()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM MANAGE WHERE ID_USER = @ID", Database.Instance.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = Admin.IdWork;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);

            return table.Rows[0][1].ToString();
        }
    }
}
