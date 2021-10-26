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
using MaterialSkin.Controls;

namespace Parking_Lot_Project
{
    public partial class RegisterForm : MaterialForm
    {
        #region Camera
        FilterInfoCollection cameras; // lấy thông tin của các camera có kết nối
        VideoCaptureDevice cam; 
        #endregion
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            
            cameras = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo camera in cameras)
                comboBox_cameras.Items.Add(camera.Name);
            comboBox_cameras.SelectedIndex = 1;
        }

        private void button_openCam_Click(object sender, EventArgs e)
        {
            if (cam != null && cam.IsRunning)
            {
                cam.Stop();
            }
            else
            {
                cam = new VideoCaptureDevice(cameras[comboBox_cameras.SelectedIndex].MonikerString);
                cam.NewFrame += Cam_NewFrame;
                cam.Start();
            }
        }

        private void Cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bmp = (Bitmap)eventArgs.Frame.Clone();
            pictureBox_cam.Image = bmp;
        }

        private void button_stopCam_Click(object sender, EventArgs e)
        {            
            if (cam != null && cam.IsRunning)
                cam.Stop();
            pictureBox_cam.Image = null;
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (cam != null && cam.IsRunning)
                cam.Stop();
        }

        private void button_takePhoto_Click(object sender, EventArgs e)
        {
            cam.Stop();
            
            pictureBox_showImg.Image = pictureBox_cam.Image;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = textBox_fullName.Text + " Image";
            sfd.DefaultExt = ".jpg";
            sfd.Filter = "Image (.jpg)|*.jpg";
            sfd.InitialDirectory = @"D:\Đồ Án Winform\Parking_Lot_Project\Parking_Lot_Project\Resources\Admin_Image";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox_cam.Image.Save(sfd.FileName);
            }

            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image (*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox_showImg.Image = Image.FromFile((opf.FileName));
            }


        }
        public static byte[] convertToByte (Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }
        private void button_register_Click(object sender, EventArgs e)
        {
            

            if (pictureBox_showImg.Image == null)
            {
                MessageBox.Show("Chưa có hình chụp", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBox_pass.Text != textBox_rePass.Text)
            {
                MessageBox.Show("Mật khẩu không trùng khớp", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MemoryStream pic = new MemoryStream();
            pictureBox_showImg.Image.Save(pic, pictureBox_showImg.Image.RawFormat);
            string access;
            string[] listAccess = { "Boss", "Manager", "Sercurity", "Fixer", "Washer" };
            access = listAccess[comboBox_access.SelectedIndex];
            if (Admin.Instance.insertAdmin(textBox_fullName.Text, textBox_userName.Text, textBox_pass.Text, access, pic))
            {
                MessageBox.Show("Đăng ký tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Đăng ký thất bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button_downPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image (*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox_showImg.Image = Image.FromFile((opf.FileName));
            }
        }

        private void comboBox_access_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_access.SelectedIndex != 0)
            {

            }
        }
    }
}
