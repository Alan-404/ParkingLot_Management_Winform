using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.IO;

namespace Parking_Lot_Project
{
    public partial class mainForm : Form
    {
        #region Dữ liệu
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private Database db = new Database();
        #endregion

        #region Từ điển lưu thứ và tháng
        Dictionary<string, string> day = new Dictionary<string, string>();
        Dictionary<string, string> month = new Dictionary<string, string>();
        #endregion
        //Training dữ liệu
        private void insertDic()
        {
            day.Add("Monday", "Thứ hai");
            day.Add("Tuesday", "Thứ ba");
            day.Add("Wednesday", "Thứ tư");
            day.Add("Thursday", "Thứ năm");
            day.Add("Friday", "Thứ sáu");
            day.Add("Saturday", "Thứ bảy");
            day.Add("Sunday", "Chủ nhật");

            month.Add("January", "1");
            month.Add("February", "2");
            month.Add("March", "3");
            month.Add("April", "4");
            month.Add("May", "5");
            month.Add("June", "6");
            month.Add("July", "7");
            month.Add("August", "8");
            month.Add("September", "9");
            month.Add("October", "10");
            month.Add("November", "11");
            month.Add("December", "12");
        }
        public mainForm()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7,53);
            panel_menu.Controls.Add(leftBorderBtn);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private void ActivateButton (object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.Indigo;
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                iconButton_child.IconChar = currentBtn.IconChar;
                iconButton_child.IconColor = color;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Desktop.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
            label_title.Text = childForm.Text;
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.Indigo;
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void iconButton_Dashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Gold);
            OpenChildForm(new calenderForm());
            label_title.Text = "Giao diện";
            label_title.ForeColor = Color.Gold;
        }
        private void pictureBox_logo_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconButton_child.IconChar = IconChar.Home ;
            iconButton_child.IconColor = Color.DeepPink;
            label_title.Text = "Home";
            label_title.ForeColor = Color.DeepPink;
        }
        #region Thư viện window
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
         
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion
        private void panel_title_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void iconButton_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void timer_getDateAndTime_Tick(object sender, EventArgs e)
        {          
            label_time.Text = DateTime.Now.ToLongTimeString();
            string dateEng = DateTime.Now.ToLongDateString();
            int count = 0;
            string current = "";
            string date = "";
            string monthDate = "";
            for (int i=0; i<dateEng.Length; ++i)
            {
                if (dateEng[i] == ',')
                {
                    if (count == 0)
                    {
                        date += day[current] + ", ";
                        current = "";
                    }
                    if (count == 2)
                    {
                        date += "ngày " + current + " tháng " + month[monthDate] + " ";
                        current = "";
                    }
                    continue;
                }
                if (dateEng[i] == ' ')
                {
                    ++count;
                    if (count == 2)
                    {
                        monthDate = current;
                        current = "";
                    }

                    continue;
                }
                current += dateEng[i];
            }
            date += "năm " + current;
            
            label_date.Text = date;
        }
        private void mainForm_Load(object sender, EventArgs e)
        {
            insertDic();
            label_date.Text = "";
            label_time.Text = "";
            timer_getDateAndTime.Start();
            label_darkID.Visible = false;
        }
        
        private void iconButton_child_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }
        private void iconButton_infor_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Aqua);
            informationForm frm = new informationForm();
            label_title.Text = "Thông Tin Cá Nhân";
            label_title.ForeColor = Color.Aqua;
            
            DataTable table = Worker.Instance.getEmp(Admin.IdWork);
            frm.textBox_ID.Text = table.Rows[0][0].ToString();
            frm.textBox_fullName.Text = table.Rows[0][1].ToString() + " " + table.Rows[0][2].ToString();
            frm.textBox_CMND.Text = table.Rows[0][3].ToString();
            frm.textBox_phone.Text = table.Rows[0][5].ToString();
            frm.textBox_addr.Text = table.Rows[0][6].ToString();
            frm.textBox_gender.Text = table.Rows[0][7].ToString();
            byte[] data = (byte[])table.Rows[0][8];
            MemoryStream stream = new MemoryStream(data);
            frm.pictureBox_avatar.Image = Image.FromStream(stream);
            frm.dateTimePicker_bdate.Value = (DateTime)table.Rows[0][4];
            OpenChildForm(frm);         
        }

        private void iconButton_work_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.BurlyWood);
            if (Work.Instance.getWorkAdmin() == "1")
                OpenChildForm(new parkingAreaForm());
            else if (Work.Instance.getWorkAdmin() == "2")
                OpenChildForm(new interfaceFixForm());
            else if (Work.Instance.getWorkAdmin() == "2")
                OpenChildForm(new interfaceWasherForm());
        }

        private void iconButton_customer_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.LightPink);
            string id = Work.Instance.getWorkAdmin();
            if (id == "1")
                OpenChildForm(new customerListForm());
            else if (id == "2")
            {
                interfaceFixForm frm = new interfaceFixForm();
                frm.tabControl_Fix.SelectedTab = frm.tabPage_listCus;
                OpenChildForm(frm);
            }
            else if (id == "3")
            {
                interfaceWasherForm frm = new interfaceWasherForm();
                frm.tabControl_Fix.SelectedTab = frm.tabPage_cus;
                OpenChildForm(frm);
            }
        }

        private void panel_Desktop_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void iconButton_shift_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.LightSkyBlue);
            if (Work.Instance.getWorkAdmin() == "1")
            {
                shiftForm frm = new shiftForm();
                frm.dataGridView_sun.Size = new Size(1188, 150);
                frm.dataGridView_after.Size = new Size(1188, 150);
                frm.dataGridView_night.Size = new Size(1188, 150);
                OpenChildForm(frm);

            }    
                
            else if (Work.Instance.getWorkAdmin() == "2")
            {
                shiftFixForm frm = new shiftFixForm();
                frm.dataGridView_sun.Size = new Size(1188, 150);
                frm.dataGridView_after.Size = new Size(1188, 150);
                frm.dataGridView_night.Size = new Size(1188, 150);
                OpenChildForm(frm);
            }
            else if (Work.Instance.getWorkAdmin() == "3")
            {
                shiftWashForm frm = new shiftWashForm();
                frm.dataGridView_sun.Size = new Size(1188, 150);
                frm.dataGridView_after.Size = new Size(1188, 150);
                frm.dataGridView_night.Size = new Size(1188, 150);
                OpenChildForm(frm);
            }
        }

        private void iconButton_spec_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.LawnGreen);
            OpenChildForm(new addSpecForm());
        }

        private void circularPicturebox1_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }
    }
}
