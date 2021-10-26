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
    public partial class settingWashForm : Form
    {
        public settingWashForm()
        {
            InitializeComponent();
        }
        private void format()
        {
            //dataGridView_parked.RowTemplate.Height = 80;
            dataGridView_list.Columns[0].HeaderCell.Value = "Mã Dịch Vụ";
            dataGridView_list.Columns[1].HeaderCell.Value = "Tên Dịch Vụ";
            dataGridView_list.Columns[2].HeaderCell.Value = "Giá Tiền";
            dataGridView_list.Columns[0].Width = 150;
            dataGridView_list.Columns[1].Width = 150;
            foreach (DataGridViewRow row in dataGridView_list.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
            for (int i = 0; i < dataGridView_list.Rows.Count; ++i)
            {
                if (i % 2 != 0)
                {
                    dataGridView_list.Rows[i].DefaultCellStyle.BackColor = Color.MediumSlateBlue;
                    dataGridView_list.Rows[i].DefaultCellStyle.ForeColor = Color.Gold;
                }
                else
                {
                    dataGridView_list.Rows[i].DefaultCellStyle.BackColor = Color.Gold;
                    dataGridView_list.Rows[i].DefaultCellStyle.ForeColor = Color.MediumSlateBlue;
                }
            }
            dataGridView_list.AllowUserToAddRows = false;
        }

        private void settingWashForm_Load(object sender, EventArgs e)
        {
            DataTable table = Worker.Instance.getAllSerVice(3);

            dataGridView_list.DataSource = table;
            format();
        }

        private void dataGridView_list_DoubleClick(object sender, EventArgs e)
        {
            materialTextBox_id.Text = dataGridView_list.CurrentRow.Cells[0].Value.ToString();
            materialTextBox_name.Text = dataGridView_list.CurrentRow.Cells[1].Value.ToString();
            materialTextBox_price.Text = dataGridView_list.CurrentRow.Cells[2].Value.ToString();
        }

        private void materialButton_update_Click(object sender, EventArgs e)
        {
            int id = int.Parse(materialTextBox_id.Text);
            int price = int.Parse(materialTextBox_price.Text);
            if (Price.Instance.updatePriceFix(id, price) == true)
            {
                MessageBox.Show("Cập Nhật thành công");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            settingWashForm_Load(null, null);
        }
    }
}
