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
using MaterialSkin.Controls;

namespace Parking_Lot_Project
{
    public partial class addManagerForm : MaterialForm
    {
        public addManagerForm()
        {
            InitializeComponent();
        }

        void loadData(string data)
        {
            textBox_id.Text = "";
            textBox_id.Text = data;
        }

        private void materialButton_select_Click(object sender, EventArgs e)
        {
            interfaceWorkerForm frm = new interfaceWorkerForm();
            frm.label_dark.Text = "s";
            frm.sendToData = new interfaceWorkerForm.sendData(loadData);
            frm.Show();
        }

        private void textBox_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox_id.Text != "")
                {
                    panel_infor.Visible = true;
                    DataTable table = Worker.Instance.getEmp(textBox_id.Text);
                    textBox_fullName.Text = table.Rows[0][1].ToString() + " " + table.Rows[0][2].ToString();
                    textBox_cmnd.Text = table.Rows[0][3].ToString();
                    textBox_bdate.Text = table.Rows[0][4].ToString();
                    textBox_phone.Text = table.Rows[0][5].ToString();
                    textBox_addr.Text = table.Rows[0][6].ToString();
                    textBox_gender.Text = table.Rows[0][7].ToString();
                    byte[] data = (byte[])table.Rows[0][8];
                    MemoryStream stream = new MemoryStream(data);
                    pictureBox_image.Image = Image.FromStream(stream);
                }
            }
        }

        private void addManagerForm_Load(object sender, EventArgs e)
        {
            comboBox_work.DataSource = Work.Instance.getAllWork();
            comboBox_work.DisplayMember = "NAME_WORK";
            comboBox_work.ValueMember = "ID";
            panel_infor.Visible = false;
        }

        private void materialButton_ok_Click(object sender, EventArgs e)
        {
            string id_user = textBox_id.Text;
            string id_work = comboBox_work.SelectedValue.ToString();

            if (Manager.Instance.insertManager(id_user, id_work) == true)
            {
                string fullName = textBox_fullName.Text;
                string userName = "Admin" +  textBox_id.Text;
                string pass = "1";
                MemoryStream pic = new MemoryStream();
                string access = "Manager";
                pictureBox_image.Image.Save(pic, pictureBox_image.Image.RawFormat);

                if (Admin.Instance.insertAdmin(fullName, userName, pass, access, pic) == true)
                {
                    MessageBox.Show("Thêm quản lý thành công\n Username: " + userName + "\nPassword: " + pass);
                }
                    
                else
                    MessageBox.Show("Tạo tài khoản không thành công");

            }
            else
            {
                MessageBox.Show("Thêm quản lý thất bại");
            }
            panel_infor.Visible = false;
        }
    }
}
