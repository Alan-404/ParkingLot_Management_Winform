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
    public partial class customerListForm : Form
    {
        public delegate void sendData(string id);
        public sendData sendTheData;
        public customerListForm()
        {
            InitializeComponent();
        }

        private void format()
        {
            dataGridView_cus.Columns[0].HeaderCell.Value = "Mã Khách Hàng";
            dataGridView_cus.Columns[1].HeaderCell.Value = "Họ";
            dataGridView_cus.Columns[2].HeaderCell.Value = "Tên";
            dataGridView_cus.Columns[3].HeaderCell.Value = "Sinh Nhật";
            dataGridView_cus.Columns[4].HeaderCell.Value = "Số Điện Thoại";
            dataGridView_cus.Columns[5].HeaderCell.Value = "Giới Tính";
            dataGridView_cus.Columns[6].HeaderCell.Value = "Quốc Tịch";
            dataGridView_cus.Columns[7].HeaderCell.Value = "Địa Chỉ";
            dataGridView_cus.Columns[8].HeaderCell.Value = "GMAIL";
            dataGridView_cus.Columns[9].HeaderCell.Value = "Hình Khách Hàng";
            ChangeImage.Instance.formatImage(dataGridView_cus, 9);
            dataGridView_cus.Columns[0].Width = 120;
            dataGridView_cus.Columns[2].Width = 50;
            //dataGridView_cus.Columns[0].Width = 80;
            //dataGridView_cus.Columns[1].Width = 150;
            //dataGridView_cus.Columns[3].Width = 150;
            //dataGridView_motor.Columns[4].Width = 250;
            //dataGridView_motor.Columns[5].Width = 250;
            //dataGridView_motor.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm:ss";
            //dataGridView_motor.RowTemplate.Height = 80;
            dataGridView_cus.RowTemplate.Height = 50;
            foreach (DataGridViewRow row in dataGridView_cus.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
            //for (int i = 0; i < dataGridView_cus.Rows.Count; ++i)
            //{
            //    if (i % 2 != 0)
            //    {
            //        dataGridView_cus.Rows[i].DefaultCellStyle.BackColor = Color.Green;
            //        dataGridView_cus.Rows[i].DefaultCellStyle.ForeColor = Color.White;
            //    }
            //}
            dataGridView_cus.AllowUserToAddRows = false;
        }

        private void customerListForm_Load(object sender, EventArgs e)
        {
            label_dark.Visible = false;
            dataGridView_cus.DataSource = Customer.Instance.getAllCustomer();
            format();
        }

        private void dataGridView_cus_DoubleClick(object sender, EventArgs e)
        {
            if (label_dark.Text == "d")
            {
                if (sendTheData != null)
                {
                    sendTheData(dataGridView_cus.CurrentRow.Cells[0].Value.ToString());
                    this.Close();
                    return;
                }
            }
            textBox_id.Text = dataGridView_cus.CurrentRow.Cells[0].Value.ToString();
            textBox_fname.Text = dataGridView_cus.CurrentRow.Cells[1].Value.ToString();
            textBox_lname.Text = dataGridView_cus.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker_bdate.Value = (DateTime)dataGridView_cus.CurrentRow.Cells[3].Value;
            textBox_phone.Text = dataGridView_cus.CurrentRow.Cells[4].Value.ToString();
            comboBox_gender.Text = "Nam";
            if (dataGridView_cus.CurrentRow.Cells[5].Value.ToString() == "Female")
                comboBox_gender.Text = "Nữ";
            textBox_country.Text = dataGridView_cus.CurrentRow.Cells[6].Value.ToString();
            textBox_addr.Text = dataGridView_cus.CurrentRow.Cells[7].Value.ToString();
            textBox_mail.Text = dataGridView_cus.CurrentRow.Cells[8].Value.ToString();
            byte[] data = (byte[])dataGridView_cus.CurrentRow.Cells[9].Value;
            MemoryStream stream = new MemoryStream(data);
            pictureBox_img.Image = Image.FromStream(stream);
        }

        private void materialButton_add_Click(object sender, EventArgs e)
        {
            addCustomerForm frm = new addCustomerForm();
            frm.Show();
        }

        private void label_cus_Click(object sender, EventArgs e)
        {
            customerListForm_Load(null, null);
        }

        private void materialButton_edit_Click(object sender, EventArgs e)
        {
            string id = textBox_id.Text;
            string fname = textBox_fname.Text;
            string lname = textBox_lname.Text;
            DateTime bdate = dateTimePicker_bdate.Value;
            string phone = textBox_phone.Text;
            string gender = "Male";
            if (comboBox_gender.Text == "Nữ")
                gender = "Female";
            string country = textBox_country.Text;
            string addr = textBox_addr.Text;
            string mail = textBox_mail.Text;
            MemoryStream pic = new MemoryStream();
            pictureBox_img.Image.Save(pic, pictureBox_img.Image.RawFormat);
            if (Customer.Instance.editCustomer(id,fname, lname, bdate, phone, gender, country, addr, mail, pic) == true)
            {
                MessageBox.Show("Sửa Thông Tin Khách Hàng Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
               
        }

        private void materialButton_remove_Click(object sender, EventArgs e)
        {
            string id = textBox_id.Text;
            if (Customer.Instance.removeCustomer(id) == true)
            {
                MessageBox.Show("Xóa Thông Tin Khách Hàng Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }
    }
}
