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
    public partial class removeManagerForm : Form
    {
        public removeManagerForm()
        {
            InitializeComponent();
        }
        private void formatImage(DataGridView dgv, int numberColumn)
        {
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dgv.Columns[numberColumn];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }
        private void format()
        {
            foreach (DataGridViewRow row in dataGridView_admin.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
            dataGridView_admin.RowTemplate.Height = 80;
            dataGridView_admin.Columns[0].HeaderCell.Value = "Mã truy cập";
            dataGridView_admin.Columns[1].HeaderCell.Value = "Họ và Tên";
            dataGridView_admin.Columns[2].HeaderCell.Value = "Username";
            dataGridView_admin.Columns[3].HeaderCell.Value = "Pass";
            dataGridView_admin.Columns[4].HeaderCell.Value = "Quyền truy cập";
            dataGridView_admin.Columns[5].HeaderCell.Value = "Hình ảnh";
            formatImage(dataGridView_admin, 5);


            for (int i = 0; i < dataGridView_admin.Rows.Count; ++i)
            {
                if (i % 2 != 0)
                {
                    dataGridView_admin.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    dataGridView_admin.Rows[i].DefaultCellStyle.ForeColor = Color.Green;
                }
            }
            dataGridView_admin.AllowUserToAddRows = false;
        }
        private void removeManagerForm_Load(object sender, EventArgs e)
        {
            dataGridView_admin.DataSource = Admin.Instance.getManager();
            format();
        }

        private void dataGridView_admin_DoubleClick(object sender, EventArgs e)
        {
            textBox_id.Text = dataGridView_admin.CurrentRow.Cells[0].Value.ToString();
        }

        private void materialButton_remove_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text != "")
            {
                string id = textBox_id.Text;
                string id_emp = "";
                for (int i=5; i< dataGridView_admin.CurrentRow.Cells[2].Value.ToString().Length; ++i)
                {
                    id_emp += dataGridView_admin.CurrentRow.Cells[2].Value.ToString()[i];
                }
                if (Admin.Instance.deleteAdmin(id) == true && Manager.Instance.deleteManager(id_emp) == true)
                {
                    MessageBox.Show("Xóa quản lý thành công");
                }

            }
        }

        private void label_listAdmin_Click(object sender, EventArgs e)
        {
            removeManagerForm_Load(null, null);
        }
    }
}
