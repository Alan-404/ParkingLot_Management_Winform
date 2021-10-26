
namespace Parking_Lot_Project
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_downPic = new System.Windows.Forms.Button();
            this.comboBox_access = new System.Windows.Forms.ComboBox();
            this.label_access = new System.Windows.Forms.Label();
            this.button_register = new System.Windows.Forms.Button();
            this.textBox_rePass = new System.Windows.Forms.TextBox();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.textBox_userName = new System.Windows.Forms.TextBox();
            this.textBox_fullName = new System.Windows.Forms.TextBox();
            this.label_img = new System.Windows.Forms.Label();
            this.label_rePass = new System.Windows.Forms.Label();
            this.label_pass = new System.Windows.Forms.Label();
            this.label_userName = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_infor = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_stopCam = new System.Windows.Forms.Button();
            this.button_takePhoto = new System.Windows.Forms.Button();
            this.button_openCam = new System.Windows.Forms.Button();
            this.comboBox_cameras = new System.Windows.Forms.ComboBox();
            this.pictureBox_cam = new System.Windows.Forms.PictureBox();
            this.pictureBox_showImg = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_showImg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button_downPic);
            this.panel1.Controls.Add(this.comboBox_access);
            this.panel1.Controls.Add(this.label_access);
            this.panel1.Controls.Add(this.button_register);
            this.panel1.Controls.Add(this.pictureBox_showImg);
            this.panel1.Controls.Add(this.textBox_rePass);
            this.panel1.Controls.Add(this.textBox_pass);
            this.panel1.Controls.Add(this.textBox_userName);
            this.panel1.Controls.Add(this.textBox_fullName);
            this.panel1.Controls.Add(this.label_img);
            this.panel1.Controls.Add(this.label_rePass);
            this.panel1.Controls.Add(this.label_pass);
            this.panel1.Controls.Add(this.label_userName);
            this.panel1.Controls.Add(this.label_Name);
            this.panel1.Controls.Add(this.label_infor);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 584);
            this.panel1.TabIndex = 0;
            // 
            // button_downPic
            // 
            this.button_downPic.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_downPic.Location = new System.Drawing.Point(301, 518);
            this.button_downPic.Name = "button_downPic";
            this.button_downPic.Size = new System.Drawing.Size(363, 58);
            this.button_downPic.TabIndex = 5;
            this.button_downPic.Text = "Tải hình";
            this.button_downPic.UseVisualStyleBackColor = true;
            this.button_downPic.Click += new System.EventHandler(this.button_downPic_Click);
            // 
            // comboBox_access
            // 
            this.comboBox_access.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_access.FormattingEnabled = true;
            this.comboBox_access.Items.AddRange(new object[] {
            "Chủ",
            "Quản lý",
            "Bảo vệ",
            "Thợ sửa xe",
            "Thợ rửa xe"});
            this.comboBox_access.Location = new System.Drawing.Point(301, 61);
            this.comboBox_access.Name = "comboBox_access";
            this.comboBox_access.Size = new System.Drawing.Size(363, 33);
            this.comboBox_access.TabIndex = 15;
            this.comboBox_access.SelectedIndexChanged += new System.EventHandler(this.comboBox_access_SelectedIndexChanged);
            // 
            // label_access
            // 
            this.label_access.AutoSize = true;
            this.label_access.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_access.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_access.Location = new System.Drawing.Point(11, 61);
            this.label_access.Name = "label_access";
            this.label_access.Size = new System.Drawing.Size(206, 34);
            this.label_access.TabIndex = 14;
            this.label_access.Text = "Quyền truy cập:";
            // 
            // button_register
            // 
            this.button_register.Location = new System.Drawing.Point(301, 453);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(363, 59);
            this.button_register.TabIndex = 13;
            this.button_register.Text = "Đăng ký tài khoản";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // textBox_rePass
            // 
            this.textBox_rePass.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_rePass.Location = new System.Drawing.Point(301, 256);
            this.textBox_rePass.Name = "textBox_rePass";
            this.textBox_rePass.Size = new System.Drawing.Size(363, 34);
            this.textBox_rePass.TabIndex = 10;
            this.textBox_rePass.UseSystemPasswordChar = true;
            // 
            // textBox_pass
            // 
            this.textBox_pass.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_pass.Location = new System.Drawing.Point(301, 208);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.Size = new System.Drawing.Size(363, 34);
            this.textBox_pass.TabIndex = 9;
            this.textBox_pass.UseSystemPasswordChar = true;
            // 
            // textBox_userName
            // 
            this.textBox_userName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_userName.Location = new System.Drawing.Point(301, 162);
            this.textBox_userName.Name = "textBox_userName";
            this.textBox_userName.Size = new System.Drawing.Size(363, 34);
            this.textBox_userName.TabIndex = 8;
            // 
            // textBox_fullName
            // 
            this.textBox_fullName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_fullName.Location = new System.Drawing.Point(301, 110);
            this.textBox_fullName.Name = "textBox_fullName";
            this.textBox_fullName.Size = new System.Drawing.Size(363, 34);
            this.textBox_fullName.TabIndex = 7;
            // 
            // label_img
            // 
            this.label_img.AutoSize = true;
            this.label_img.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_img.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_img.Location = new System.Drawing.Point(41, 312);
            this.label_img.Name = "label_img";
            this.label_img.Size = new System.Drawing.Size(146, 37);
            this.label_img.TabIndex = 6;
            this.label_img.Text = "Hình ảnh:";
            // 
            // label_rePass
            // 
            this.label_rePass.AutoSize = true;
            this.label_rePass.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rePass.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_rePass.Location = new System.Drawing.Point(38, 256);
            this.label_rePass.Name = "label_rePass";
            this.label_rePass.Size = new System.Drawing.Size(149, 37);
            this.label_rePass.TabIndex = 4;
            this.label_rePass.Text = "Xác nhận:";
            // 
            // label_pass
            // 
            this.label_pass.AutoSize = true;
            this.label_pass.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pass.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_pass.Location = new System.Drawing.Point(38, 208);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(143, 37);
            this.label_pass.TabIndex = 3;
            this.label_pass.Text = "Mật khẩu";
            // 
            // label_userName
            // 
            this.label_userName.AutoSize = true;
            this.label_userName.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_userName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_userName.Location = new System.Drawing.Point(38, 157);
            this.label_userName.Name = "label_userName";
            this.label_userName.Size = new System.Drawing.Size(159, 37);
            this.label_userName.TabIndex = 2;
            this.label_userName.Text = "Tài khoản:";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_Name.Location = new System.Drawing.Point(38, 109);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(163, 37);
            this.label_Name.TabIndex = 1;
            this.label_Name.Text = "Họ và Tên:";
            // 
            // label_infor
            // 
            this.label_infor.AutoSize = true;
            this.label_infor.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_infor.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_infor.Location = new System.Drawing.Point(-1, 0);
            this.label_infor.Name = "label_infor";
            this.label_infor.Size = new System.Drawing.Size(184, 45);
            this.label_infor.TabIndex = 0;
            this.label_infor.Text = "Thông tin";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button_stopCam);
            this.panel2.Controls.Add(this.button_takePhoto);
            this.panel2.Controls.Add(this.button_openCam);
            this.panel2.Controls.Add(this.comboBox_cameras);
            this.panel2.Controls.Add(this.pictureBox_cam);
            this.panel2.Location = new System.Drawing.Point(710, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(799, 584);
            this.panel2.TabIndex = 1;
            // 
            // button_stopCam
            // 
            this.button_stopCam.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_stopCam.Location = new System.Drawing.Point(615, 512);
            this.button_stopCam.Name = "button_stopCam";
            this.button_stopCam.Size = new System.Drawing.Size(170, 52);
            this.button_stopCam.TabIndex = 4;
            this.button_stopCam.Text = "Tắt Camera";
            this.button_stopCam.UseVisualStyleBackColor = true;
            this.button_stopCam.Click += new System.EventHandler(this.button_stopCam_Click);
            // 
            // button_takePhoto
            // 
            this.button_takePhoto.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_takePhoto.Location = new System.Drawing.Point(307, 512);
            this.button_takePhoto.Name = "button_takePhoto";
            this.button_takePhoto.Size = new System.Drawing.Size(188, 53);
            this.button_takePhoto.TabIndex = 3;
            this.button_takePhoto.Text = "Chụp hình";
            this.button_takePhoto.UseVisualStyleBackColor = true;
            this.button_takePhoto.Click += new System.EventHandler(this.button_takePhoto_Click);
            // 
            // button_openCam
            // 
            this.button_openCam.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_openCam.Location = new System.Drawing.Point(3, 512);
            this.button_openCam.Name = "button_openCam";
            this.button_openCam.Size = new System.Drawing.Size(183, 58);
            this.button_openCam.TabIndex = 2;
            this.button_openCam.Text = "Mở Camera";
            this.button_openCam.UseVisualStyleBackColor = true;
            this.button_openCam.Click += new System.EventHandler(this.button_openCam_Click);
            // 
            // comboBox_cameras
            // 
            this.comboBox_cameras.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_cameras.FormattingEnabled = true;
            this.comboBox_cameras.Location = new System.Drawing.Point(3, 456);
            this.comboBox_cameras.Name = "comboBox_cameras";
            this.comboBox_cameras.Size = new System.Drawing.Size(183, 30);
            this.comboBox_cameras.TabIndex = 1;
            // 
            // pictureBox_cam
            // 
            this.pictureBox_cam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_cam.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_cam.Name = "pictureBox_cam";
            this.pictureBox_cam.Size = new System.Drawing.Size(782, 447);
            this.pictureBox_cam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_cam.TabIndex = 0;
            this.pictureBox_cam.TabStop = false;
            // 
            // pictureBox_showImg
            // 
            this.pictureBox_showImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_showImg.Location = new System.Drawing.Point(301, 312);
            this.pictureBox_showImg.Name = "pictureBox_showImg";
            this.pictureBox_showImg.Size = new System.Drawing.Size(363, 135);
            this.pictureBox_showImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_showImg.TabIndex = 12;
            this.pictureBox_showImg.TabStop = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1528, 688);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Name = "RegisterForm";
            this.Text = "Đăng Ký Tài Khoản";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_showImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_img;
        private System.Windows.Forms.Label label_rePass;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.Label label_userName;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_infor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.PictureBox pictureBox_showImg;
        private System.Windows.Forms.TextBox textBox_rePass;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.TextBox textBox_userName;
        private System.Windows.Forms.TextBox textBox_fullName;
        private System.Windows.Forms.ComboBox comboBox_cameras;
        private System.Windows.Forms.PictureBox pictureBox_cam;
        private System.Windows.Forms.Button button_stopCam;
        private System.Windows.Forms.Button button_takePhoto;
        private System.Windows.Forms.Button button_openCam;
        private System.Windows.Forms.ComboBox comboBox_access;
        private System.Windows.Forms.Label label_access;
        private System.Windows.Forms.Button button_downPic;
    }
}