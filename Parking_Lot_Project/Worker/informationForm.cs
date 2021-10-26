using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking_Lot_Project
{
    public partial class informationForm : Form
    {
        public informationForm()
        {
            InitializeComponent();
        }

        private void informationForm_Load(object sender, EventArgs e)
        {
            groupBox_account.Visible = false;
            panel_changePass.Visible = false;

        }
        private void materialButton_exit_Click(object sender, EventArgs e)
        {
            textBox_newPass.Text = "";
            textBox_oldPass.Text = "";
            textBox_rePass.Text = "";
            panel_changePass.Visible = false;
            
        }
        private void materialButton_changePass_Click(object sender, EventArgs e)
        {
            panel_changePass.Visible = true;
        }

        private void metroButton_upImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image (*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {

                pictureBox_avatar.Image = Image.FromFile((opf.FileName));

            }
        }

        private void materialButton_ok_Click(object sender, EventArgs e)
        {
            string oldPass = textBox_oldPass.Text;
            string newPass = textBox_newPass.Text;
        }
    }
}
