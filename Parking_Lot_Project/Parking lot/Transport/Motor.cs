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
    class Motor: Transport
    {
        public static volatile Motor instance;

        private static object key = new object();




        public static Motor Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Motor();
                }
                return instance;
            }
        }

        public bool removeMotor(string id)
        {
            SqlCommand cmd = new SqlCommand("DELETE MOTOR WHERE ID = @ID", db.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;


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
        public bool editMotor(string id, MemoryStream pic_user, MemoryStream pic_plate, string license, string type)
        {

            //string timeStart = DateTime.UtcNow.ToString();

            SqlCommand cmd = new SqlCommand("UPDATE MOTOR SET PICTURE_USER = @PIC_USER,LICENSE_PLATES_PIC  = @PIC_PLATE,LICENSE_PLATES = @LICENSE, TYPE_OF_CUSTOMER = @TYPE WHERE ID = @ID", db.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@PIC_USER", SqlDbType.Image).Value = pic_user.ToArray();
            cmd.Parameters.Add("@PIC_TRANS", SqlDbType.Image).Value = pic_plate.ToArray();
            cmd.Parameters.Add("@LICENSE", SqlDbType.VarChar).Value = license;
            cmd.Parameters.Add("@TYPE", SqlDbType.VarChar).Value = type;

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
        public bool insertMotor(string id,  MemoryStream pic_user, MemoryStream pic_plate, string license, string type)
        {

            //string timeStart = DateTime.UtcNow.ToString();

            SqlCommand cmd = new SqlCommand("INSERT INTO MOTOR VALUES (@ID,@PIC_USER, @PIC_PLATE, @LICENSE, @TYPE, GETDATE())", db.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@PIC_USER", SqlDbType.Image).Value = pic_user.ToArray();
            cmd.Parameters.Add("@PIC_PLATE", SqlDbType.Image).Value = pic_plate.ToArray();
            cmd.Parameters.Add("@LICENSE", SqlDbType.VarChar).Value = license;
            cmd.Parameters.Add("@TYPE", SqlDbType.VarChar).Value = type;

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
        public DataTable getAllMotor()
        {
            DataTable table = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM MOTOR", Database.Instance.getConnection);
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
        public DataTable getMotorParked()
        {
            DataTable table = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM PARKED_MOTOR", Database.Instance.getConnection);
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
        public bool insertMotorParked(string id, MemoryStream pic_user, MemoryStream pic_plate, string license, string type,  DateTime rental)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO PARKED_MOTOR VALUES (@ID,@PIC_USER, @PIC_PLATE, @LICENSE, @TYPE, GETDATE(), @RENTAL, NULL, 0)", db.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@PIC_USER", SqlDbType.Image).Value = pic_user.ToArray();
            cmd.Parameters.Add("@PIC_PLATE", SqlDbType.Image).Value = pic_plate.ToArray();
            cmd.Parameters.Add("@LICENSE", SqlDbType.VarChar).Value = license;
            cmd.Parameters.Add("@TYPE", SqlDbType.VarChar).Value = type;
            cmd.Parameters.Add("@RENTAL", SqlDbType.DateTime).Value = rental;
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
        public bool editParked(string id, MemoryStream pic_user, MemoryStream pic_plate, string license, string type,DateTime time,  DateTime rental)
        {
            SqlCommand cmd = new SqlCommand("UPDATE PARKED_MOTOR SET PICTURE_USER = @PIC_USER,LICENSE_PLATES_PIC  = @PIC_PLATE,LICENSE_PLATES = @LICENSE, TYPE_OF_CUSTOMER = @TYPE, RENTAL_TERM = @RENTAL WHERE ID = @ID AND TIME_START = @TIME", db.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@TIME", SqlDbType.DateTime).Value = time;
            cmd.Parameters.Add("@PIC_USER", SqlDbType.Image).Value = pic_user.ToArray();
            cmd.Parameters.Add("@PIC_PLATE", SqlDbType.Image).Value = pic_plate.ToArray();
            cmd.Parameters.Add("@LICENSE", SqlDbType.VarChar).Value = license;
            cmd.Parameters.Add("@TYPE", SqlDbType.VarChar).Value = type;
            cmd.Parameters.Add("@RENTAL", SqlDbType.DateTime).Value = rental;

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
        public bool updateParked (string id, DateTime start, DateTime end, int price)
        {
            SqlCommand cmd = new SqlCommand("UPDATE PARKED_MOTOR SET END_TIME = @END, PRICE = @PRC WHERE ID = @ID AND CONVERT(DATE,TIME_START) = CONVERT(DATE, @START)", Database.Instance.getConnection);
            cmd.Parameters.Add("@END", SqlDbType.DateTime).Value = end;
            cmd.Parameters.Add("@PRC", SqlDbType.Int).Value = price;
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@START", SqlDbType.DateTime).Value = start;

            Database.Instance.openConnect();

            if (cmd.ExecuteNonQuery() >= 1)
            {
                Database.Instance.closeConnection();
                return true;
            }
            Database.Instance.closeConnection();
            return false;
        }
        public string getPlate(int key)
        {
            SqlCommand cmd = new SqlCommand("SELECT PLATE FROM DETECT_MOTOR WHERE ID = @ID", Database.Instance.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = key;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table.Rows[0][0].ToString();
        }

        public DataTable getParkedByDate(DateTime time)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM PARKED_MOTOR WHERE CONVERT(DATE,TIME_START) = CONVERT (DATE,@TIME)", Database.Instance.getConnection);
            cmd.Parameters.Add("@TIME", SqlDbType.DateTime).Value = time;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            return table;
        }

        public DataTable getParkedByRental(DateTime time)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM PARKED_MOTOR WHERE CONVERT(DATE,RENTAL_TERM) = CONVERT (DATE,@TIME)", Database.Instance.getConnection);
            cmd.Parameters.Add("@TIME", SqlDbType.DateTime).Value = time;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            return table;
        }

        public DataTable getParkedByTimeEnd(DateTime time)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM PARKED_MOTOR WHERE CONVERT(DATE,END_TIME) = CONVERT (DATE,@TIME)", Database.Instance.getConnection);
            cmd.Parameters.Add("@TIME", SqlDbType.DateTime).Value = time;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            return table;
        }

        public DataTable getMotorByID(string id)
        {
            SqlCommand cmd = new SqlCommand("SELECT MOTOR.ID, MOTOR.PICTURE_USER, MOTOR.LICENSE_PLATES_PIC, MOTOR.LICENSE_PLATES, MOTOR.TYPE_OF_CUSTOMER, MOTOR.TIME_START, PARKED_MOTOR.RENTAL_TERM FROM MOTOR, PARKED_MOTOR WHERE MOTOR.ID = PARKED_MOTOR.ID AND PARKED_MOTOR.PRICE = 0 AND MOTOR.ID = @ID", Database.Instance.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            return table;
        }
    }
}
