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
    public partial class interfaceWasherForm : Form
    {
        public interfaceWasherForm()
        {
            InitializeComponent();
        }
        private void formatEmp()
        {

            dataGridView_listFixer.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView_listFixer.Columns[0].HeaderCell.Value = "Mã Nhân Viên";
            dataGridView_listFixer.Columns[1].HeaderCell.Value = "Họ";
            dataGridView_listFixer.Columns[2].HeaderCell.Value = "Tên";
            dataGridView_listFixer.Columns[3].HeaderCell.Value = "CMND";
            dataGridView_listFixer.Columns[4].HeaderCell.Value = "Ngày Sinh";
            dataGridView_listFixer.Columns[5].HeaderCell.Value = "Số Điện Thoại";
            dataGridView_listFixer.Columns[6].HeaderCell.Value = "Địa chỉ";
            dataGridView_listFixer.Columns[7].HeaderCell.Value = "Giới tính";
            dataGridView_listFixer.Columns[8].HeaderCell.Value = "Hình ảnh";

            dataGridView_listFixer.Columns[0].Width = 80;
            dataGridView_listFixer.Columns[1].Width = 100;
            dataGridView_listFixer.Columns[2].Width = 100;
            dataGridView_listFixer.Columns[3].Width = 150;
            dataGridView_listFixer.Columns[4].Width = 150;
            dataGridView_listFixer.Columns[6].Width = 150;
            dataGridView_listFixer.Columns[7].Width = 100;
            dataGridView_listFixer.Columns[5].Width = 130;
            foreach (DataGridViewRow row in dataGridView_listFixer.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
            dataGridView_listFixer.RowTemplate.Height = 50;
            DataGridViewImageColumn picCol = (DataGridViewImageColumn)dataGridView_listFixer.Columns[8];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;


            dataGridView_listFixer.AllowUserToAddRows = false;
        }
        private void formatImage(DataGridView dgv, int numberColumn)
        {
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dgv.Columns[numberColumn];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }
        private void formatService ()
        {
            dataGridView_service.Columns[0].HeaderCell.Value = "Mã dịch vụ";
            dataGridView_service.Columns[1].HeaderCell.Value = "Hình khách hàng";
            dataGridView_service.Columns[2].HeaderCell.Value = "Hình xe";
            dataGridView_service.Columns[3].HeaderCell.Value = "Tên dịch vụ";
            dataGridView_service.Columns[4].HeaderCell.Value = "Giá tiền";
            formatImage(dataGridView_service, 1);
            formatImage(dataGridView_service, 2);
            dataGridView_service.RowTemplate.Height = 80;
            foreach (DataGridViewRow row in dataGridView_service.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
            for (int i = 0; i < dataGridView_service.Rows.Count; ++i)
            {
                if (i % 2 != 0)
                {
                    dataGridView_service.Rows[i].DefaultCellStyle.BackColor = Color.MediumSlateBlue;
                    dataGridView_service.Rows[i].DefaultCellStyle.ForeColor = Color.Gold;
                }
                else
                {
                    dataGridView_service.Rows[i].DefaultCellStyle.BackColor = Color.Gold;
                    dataGridView_service.Rows[i].DefaultCellStyle.ForeColor = Color.MediumSlateBlue;
                }
            }
            dataGridView_service.AllowUserToAddRows = false;
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

        private void interfaceWasherForm_Load(object sender, EventArgs e)
        {
            dataGridView_listFixer.DataSource = Worker.Instance.getAllEmpWork("3");
            formatEmp();
            //this.Size = new Size(892, 627);
            dataGridView_service.DataSource = Customer.Instance.getCustomerService("3");
            formatService();
            DataTable table = Worker.Instance.getAllSerVice(3);

            dataGridView_list.DataSource = table;
            format();
            listBox_fix.DataSource = table;
            listBox_fix.DisplayMember = "NAME_SPEC";
            listBox_fix.ValueMember = "ID";
        }
        private void uploadImage(PictureBox box)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image (*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {

                box.Image = Image.FromFile((opf.FileName));

            }
        }
        private void materialButton_up_Click(object sender, EventArgs e)
        {
            uploadImage(pictureBox_cus);
        }

        private void materialButton_upTrans_Click(object sender, EventArgs e)
        {
            uploadImage(pictureBox_trans);
        }

        private void listBox_fix_Click(object sender, EventArgs e)
        {
            listBox_use.Items.Add(listBox_fix.SelectedItem);
            listBox_use.DisplayMember = "NAME_SPEC";
            listBox_use.ValueMember = "ID";
        }

        private void listBox_use_Click(object sender, EventArgs e)
        {
            listBox_use.Items.Remove(listBox_use.SelectedItem);
        }

        private void materialButton_cal_Click(object sender, EventArgs e)
        {
            int numberOfCourse = listBox_use.Items.Count;
            int price = 0;
            for (int i = 0; i < numberOfCourse; ++i)
            {

                listBox_use.SetSelected(i, true);
                string idCourse = "";
                foreach (var item in listBox_use.SelectedItems)
                {
                    idCourse = ((DataRowView)item)["id"].ToString();
                }


                price += Worker.Instance.getPrice(idCourse);
            }
            label_price.Text = "Giá: " + price.ToString();
        }

        private void materialButton_add_Click(object sender, EventArgs e)
        {
            MemoryStream user = new MemoryStream();
            pictureBox_cus.Image.Save(user, pictureBox_cus.Image.RawFormat);
            MemoryStream trans = new MemoryStream();
            pictureBox_trans.Image.Save(trans, pictureBox_trans.Image.RawFormat);
            int numberOfCourse = listBox_use.Items.Count;
            for (int i = 0; i < numberOfCourse; ++i)
            {
                string idC = Worker.Instance.makeIDService();
                listBox_use.SetSelected(i, true);
                //listBox_use.SelectedIndex = i;
                string idCourse = "";
                foreach (var item in listBox_use.SelectedItems)
                {
                    idCourse = ((DataRowView)item)["id"].ToString();
                }


                string[] temp = Worker.Instance.getNameAndPrice(idCourse);

                if (Worker.Instance.insertService(idC, user, trans, temp[0], int.Parse(temp[1])) == true)
                {
                    pictureBox_cus.Image = null;
                    pictureBox_trans.Image = null;
                    label_price.Text = "Giá";
                }
                else
                {
                    MessageBox.Show("Có lỗi");
                }
            }
        }

        private void convertImg(PictureBox pc, int column)
        {
            byte[] data = (byte[])dataGridView_service.CurrentRow.Cells[column].Value;
            MemoryStream stream = new MemoryStream(data);
            pc.Image = Image.FromStream(stream);
        }
        private void dataGridView_service_DoubleClick(object sender, EventArgs e)
        {
            materialTextBox_id.Text = dataGridView_service.CurrentRow.Cells[0].Value.ToString();
            materialTextBox_name.Text = dataGridView_service.CurrentRow.Cells[3].Value.ToString();
            materialTextBox_price.Text = dataGridView_service.CurrentRow.Cells[4].Value.ToString();
            convertImg(pictureBox_user, 1);
            convertImg(pictureBox_transSer, 2);
        }

        private void materialButton_use_Click(object sender, EventArgs e)
        {
            tabControl_Fix.SelectedTab = tabPage_listService;
        }
    }
}
