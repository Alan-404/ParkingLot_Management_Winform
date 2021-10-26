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
    public partial class settingPriceParkForm : Form
    {
        public settingPriceParkForm()
        {
            InitializeComponent();
        }

        private void materialComboBox_trans_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void settingPriceParkForm_Load(object sender, EventArgs e)
        {
            materialComboBox_trans.SelectedIndex = 0;
        }



        private void materialComboBox_trans_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataTable table;
            if (materialComboBox_trans.SelectedIndex == 0)
            {
                table = Price.Instance.getPricePark(1);
            }
            else if (materialComboBox_trans.SelectedIndex == 1)
            {
                table = Price.Instance.getPricePark(2);
            }
            else
            {
                table = Price.Instance.getPricePark(3);
            }

            materialTextBox_hour.Text = table.Rows[0][1].ToString();
            materialTextBox_day.Text = table.Rows[0][2].ToString();
            materialTextBox_month.Text = table.Rows[0][3].ToString();
            materialTextBox_year.Text = table.Rows[0][4].ToString();
        }

        private void materialButton_update_Click(object sender, EventArgs e)
        {
            int hour = int.Parse(materialTextBox_hour.Text);
            int day = int.Parse(materialTextBox_day.Text);
            int month = int.Parse(materialTextBox_month.Text);
            int year = int.Parse(materialTextBox_year.Text);
            int id = 1;
            if (materialComboBox_trans.SelectedIndex == 1)
                id = 2;
            else if (materialComboBox_trans.SelectedIndex == 2)
                id = 3;
            if (Price.Instance.updatePricePark(id,hour,day,month, year) == true)
            {
                MessageBox.Show("Cập nhật thành công");
            }
        }
    }
}
