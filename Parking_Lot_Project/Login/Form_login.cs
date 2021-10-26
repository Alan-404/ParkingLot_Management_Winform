using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Parking_Lot_Project
{
    public partial class Form_login : Form
    {
        //Database db = new Database();
        public Form_login()
        {
            InitializeComponent();
        }
        private string getLName (string fullName)
        {
            //string fName = "";
            string lName = "";
            //string fullName = textBox_tabPageManage_fullName.Text;
            int count = fullName.Length - 1;

            while (count >= 0)
            {
                if (fullName[count] == ' ')
                    break;
                --count;
            }
            for (int i = count + 1; i < fullName.Length; ++i)
                lName += fullName[i];
            return lName;
        }

        
        private void button_login_Click(object sender, EventArgs e)
        {
            string userName = materialTextBox_userName.Text;
            string pass = materialTextBox_pass.Text;
            if (userName == "" && pass == "")
            {
                MessageBox.Show("Chưa nhập tài khoản và mật khẩu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                
            if (userName == "")
            {
                MessageBox.Show("Chưa nhập tài khoản", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                
            if (pass == "")
            {
                MessageBox.Show("Chưa nhập password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            DataTable table = Admin.Instance.login(userName, pass);
            if (table.Rows.Count == 1)
            {
                if (table.Rows[0][0].ToString() == "4")
                {
                    parkingAreaForm frm = new parkingAreaForm();
                    frm.button_parkingMotor.Visible = false;
                    frm.button_parkingBicycle.Visible = false;
                    frm.button_parkingCar.Visible = false;
                    frm.tabControl_manageParkingLot.Controls.RemoveAt(1);
                    frm.Show();
                    return;

                }
                
                string id = table.Rows[0][0].ToString();
                string access = table.Rows[0][4].ToString();
                Admin.getuserID(id, access);

                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                materialTextBox_userName.Text = "";
                materialTextBox_pass.Text = "";
                if (access == "Boss")
                {
                    bossForm frm = new bossForm();
                    if (table.Rows[0][5].ToString() != "Null")
                    {
                        byte[] data = (byte[])table.Rows[0][5];
                        MemoryStream stream = new MemoryStream(data);
                        frm.circularPicturebox_avatar.Image = Image.FromStream(stream);
                    }                  
                    frm.label_hello.Text += table.Rows[0][1].ToString();
                    frm.Show();
                    
                    //main.Show();
                }
                else
                {
                    string work = "";
                    for (int i=5; i< table.Rows[0][2].ToString().Length; ++i)
                    {
                        work += table.Rows[0][2].ToString()[i];
                    }
                    Admin.getIdWork(work);
                    mainForm frm = new mainForm();
                    byte[] data = (byte[])table.Rows[0][5];
                    MemoryStream stream = new MemoryStream(data);
                    frm.circularPicturebox_avatar.Image = Image.FromStream(stream);
                    frm.Show();
                }
            }
            
            else
            {
                MessageBox.Show("Không tìm thấy tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                materialTextBox_userName.Text = "";
                materialTextBox_pass.Text = "";
            }
                
        }

        private void linkLabel_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm frm = new RegisterForm();
            frm.Show();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            materialTextBox_userName.Text = "";
            materialTextBox_pass.Text = "";
            this.Close();
        }
        #region Thư viện window
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        private void panel_move_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
