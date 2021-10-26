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
    public partial class settingBossForm : MaterialForm
    {
        Admin ad = new Admin();
        private string pass;
        public settingBossForm()
        {
            InitializeComponent();
        }

        private void settingBossForm_Load(object sender, EventArgs e)
        {
            DataTable table = ad.getAdmin();
            textBox_name.Text = table.Rows[0][1].ToString();
            textBox_username.Text = table.Rows[0][2].ToString();
            byte[] data = (byte[])table.Rows[0][5];
            MemoryStream stream = new MemoryStream(data);
            pass = table.Rows[0][3].ToString();
            circularPicturebox_avatar.Image = Image.FromStream(stream);
            
            panel_changePass.Visible = false;
            panel_open.Visible = false;
        }

        private void materialButton_changePass_Click(object sender, EventArgs e)
        {
            panel_changePass.Visible = true;
            materialButton_exit.Visible = true;
        }

        private void textBox_oldPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox_oldPass.Text == pass)
                    panel_open.Visible = true;
                else
                    MessageBox.Show("Sai Mật Khẩu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void materialButton_exit_Click(object sender, EventArgs e)
        {
            textBox_oldPass.Text = "";
            textBox_newPass.Text = "";
            textBox_rePass.Text = "";
            panel_changePass.Visible = false;
            panel_open.Visible = false;
            materialButton_exit.Visible = false;
        }

        private void materialButton_ok_Click(object sender, EventArgs e)
        {
            if (textBox_newPass.Text != textBox_rePass.Text)
                MessageBox.Show("Mật Khẩu Không Khớp", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (ad.editAdmin(textBox_newPass.Text) == true)
                {
                    MessageBox.Show("Đổi Mật Khẩu Thành Công", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panel_open.Visible = false;
                    panel_changePass.Visible = false;
                    materialButton_exit.Visible = false;
                }
                else
                {
                    MessageBox.Show("Đổi Mật Khẩu Thất Bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
