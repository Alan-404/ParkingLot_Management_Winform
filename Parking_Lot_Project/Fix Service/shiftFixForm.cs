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
    public partial class shiftFixForm : Form
    {
        public shiftFixForm()
        {
            InitializeComponent();
        }

        Dictionary<string, int> date = new Dictionary<string, int>();
        private void insertDic()
        {
            date.Add("Monday", 0);
            date.Add("Tuesday", 1);
            date.Add("Wednesday", 2);
            date.Add("Thusday", 3);
            date.Add("Friday", 4);
            date.Add("Satureday", 5);
            date.Add("Sunday", 6);
        }
        private void loadShift()
        {
            DataTable table = Worker.Instance.getAllEmpWork(label1.Text);
            string[] idEmp = new string[table.Rows.Count];
            for (int i = 0; i < table.Rows.Count; ++i)
            {
                idEmp[i] = table.Rows[i][0].ToString();
            }
            int[,] temp;
            DataTable tb;
            string day = DateTime.UtcNow.ToLongDateString();
            string thu = "";
            for (int k = 0; k < day.Length; ++k)
            {
                if (day[k] == ',')
                    break;
                thu += day[k];
            }
            for (int i = 0; i < idEmp.Length; ++i)
            {
                tb = Worker.Instance.getEmpByID(idEmp[i]);
                string id = tb.Rows[0][0].ToString();
                string fname = tb.Rows[0][1].ToString();
                string lname = tb.Rows[0][2].ToString();
                string cmnd = tb.Rows[0][3].ToString();
                DateTime bdate = (DateTime)tb.Rows[0][4];
                string phone = tb.Rows[0][5].ToString();
                string addr = tb.Rows[0][6].ToString();
                string gender = tb.Rows[0][7].ToString();
                
                if (idEmp.Length == 1)
                    temp = Shift.f;
                else if (i % 3 == 0)
                    temp = Shift.a;
                else if (i % 3 == 1)
                    temp = Shift.b;
                else
                    temp = Shift.c;
                int column = date[thu];
                for (int j = 0; j < 3; ++j)
                {
                    if (temp[column, j] == 1)
                    {
                        if (j == 0)
                        {
                            dataGridView_sun.Rows.Add(id, fname, lname, cmnd, bdate, phone, addr, gender);
                        }

                        else if (j == 1)
                            dataGridView_after.Rows.Add(id, fname, lname, cmnd, bdate, phone, addr, gender);
                        else
                            dataGridView_night.Rows.Add(id, fname, lname, cmnd, bdate, phone, addr, gender);
                    }
                }
            }

        }

        private void showInfor(DataGridView dgv)
        {
            informationForm frm = new informationForm();
            frm.textBox_ID.Text = dgv.CurrentRow.Cells[0].Value.ToString();
            DataTable table = Worker.Instance.getEmpByID(frm.textBox_ID.Text);
            frm.textBox_fullName.Text = table.Rows[0][1].ToString() + " " + table.Rows[0][2].ToString();
            frm.textBox_CMND.Text = table.Rows[0][3].ToString();
            frm.dateTimePicker_bdate.Value = (DateTime)table.Rows[0][4];
            frm.textBox_phone.Text = table.Rows[0][5].ToString();
            frm.textBox_addr.Text = table.Rows[0][6].ToString();
            frm.textBox_gender.Text = table.Rows[0][7].ToString();
            byte[] data = (byte[])table.Rows[0][8];
            MemoryStream stream = new MemoryStream(data);
            frm.pictureBox_avatar.Image = Image.FromStream(stream);
            frm.Show();
        }

        private void shiftFixForm_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label1.Text = "2";
            //comboBox_Work.DataSource = Work.Instance.getAllWork();
            //comboBox_Work.DisplayMember = "NAME_WORK";
            //comboBox_Work.ValueMember = "ID";
            insertDic();
            loadShift();
        }

        private void dataGridView_sun_DoubleClick(object sender, EventArgs e)
        {
            showInfor(dataGridView_sun);
        }

        private void dataGridView_after_DoubleClick(object sender, EventArgs e)
        {
            showInfor(dataGridView_after);
        }

        private void dataGridView_night_DoubleClick(object sender, EventArgs e)
        {
            showInfor(dataGridView_night);
        }
    }
}
