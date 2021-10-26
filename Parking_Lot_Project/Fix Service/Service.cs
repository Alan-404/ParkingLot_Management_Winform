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
    
    class Service
    {
        #region
        public Dictionary<string, int> serviceBike = new Dictionary<string, int>();
        public Dictionary<string, int> serviceMotor = new Dictionary<string, int>();
        public Dictionary<string, int> serviceCar = new Dictionary<string, int>();
        Database db = new Database();

        #endregion

        public void makeServiceBike ()
        {
            SqlCommand cmd = new SqlCommand("SELECT TYPE_SERVICE, PRICE FROM SERVICE_FIX WHERE TYPE_TRANSPORT LIKE 'B%'", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);

            for (int i = 0; i < table.Rows.Count; ++i)
            {
                serviceBike.Add(table.Rows[i][0].ToString(), (int)table.Rows[i][1]);
            }
        }

        public void makeServiceMotor()
        {
            SqlCommand cmd = new SqlCommand("SELECT TYPE_SERVICE, PRICE FROM SERVICE_FIX WHERE TYPE_TRANSPORT LIKE 'M%'", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);

            for (int i = 0; i < table.Rows.Count; ++i)
            {
                serviceMotor.Add(table.Rows[i][0].ToString(), (int)table.Rows[i][1]);
            }
        }

        public void makeServiceCar()
        {
            SqlCommand cmd = new SqlCommand("SELECT TYPE_SERVICE, PRICE FROM SERVICE_FIX WHERE TYPE_TRANSPORT LIKE 'C%'", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);

            for (int i = 0; i < table.Rows.Count; ++i)
            {
                serviceCar.Add(table.Rows[i][0].ToString(), (int)table.Rows[i][1]);
            }
        }
    }
}
