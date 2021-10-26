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
    class Car: Transport
    {
        public static volatile Car instance;

        private static object key = new object();

        public static Car Instance
        {
            get
            {
                if (instance == null)
                {
                    lock(key)
                    {
                        instance = new Car();
                    }
                }
                return instance;
            }
        }

        public string detectCar(int id)
        {
            SqlCommand cmd = new SqlCommand("SELECT PLATE FROM DETECT_CAR WHERE ID = @ID", Database.Instance.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            return table.Rows[0][0].ToString();
        }

        public bool insertCar (string id, MemoryStream pic_brand, MemoryStream pic_license, string license, string type)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO CAR VALUES (@ID, @PIC_BRAND, @PIC_LIC, @LIC, @TYPE, GETDATE())", Database.Instance.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@PIC_BRAND", SqlDbType.Image).Value = pic_brand.ToArray(); ;
            cmd.Parameters.Add("@PIC_LIC", SqlDbType.Image).Value = pic_license.ToArray();
            cmd.Parameters.Add("@LIC", SqlDbType.VarChar).Value = license;
            cmd.Parameters.Add("@TYPE", SqlDbType.VarChar).Value = type;

            Database.Instance.openConnect();
            if (cmd.ExecuteNonQuery() == 1)
            {
                Database.Instance.closeConnection();
                return true;
            }
            Database.Instance.closeConnection();
            return false;
        }
        public bool insertCarParked (string id, MemoryStream pic_brand, MemoryStream pic_license, string license, string type, DateTime rental)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO PARKED_CAR VALUES (@ID, @PIC_BRAND, @PIC_LIC, @LIC, @TYPE, GETDATE(), @RENTAL,NULL,0 )", Database.Instance.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@PIC_BRAND", SqlDbType.Image).Value = pic_brand.ToArray(); ;
            cmd.Parameters.Add("@PIC_LIC", SqlDbType.Image).Value = pic_license.ToArray();
            cmd.Parameters.Add("@LIC", SqlDbType.VarChar).Value = license;
            cmd.Parameters.Add("@TYPE", SqlDbType.VarChar).Value = type;
            cmd.Parameters.Add("@RENTAL", SqlDbType.DateTime).Value = rental;
            Database.Instance.openConnect();
            if (cmd.ExecuteNonQuery() == 1)
            {
                Database.Instance.closeConnection();
                return true;
            }
            Database.Instance.closeConnection();
            return false;

        }
        public bool removeCar(string id)
        {
            SqlCommand cmd = new SqlCommand("DELETE CAR WHERE ID = @ID", Database.Instance.getConnection);
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

        public bool updateParked(string id, DateTime start, DateTime end, int price)
        {
            SqlCommand cmd = new SqlCommand("UPDATE PARKED_CAR SET END_TIME = @END, PRICE = @PRC WHERE ID = @ID AND CONVERT(DATE,TIME_START) = CONVERT(DATE, @START)", Database.Instance.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@PRC", SqlDbType.Int).Value = price;
            cmd.Parameters.Add("@START", SqlDbType.DateTime).Value = start;
            cmd.Parameters.Add("@END", SqlDbType.DateTime).Value = end;

            Database.Instance.openConnect();
            if (cmd.ExecuteNonQuery() >= 1)
            {
                Database.Instance.closeConnection();
                return true;
            }
            Database.Instance.closeConnection();
            return false;
        }
        public DataTable getAllCar()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM CAR", Database.Instance.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getAllParked()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM PARKED_CAR", Database.Instance.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getCarOut(string id)
        {
            SqlCommand cmd = new SqlCommand("SELECT CAR.ID, CAR.PICTURE_BRAND, CAR.LICENSE_PLATES_PIC, CAR.LICENSE_PLATES, CAR.TYPE_OF_CUSTOMER, CAR.TIME_START, PARKED_CAR.RENTAL_TERM FROM CAR, PARKED_CAR WHERE CAR.ID = PARKED_CAR.ID AND PARKED_CAR.PRICE = 0 AND CAR.ID = @ID", Database.Instance.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            return table;
        }
    }
}
