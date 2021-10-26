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
    public class Bike: Transport
    {
        public static volatile Bike instance;
        private static object key = new object();
        public static Bike Instance
        {
            get
            {
                if (instance == null)
                {
                    lock(key)
                    {
                        instance = new Bike();
                    }
                }
                return instance;
            }
        }
        public bool removeBike(string id)
        {
            SqlCommand cmd = new SqlCommand("DELETE BIKE WHERE ID = @ID", db.getConnection);
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
        public bool editBike(string id, MemoryStream pic_user, MemoryStream pic_trans, string type, DateTime time)
        {
            
            //string timeStart = DateTime.UtcNow.ToString();

            SqlCommand cmd = new SqlCommand("UPDATE BIKE SET PICTURE_USER = @PIC_USER, PICTURE_TRANSPORT = @PIC_TRANS, TYPE_OF_CUSTOMER = @TYPE, TIME_START = @TIME WHERE ID = @ID", db.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("TIME", SqlDbType.DateTime).Value = time;
            cmd.Parameters.Add("@PIC_USER", SqlDbType.Image).Value = pic_user.ToArray();
            cmd.Parameters.Add("@PIC_TRANS", SqlDbType.Image).Value = pic_trans.ToArray();
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
        public bool insertBike (string id, MemoryStream pic_user, MemoryStream pic_trans, string type)
        {
            
            //string timeStart = DateTime.UtcNow.ToString();

            SqlCommand cmd = new SqlCommand("INSERT INTO BIKE VALUES (@ID, @PIC_USER, @PIC_TRANS, @TYPE, GETDATE())", db.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@PIC_USER", SqlDbType.Image).Value = pic_user.ToArray();
            cmd.Parameters.Add("@PIC_TRANS", SqlDbType.Image).Value = pic_trans.ToArray();
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

        public DataTable getBikeByID(string id)
        {
            DataTable table = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT BIKE.ID, PARKED_BIKE.PICTURE_USER, PARKED_BIKE.PICTURE_TRANSPORT, PARKED_BIKE.TYPE_OF_CUSTOMER, PARKED_BIKE.TIME_START, RENTAL_TERM FROM BIKE, PARKED_BIKE WHERE BIKE.ID = PARKED_BIKE.ID AND PARKED_BIKE.PRICE = 0 AND BIKE.ID = @ID ", Database.Instance.getConnection);
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
        public DataTable getAllBike ()
        {
            DataTable table = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM BIKE", Database.Instance.getConnection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(table);
            }
            catch(SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            return table;
        }

        public bool insertParked (string id, MemoryStream pic_user, MemoryStream pic_trans, string type, DateTime rental)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO PARKED_BIKE VALUES (@ID, @PIC_USER, @PIC_TRANS, @TYPE, GETDATE(), @RENTAL, NULL, 0)", db.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@PIC_USER", SqlDbType.Image).Value = pic_user.ToArray();
            cmd.Parameters.Add("@PIC_TRANS", SqlDbType.Image).Value = pic_trans.ToArray();
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

        public bool editParked (string id, MemoryStream pic_user, MemoryStream pic_trans, string type, DateTime timeStart, DateTime rental/*, DateTime end, int price*/)
        {
            //, RENTAL_TIME = @RENTAL, END_TIME = @END, PRICE = @PRC
            SqlCommand cmd = new SqlCommand("UPDATE PARKED_BIKE SET PICTURE_USER = @PIC_USER, PICTURE_TRANSPORT = @PIC_TRANS, TYPE_OF_CUSTOMER = @TYPE, TIME_START = @TIME, RENTAL_TERM = @RENTAL WHERE ID = @ID", db.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("TIME", SqlDbType.DateTime).Value = timeStart;
            cmd.Parameters.Add("@PIC_USER", SqlDbType.Image).Value = pic_user.ToArray();
            cmd.Parameters.Add("@PIC_TRANS", SqlDbType.Image).Value = pic_trans.ToArray();
            cmd.Parameters.Add("@TYPE", SqlDbType.VarChar).Value = type;
            cmd.Parameters.Add("@RENTAL", SqlDbType.DateTime).Value = rental;
            //cmd.Parameters.Add("@END", SqlDbType.DateTime).Value = end;
            //cmd.Parameters.Add("@PRC", SqlDbType.Int).Value = price;

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

        public bool updateOut(string id, DateTime start, DateTime end, int price)
        {
            SqlCommand cmd = new SqlCommand("UPDATE PARKED_BIKE SET END_TIME = @END, PRICE = @PRC WHERE ID = @ID AND CONVERT(DATE,TIME_START) = CONVERT(DATE, @START)", Database.Instance.getConnection);
            cmd.Parameters.Add("@END", SqlDbType.DateTime).Value = end;
            cmd.Parameters.Add("@PRC", SqlDbType.Int).Value = price;
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@START", SqlDbType.DateTime).Value = start;

            Database.Instance.openConnect();

            if (cmd.ExecuteNonQuery() == 1)
            {
                Database.Instance.closeConnection();
                return true;
            }
            Database.Instance.closeConnection();
            return false;
        }
        public DataTable getParked ()
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM PARKED_BIKE", Database.Instance.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            return table;
        }

        public DataTable getParkedByDate(DateTime time)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM PARKED_BIKE WHERE CONVERT(DATE,TIME_START) = CONVERT (DATE,@TIME)", Database.Instance.getConnection);
            cmd.Parameters.Add("@TIME", SqlDbType.DateTime).Value = time;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            return table;
        }

        public DataTable getParkedByRental (DateTime time)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM PARKED_BIKE WHERE CONVERT(DATE,RENTAL_TERM) = CONVERT (DATE,@TIME)", Database.Instance.getConnection);
            cmd.Parameters.Add("@TIME", SqlDbType.DateTime).Value = time;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            return table;
        }

        public DataTable getParkedByTimeEnd(DateTime time)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM PARKED_BIKE WHERE CONVERT(DATE,END_TIME) = CONVERT (DATE,@TIME)", Database.Instance.getConnection);
            cmd.Parameters.Add("@TIME", SqlDbType.DateTime).Value = time;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            return table;
        }
    }
}
