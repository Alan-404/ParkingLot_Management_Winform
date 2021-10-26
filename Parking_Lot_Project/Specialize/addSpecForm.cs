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
    public partial class addSpecForm : Form
    {
        public addSpecForm()
        {
            InitializeComponent();
        }

        private void addSpecForm_Load(object sender, EventArgs e)
        {
            panel_infor.Visible = false;
            comboBox_work.DataSource = Work.Instance.getAllWork();
            comboBox_work.DisplayMember = "NAME_WORK";
            comboBox_work.ValueMember = "ID";
        }

        private void loadData(string id)
        {
            textBox_id.Text = "";
            textBox_id.Text = id;
        }

        private void button_select_Click(object sender, EventArgs e)
        {
            interfaceWorkerForm frm = new interfaceWorkerForm();
            frm.label_dark.Text = "l";
            frm.sendToData = new interfaceWorkerForm.sendData(loadData);
            frm.Show();
        }

        private void comboBox_work_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_spec.DataSource = Specialize.Instance.getSpecByWord(comboBox_work.SelectedValue.ToString());
            comboBox_spec.DisplayMember = "NAME_SPEC";
            comboBox_spec.ValueMember = "ID";
        }

        private void textBox_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(textBox_id.Text != "")
                {
                    DataTable table = Worker.Instance.getEmp(textBox_id.Text);
                    if (table.Rows.Count == 1)
                    {
                        panel_infor.Visible = true;
                        textBox_fName.Text = table.Rows[0][1].ToString();
                        textBox_Lname.Text = table.Rows[0][2].ToString();
                        textBox_CMND.Text = table.Rows[0][3].ToString();
                        dateTimePicker_Bdate.Value = (DateTime)table.Rows[0][4];
                        textBox_phone.Text = table.Rows[0][5].ToString();
                        richTextBox_addr.Text = table.Rows[0][6].ToString();
                        radioButton_female.Checked = true;
                        if (table.Rows[0][7].ToString() == "Male")
                            radioButton_male.Checked = true;
                        byte[] data = (byte[])table.Rows[0][8];
                        MemoryStream stream = new MemoryStream(data);
                        pictureBox_image.Image = Image.FromStream(stream);
                    }
                }
            }
        }

        private void button_addSpec_Click(object sender, EventArgs e)
        {
            string id = textBox_id.Text;
            string id_spec = comboBox_spec.SelectedValue.ToString();
            if (Specialize.Instance.insertWorking(id, id_spec) == true)
            {
                MessageBox.Show("OK");
                addSpecForm_Load(null, null);
            }
            else
            {
                MessageBox.Show("Vui lòng thử lại");
            }
        }
    }
}
