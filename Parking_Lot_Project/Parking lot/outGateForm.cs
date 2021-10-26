using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking_Lot_Project
{
    public partial class outGateForm : Form
    {
        public outGateForm()
        {
            InitializeComponent();
        }




        private void convertImg (DataTable table, int column, PictureBox box)
        {
            try
            {
                byte[] data = (byte[])table.Rows[0][column];
                MemoryStream stream = new MemoryStream(data);
                box.Image = Image.FromStream(stream);
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
            
        }

        private int calPriceBike (DataTable table ,DateTime start, DateTime rent, DateTime end)
        {
            int price = 0;
            TimeSpan time = end - start;
            TimeSpan deltaTime = end - rent;
            if (table.Rows[0][3].ToString() == "PASSENGER CUSTOMERS")
            {
                
                price = Calculate.Instance.priceBike(time.Hours, deltaTime.Hours, 1);
            }
            else if (table.Rows[0][3].ToString() == "RENT BY DAY")
            {
                price = Calculate.Instance.priceBike(time.Days, deltaTime.Days, 2);
            }
            else if (table.Rows[0][3].ToString() == "RENT BY MONTH")
            {
                price = Calculate.Instance.priceBike(end.Month - start.Month, end.Month - rent.Month, 3);
            }
            else
            {
                price = Calculate.Instance.priceBike(end.Year - start.Year, end.Year - rent.Year, 4);
            }
            return price;
        }
        private int calPriceMotor(DataTable table, DateTime start, DateTime rent, DateTime end)
        {
            int price = 0;
            TimeSpan time = end - start;
            TimeSpan deltaTime = end - rent;
            if (table.Rows[0][3].ToString() == "PASSENGER CUSTOMERS")
            {

                price = Calculate.Instance.priceMotor(time.Hours, deltaTime.Hours, 1);
            }
            else if (table.Rows[0][3].ToString() == "RENT BY DAY")
            {
                price = Calculate.Instance.priceMotor(time.Days, deltaTime.Days, 2);
            }
            else if (table.Rows[0][3].ToString() == "RENT BY MONTH")
            {
                price = Calculate.Instance.priceMotor(end.Month - start.Month, end.Month - rent.Month, 3);
            }
            else
            {
                price = Calculate.Instance.priceMotor(end.Year - start.Year, end.Year - rent.Year, 4);
            }
            return price;
        }

        private int calPriceCar(DataTable table, DateTime start, DateTime rent, DateTime end)
        {
            int price = 0;
            TimeSpan time = end - start;
            TimeSpan deltaTime = end - rent;
            if (table.Rows[0][3].ToString() == "PASSENGER CUSTOMERS")
            {

                price = Calculate.Instance.priceCar(time.Hours, deltaTime.Hours, 1);
            }
            else if (table.Rows[0][3].ToString() == "RENT BY DAY")
            {
                price = Calculate.Instance.priceCar(time.Days, deltaTime.Days, 2);
            }
            else if (table.Rows[0][3].ToString() == "RENT BY MONTH")
            {
                price = Calculate.Instance.priceCar(end.Month - start.Month, end.Month - rent.Month, 3);
            }
            else
            {
                price = Calculate.Instance.priceCar(end.Year - start.Year, end.Year - rent.Year, 4);
            }
            return price;
        }

        private void textBox_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox_id.Text != "")
                {

                    if (button_removeTransport.Text[10] == 'Đ')
                    {
                        try
                        {
                            DataTable table = Bike.Instance.getBikeByID(textBox_id.Text);
                            convertImg(table, 1, pictureBox_getPic2);
                            convertImg(table, 2, pictureBox_getPic1);
                            DateTime start = (DateTime)table.Rows[0][4];

                            DateTime end = DateTime.Now;
                            DateTime rental = (DateTime)table.Rows[0][5];
                            int price = calPriceBike(table, start, rental, end);

                            label_price.Text = "Tiền: " + price.ToString() + "Đ";
                            Transport.getDateStart(start, price);
                        }
                        catch { MessageBox.Show("Đây không phải là xe đạp"); }

                    }
                    if (button_removeTransport.Text[10] == 'M')
                    {
                        try
                        {
                            DataTable table = Motor.Instance.getMotorByID(textBox_id.Text);
                            convertImg(table, 1, pictureBox_getPic2);
                            convertImg(table, 2, pictureBox_getPic1);
                            DateTime start = (DateTime)table.Rows[0][5];

                            DateTime end = DateTime.Now;
                            DateTime rental = (DateTime)table.Rows[0][6];
                            int price = calPriceMotor(table, start, rental, end);

                            label_price.Text = "Tiền: " + price.ToString() + "Đ";
                            Transport.getDateStart(start, price);
                        }
                        catch { MessageBox.Show("Không có mã thẻ đó"); }
                        
                    }
                    if (button_removeTransport.Text[10] == 'H')
                    {
                        try
                        {
                            DataTable table = Car.Instance.getCarOut(textBox_id.Text);
                            convertImg(table, 1, pictureBox_getPic2);
                            convertImg(table, 2, pictureBox_getPic1);
                            DateTime start = (DateTime)table.Rows[0][5];
                            DateTime end = DateTime.Now;
                            DateTime rental = (DateTime)table.Rows[0][6];
                            int price = calPriceCar(table, start, rental, end);

                            label_price.Text = "Tiền: " + price.ToString() + "Đ";
                            Transport.getDateStart(start, price);
                        }
                        catch { MessageBox.Show("Không có mã thẻ đó"); }
                        
                    }
                }
            }
        }

        private void getOUt()
        {
            pictureBox_getPic1.Image = null;
            pictureBox_getPic2.Image = null;
        }

        private void button_removeTransport_Click(object sender, EventArgs e)
        {
            string id = textBox_id.Text;
            DateTime end = DateTime.Now;
            if (button_removeTransport.Text[10] == 'Đ')
            {


                if (Bike.Instance.removeBike(id) == true && Bike.Instance.updateOut(id, Transport.start, end, Transport.price) == true)
                {
                    getOUt();   
                }
                    
            }
            if (button_removeTransport.Text[10] == 'M')
            {


                if (Motor.Instance.removeMotor(id) == true && Motor.Instance.updateParked(id, Transport.start, end, Transport.price) == true)
                    getOUt();
            }    
            if (button_removeTransport.Text[10] == 'H')
            {
                if (Car.Instance.removeCar(id) == true && Car.Instance.updateParked(id, Transport.start, end, Transport.price) == true)
                    getOUt();
            }
        }

        private void button_getPic2_Click(object sender, EventArgs e)
        {

        }

        private void button_getPic1_Click(object sender, EventArgs e)
        {

        }
    }
}
