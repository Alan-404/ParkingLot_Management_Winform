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
    public class Transport
    {
        protected Database db = new Database();
        public static DateTime start { get; private set; }
        public static int price { get; private set; }
        public static void getDateStart (DateTime time, int Prc)
        {
            start = time;
            price = Prc;
        }
        public static volatile Transport instancet;
        private static object key = new object();
        public static Transport Instancet
        {
            get
            {
                if (instancet == null)
                {
                    lock (key)
                    {
                        instancet = new Transport();
                    }
                }
                return instancet;
            }
        }
        public DateTime getRental(ComboBox cbx, NumericUpDown num)
        {
            if (cbx.SelectedIndex == 0)
            {
                return DateTime.Now.AddDays(1);

            }
            else
            {
                num.Visible = true;
                if (cbx.SelectedIndex == 1)
                    return DateTime.Now.AddDays((int)num.Value);
                else if (cbx.SelectedIndex == 2)
                    return DateTime.Now.AddDays((int)num.Value * 7);
                else if (cbx.SelectedIndex == 3)
                    return DateTime.Now.AddMonths((int)num.Value);
                return DateTime.Now.AddYears((int)num.Value);
            }

        }
        public string makeID (string transport)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM "  +transport + " ORDER BY CONVERT (INT,ID)", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            adapter.Fill(table);

            int count = 1;
            string id;
            string current = "";
            for (int i=0; i<table.Rows.Count; ++i)
            {
                id = table.Rows[i][0].ToString();
                for (int j=0; j<id.Length; ++j)
                {
                    current += id[j];
                }
                if (count.ToString() != current)
                    break;
                count++;
                current = "";
            }
            return count.ToString();
        }

        public DataTable getTrans(string id, string trans)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM PARKED_" + trans + " WHERE ID = @ID", Database.Instance.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            return table;
        }

        public int getCapacity(string name)
        {
            SqlCommand cmd = new SqlCommand("SELECT CAPACITY FROM PARKING_AREA WHERE NAME_AREA = @NAME", Database.Instance.getConnection);
            cmd.Parameters.Add("@NAME", SqlDbType.VarChar).Value = name;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            return int.Parse(table.Rows[0][0].ToString());
        }
    }
}
