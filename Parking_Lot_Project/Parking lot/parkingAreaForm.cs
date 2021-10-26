using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class parkingAreaForm : Form
    {
        Worker worker = new Worker();
        public parkingAreaForm()
        {
            InitializeComponent();
        }
        private void fillChart()
        {
            double bike = Bike.Instance.getAllBike().Rows.Count;
            double motor = Motor.Instance.getAllMotor().Rows.Count;
            double car = Car.Instance.getAllCar().Rows.Count;
            double full = bike + motor + car;
            double percentBike = bike*100 / full;
            double percentMotor = motor * 100 / full;
            double percentCar = car * 100 / full;
            if (percentBike != 0)
                chart_transport.Series["Transport"].Points.AddXY("Xe Đạp\n" + percentBike.ToString("0.00") + "%", bike / full);
            if (percentMotor != 0)
                chart_transport.Series["Transport"].Points.AddXY("Xe Máy\n" + percentMotor.ToString("0.00") + "%", motor / full);
            if (percentCar != 0)
                chart_transport.Series["Transport"].Points.AddXY("Xe Oto\n" + percentCar.ToString("0.00") + "%", car / full);
            label_bike.Text = "Số xe đạp: " + bike.ToString();
            label_motor.Text = "Số xe máy: " + motor.ToString();
            label_car.Text = "Số xe oto: " + car.ToString();
        }
        public void format_dataGridView()
        {
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView_listSercurity.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView_listSercurity.Columns[0].HeaderCell.Value = "Mã Nhân Viên";
            dataGridView_listSercurity.Columns[1].HeaderCell.Value = "Họ";
            dataGridView_listSercurity.Columns[2].HeaderCell.Value = "Tên";
            dataGridView_listSercurity.Columns[3].HeaderCell.Value = "CMND";
            dataGridView_listSercurity.Columns[4].HeaderCell.Value = "Ngày Sinh";
            dataGridView_listSercurity.Columns[5].HeaderCell.Value = "Số Điện Thoại";
            dataGridView_listSercurity.Columns[6].HeaderCell.Value = "Địa chỉ";
            dataGridView_listSercurity.Columns[7].HeaderCell.Value = "Giới tính";
            dataGridView_listSercurity.Columns[8].HeaderCell.Value = "Hình ảnh";

            dataGridView_listSercurity.Columns[0].Width = 80;
            dataGridView_listSercurity.Columns[1].Width = 100;
            dataGridView_listSercurity.Columns[2].Width = 80;
            dataGridView_listSercurity.Columns[3].Width = 100;
            dataGridView_listSercurity.Columns[4].Width = 100;
            dataGridView_listSercurity.Columns[6].Width = 150;
            dataGridView_listSercurity.Columns[7].Width = 100;
            dataGridView_listSercurity.Columns[5].Width = 130;
            //dataGridView_listWorker.Columns[8].Width = 130;


            foreach (DataGridViewRow row in dataGridView_listSercurity.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
            dataGridView_listSercurity.RowTemplate.Height = 50;
            picCol = (DataGridViewImageColumn)dataGridView_listSercurity.Columns[8];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;


            dataGridView_listSercurity.AllowUserToAddRows = false;
        }
        public void formatTable(DataTable table)
        {
            for (int i = 0; i < table.Rows.Count; ++i)
            {
                if (table.Rows[i][6].ToString() != "Male")
                    table.Rows[i][6] = "Nữ";
                else
                    table.Rows[i][6] = "Nam";

                if (table.Rows[i][0].ToString()[0] == 'F')
                    table.Rows[i][7] = "Thợ sửa xe";
                else if (table.Rows[i][0].ToString()[0] == 'W')
                    table.Rows[i][7] = "Thợ rửa xe";
                else
                    table.Rows[i][7] = "Bảo vệ";
            }
        }
        private void timer_getDateAndTime_Tick(object sender, EventArgs e)
        {
            label_date.Text = DateTime.Now.ToString();
            label_time_tabpageManage.Text = DateTime.Now.ToString();
        }

        private void parkingAreaForm_Load(object sender, EventArgs e)
        {
            timer_getDateAndTime.Start();
            dataGridView_listSercurity.DataSource = Worker.Instance.getAllEmpWork("1");
            format_dataGridView();
            fillChart();
        }
        private void button_entrance_Bike_Click(object sender, EventArgs e)
        {
            entranceForm frm = new entranceForm();
            int du = Transport.Instancet.getCapacity("Bike") - Bike.Instance.getAllBike().Rows.Count;
            frm.label_count.Text = "Số Chỗ Dư Hiện Tại: " + du.ToString() ;
            frm.button_addTransport.Text += " đạp";
            frm.label_pic.Text = "Hình xe";
            frm.label_pic2.Text = "Hình \nngười gửi";
            frm.textBox_plateNumber.Visible = false;
            frm.label_plateNumber.Visible = false;
            frm.Show();
        }
        private void button_entranceBikeAndMotor_Click(object sender, EventArgs e)
        {
            entranceForm frm = new entranceForm();
            int du = Transport.Instancet.getCapacity("Motor") - Motor.Instance.getAllMotor().Rows.Count;
            frm.label_count.Text = "Số Chỗ Dư Hiện Tại: " + du.ToString();
            frm.button_addTransport.Text += " máy";
            frm.label_pic.Text = "Hình \nbiển số xe";
            frm.label_pic2.Text = "Hình \nngười gửi";
            frm.Show();
        }
        private void button_entrance_Car_Click(object sender, EventArgs e)
        {
            entranceForm frm = new entranceForm();
            int du = Transport.Instancet.getCapacity("Car") - Car.Instance.getAllCar().Rows.Count;
            frm.label_count.Text = "Số Chỗ Dư Hiện Tại: " + du.ToString();
            frm.button_addTransport.Text += " hơi";
            frm.label_pic.Text = "Hình \nbiển số xe";
            frm.label_pic2.Text = "Hình \nhiệu xe";
            frm.Show();
        }

        private void button_parkingCar_Click(object sender, EventArgs e)
        {
            carListForm frm = new carListForm();
            frm.Show();
        }

        private void button_parkingBicycle_Click(object sender, EventArgs e)
        {
            bikeListForm frm = new bikeListForm();
            frm.Show();
        }

        private void button_gateOut_Bike_Click(object sender, EventArgs e)
        {
            outGateForm frm = new outGateForm();
            frm.button_removeTransport.Text += " Đạp";
            //frm.textBox_plateNumber.Visible = false;
            //frm.label_plateNumber.Visible = false;
            frm.label_pic.Text = "Hình Xe";
            frm.label_pic2.Text = "Hình \nngười gửi";
            frm.Show();
        }

        private void button_parkingMotor_Click(object sender, EventArgs e)
        {
            motorListForm frm = new motorListForm();
            frm.Show();
        }

        private void button_gateOut_Motor_Click(object sender, EventArgs e)
        {
            outGateForm frm = new outGateForm();
            frm.button_removeTransport.Text += " Máy";
            frm.label_pic.Text = "Hình Xe";
            frm.label_pic2.Text = "Hình Người Gửi";
            frm.Show();
        }

        private void button_gateOut_Car_Click(object sender, EventArgs e)
        {
            outGateForm frm = new outGateForm();
            frm.button_removeTransport.Text += " Hơi";

            frm.Show();
        }

        private void dataGridView_listSercurity_DoubleClick(object sender, EventArgs e)
        {
            informationForm frm = new informationForm();
            frm.textBox_ID.Text = dataGridView_listSercurity.CurrentRow.Cells[0].Value.ToString();
            frm.textBox_fullName.Text = dataGridView_listSercurity.CurrentRow.Cells[1].Value.ToString()+ " " +dataGridView_listSercurity.CurrentRow.Cells[2].Value.ToString();
            frm.textBox_CMND.Text = dataGridView_listSercurity.CurrentRow.Cells[3].Value.ToString();
            frm.dateTimePicker_bdate.Value = (DateTime)dataGridView_listSercurity.CurrentRow.Cells[4].Value;
            frm.textBox_phone.Text = dataGridView_listSercurity.CurrentRow.Cells[5].Value.ToString();
            frm.textBox_addr.Text = dataGridView_listSercurity.CurrentRow.Cells[6].Value.ToString();
            frm.textBox_gender.Text = "Nam";
            if (dataGridView_listSercurity.CurrentRow.Cells[7].Value.ToString() == "Female")
                frm.textBox_gender.Text = "Nữ";
            byte[] data = (byte[])dataGridView_listSercurity.CurrentRow.Cells[8].Value;
            MemoryStream stream = new MemoryStream(data);
            frm.pictureBox_avatar.Image = Image.FromStream(stream);
            frm.Show();
        }

        private void materialButton_add_Click(object sender, EventArgs e)
        {
            addSpecForm frm = new addSpecForm();
            frm.Show();
            frm.comboBox_work.SelectedIndex = 0;
        }

        private void button_price_Click(object sender, EventArgs e)
        {
            settingPriceParkForm frm = new settingPriceParkForm();
            frm.Show();
        }
    }
}
