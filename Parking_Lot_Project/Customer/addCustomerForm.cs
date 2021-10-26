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
using AForge.Video;
using AForge.Video.DirectShow;

namespace Parking_Lot_Project
{
    public partial class addCustomerForm : Form
    {
        FilterInfoCollection cameras; // lấy thông tin của các camera có kết nối
        VideoCaptureDevice cam;
        public addCustomerForm()
        {
            InitializeComponent();
        }

        private void materialButton_up_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image (*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {

                pictureBox_img.Image = Image.FromFile((opf.FileName));

            }
        }

        private void materialButton_add_Click(object sender, EventArgs e)
        {
            string id = textBox_id.Text;
            string fname = textBox_fname.Text;
            string lname = textBox_lname.Text;
            DateTime bdate = dateTimePicker_bdate.Value;
            string phone = textBox_phone.Text;
            string gender = "Male";
            string country = textBox_country.Text;
            if (Female.Checked == true)
                gender = "Female";
            string addr = textBox_addr.Text;
            string mail = textBox_mail.Text;
            MemoryStream stream = new MemoryStream();
            pictureBox_img.Image.Save(stream, pictureBox_img.Image.RawFormat);
            if (Customer.Instance.addCustomer(id, fname,lname,bdate, phone, gender,country, addr, mail, stream) == true)
            {
                MessageBox.Show("Thêm khách hàng thành công");
            }
            else
            {
                MessageBox.Show("Vui lòng thử lại");
            }
                
        }

        private void addCustomerForm_Load(object sender, EventArgs e)
        {
            textBox_id.Text = Customer.Instance.makeID();
            
            cameras = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo camera in cameras)
                comboBox_cam.Items.Add(camera.Name);
            comboBox_cam.SelectedIndex = 1;
        }

        private void materialButton_open_Click(object sender, EventArgs e)
        {
            if (cam != null && cam.IsRunning)
            {
                cam.Stop();
            }
            else
            {
                cam = new VideoCaptureDevice(cameras[comboBox_cam.SelectedIndex].MonikerString);
                cam.NewFrame += Cam_NewFrame; ;
                cam.Start();
            }
        }

        private void Cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bmp = (Bitmap)eventArgs.Frame.Clone();
            pictureBox_img.Image = bmp;
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (cam != null && cam.IsRunning)
                cam.Stop();
        }

        private void materialButton_take_Click(object sender, EventArgs e)
        {
            cam.Stop();

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = textBox_fname.Text + " Image";
            sfd.DefaultExt = ".jpg";
            sfd.Filter = "Image (.jpg)|*.jpg";
            sfd.InitialDirectory = @"D:\Đồ Án Winform\Parking_Lot_Project\Parking_Lot_Project\Resources\Admin_Image";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox_img.Image.Save(sfd.FileName);
            }

            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image (*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox_img.Image = Image.FromFile((opf.FileName));
            }
        }

        private void materialButton_stop_Click(object sender, EventArgs e)
        {
            if (cam != null && cam.IsRunning)
                cam.Stop();
            pictureBox_img.Image = null;
        }
    }
}
