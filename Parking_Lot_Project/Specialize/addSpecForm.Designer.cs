
namespace Parking_Lot_Project
{
    partial class addSpecForm
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
            this.panel_infor = new System.Windows.Forms.Panel();
            this.button_addSpec = new System.Windows.Forms.Button();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.label_phone = new System.Windows.Forms.Label();
            this.textBox_Lname = new System.Windows.Forms.TextBox();
            this.label_LName = new System.Windows.Forms.Label();
            this.button_downImage = new System.Windows.Forms.Button();
            this.comboBox_cameras = new System.Windows.Forms.ComboBox();
            this.button_stopCam = new System.Windows.Forms.Button();
            this.button_takePhoto = new System.Windows.Forms.Button();
            this.button_openCam = new System.Windows.Forms.Button();
            this.textBox_CMND = new System.Windows.Forms.TextBox();
            this.label_CMND = new System.Windows.Forms.Label();
            this.richTextBox_addr = new System.Windows.Forms.RichTextBox();
            this.radioButton_female = new System.Windows.Forms.RadioButton();
            this.radioButton_male = new System.Windows.Forms.RadioButton();
            this.label_Gender = new System.Windows.Forms.Label();
            this.label_Addr = new System.Windows.Forms.Label();
            this.dateTimePicker_Bdate = new System.Windows.Forms.DateTimePicker();
            this.textBox_fName = new System.Windows.Forms.TextBox();
            this.label_showImage = new System.Windows.Forms.Label();
            this.label_Bdate = new System.Windows.Forms.Label();
            this.label_FName = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.button_select = new System.Windows.Forms.Button();
            this.comboBox_work = new System.Windows.Forms.ComboBox();
            this.comboBox_spec = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox_image = new System.Windows.Forms.PictureBox();
            this.panel_infor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_infor
            // 
            this.panel_infor.Controls.Add(this.button_addSpec);
            this.panel_infor.Controls.Add(this.textBox_phone);
            this.panel_infor.Controls.Add(this.label_phone);
            this.panel_infor.Controls.Add(this.textBox_Lname);
            this.panel_infor.Controls.Add(this.label_LName);
            this.panel_infor.Controls.Add(this.button_downImage);
            this.panel_infor.Controls.Add(this.comboBox_cameras);
            this.panel_infor.Controls.Add(this.button_stopCam);
            this.panel_infor.Controls.Add(this.button_takePhoto);
            this.panel_infor.Controls.Add(this.button_openCam);
            this.panel_infor.Controls.Add(this.textBox_CMND);
            this.panel_infor.Controls.Add(this.label_CMND);
            this.panel_infor.Controls.Add(this.richTextBox_addr);
            this.panel_infor.Controls.Add(this.radioButton_female);
            this.panel_infor.Controls.Add(this.radioButton_male);
            this.panel_infor.Controls.Add(this.label_Gender);
            this.panel_infor.Controls.Add(this.label_Addr);
            this.panel_infor.Controls.Add(this.dateTimePicker_Bdate);
            this.panel_infor.Controls.Add(this.textBox_fName);
            this.panel_infor.Controls.Add(this.label_showImage);
            this.panel_infor.Controls.Add(this.label_Bdate);
            this.panel_infor.Controls.Add(this.label_FName);
            this.panel_infor.Controls.Add(this.pictureBox_image);
            this.panel_infor.Location = new System.Drawing.Point(12, 149);
            this.panel_infor.Name = "panel_infor";
            this.panel_infor.Size = new System.Drawing.Size(1095, 573);
            this.panel_infor.TabIndex = 0;
            // 
            // button_addSpec
            // 
            this.button_addSpec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_addSpec.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addSpec.ForeColor = System.Drawing.Color.White;
            this.button_addSpec.Location = new System.Drawing.Point(236, 496);
            this.button_addSpec.Name = "button_addSpec";
            this.button_addSpec.Size = new System.Drawing.Size(355, 55);
            this.button_addSpec.TabIndex = 96;
            this.button_addSpec.Text = "Thêm Chuyên Môn";
            this.button_addSpec.UseVisualStyleBackColor = false;
            this.button_addSpec.Click += new System.EventHandler(this.button_addSpec_Click);
            // 
            // textBox_phone
            // 
            this.textBox_phone.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_phone.ForeColor = System.Drawing.Color.Black;
            this.textBox_phone.Location = new System.Drawing.Point(267, 243);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(310, 42);
            this.textBox_phone.TabIndex = 95;
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_phone.ForeColor = System.Drawing.Color.Black;
            this.label_phone.Location = new System.Drawing.Point(60, 242);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(148, 37);
            this.label_phone.TabIndex = 94;
            this.label_phone.Text = "Điện Thoại";
            // 
            // textBox_Lname
            // 
            this.textBox_Lname.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Lname.ForeColor = System.Drawing.Color.Black;
            this.textBox_Lname.Location = new System.Drawing.Point(267, 81);
            this.textBox_Lname.Name = "textBox_Lname";
            this.textBox_Lname.Size = new System.Drawing.Size(310, 42);
            this.textBox_Lname.TabIndex = 93;
            // 
            // label_LName
            // 
            this.label_LName.AutoSize = true;
            this.label_LName.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LName.ForeColor = System.Drawing.Color.Black;
            this.label_LName.Location = new System.Drawing.Point(93, 81);
            this.label_LName.Name = "label_LName";
            this.label_LName.Size = new System.Drawing.Size(68, 37);
            this.label_LName.TabIndex = 92;
            this.label_LName.Text = "Tên:";
            // 
            // button_downImage
            // 
            this.button_downImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_downImage.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_downImage.ForeColor = System.Drawing.Color.White;
            this.button_downImage.Location = new System.Drawing.Point(610, 299);
            this.button_downImage.Name = "button_downImage";
            this.button_downImage.Size = new System.Drawing.Size(265, 55);
            this.button_downImage.TabIndex = 91;
            this.button_downImage.Text = "Tải hình";
            this.button_downImage.UseVisualStyleBackColor = false;
            // 
            // comboBox_cameras
            // 
            this.comboBox_cameras.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_cameras.FormattingEnabled = true;
            this.comboBox_cameras.Location = new System.Drawing.Point(913, 71);
            this.comboBox_cameras.Name = "comboBox_cameras";
            this.comboBox_cameras.Size = new System.Drawing.Size(169, 34);
            this.comboBox_cameras.TabIndex = 90;
            // 
            // button_stopCam
            // 
            this.button_stopCam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_stopCam.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_stopCam.ForeColor = System.Drawing.Color.White;
            this.button_stopCam.Location = new System.Drawing.Point(913, 229);
            this.button_stopCam.Name = "button_stopCam";
            this.button_stopCam.Size = new System.Drawing.Size(169, 51);
            this.button_stopCam.TabIndex = 89;
            this.button_stopCam.Text = "Tắt Camera";
            this.button_stopCam.UseVisualStyleBackColor = false;
            // 
            // button_takePhoto
            // 
            this.button_takePhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_takePhoto.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_takePhoto.ForeColor = System.Drawing.Color.White;
            this.button_takePhoto.Location = new System.Drawing.Point(913, 172);
            this.button_takePhoto.Name = "button_takePhoto";
            this.button_takePhoto.Size = new System.Drawing.Size(169, 51);
            this.button_takePhoto.TabIndex = 88;
            this.button_takePhoto.Text = "Chụp";
            this.button_takePhoto.UseVisualStyleBackColor = false;
            // 
            // button_openCam
            // 
            this.button_openCam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_openCam.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_openCam.ForeColor = System.Drawing.Color.White;
            this.button_openCam.Location = new System.Drawing.Point(913, 115);
            this.button_openCam.Name = "button_openCam";
            this.button_openCam.Size = new System.Drawing.Size(169, 51);
            this.button_openCam.TabIndex = 87;
            this.button_openCam.Text = "Mở Camera";
            this.button_openCam.UseVisualStyleBackColor = false;
            // 
            // textBox_CMND
            // 
            this.textBox_CMND.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CMND.ForeColor = System.Drawing.Color.Black;
            this.textBox_CMND.Location = new System.Drawing.Point(267, 133);
            this.textBox_CMND.Name = "textBox_CMND";
            this.textBox_CMND.Size = new System.Drawing.Size(310, 42);
            this.textBox_CMND.TabIndex = 86;
            // 
            // label_CMND
            // 
            this.label_CMND.AutoSize = true;
            this.label_CMND.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CMND.ForeColor = System.Drawing.Color.Black;
            this.label_CMND.Location = new System.Drawing.Point(60, 132);
            this.label_CMND.Name = "label_CMND";
            this.label_CMND.Size = new System.Drawing.Size(95, 37);
            this.label_CMND.TabIndex = 85;
            this.label_CMND.Text = "CMND:";
            // 
            // richTextBox_addr
            // 
            this.richTextBox_addr.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_addr.ForeColor = System.Drawing.Color.Black;
            this.richTextBox_addr.Location = new System.Drawing.Point(267, 306);
            this.richTextBox_addr.Name = "richTextBox_addr";
            this.richTextBox_addr.Size = new System.Drawing.Size(310, 101);
            this.richTextBox_addr.TabIndex = 84;
            this.richTextBox_addr.Text = "";
            // 
            // radioButton_female
            // 
            this.radioButton_female.AutoSize = true;
            this.radioButton_female.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_female.ForeColor = System.Drawing.Color.Black;
            this.radioButton_female.Location = new System.Drawing.Point(425, 449);
            this.radioButton_female.Name = "radioButton_female";
            this.radioButton_female.Size = new System.Drawing.Size(71, 41);
            this.radioButton_female.TabIndex = 83;
            this.radioButton_female.TabStop = true;
            this.radioButton_female.Text = "Nữ";
            this.radioButton_female.UseVisualStyleBackColor = true;
            // 
            // radioButton_male
            // 
            this.radioButton_male.AutoSize = true;
            this.radioButton_male.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_male.ForeColor = System.Drawing.Color.Black;
            this.radioButton_male.Location = new System.Drawing.Point(267, 449);
            this.radioButton_male.Name = "radioButton_male";
            this.radioButton_male.Size = new System.Drawing.Size(92, 41);
            this.radioButton_male.TabIndex = 82;
            this.radioButton_male.TabStop = true;
            this.radioButton_male.Text = "Nam";
            this.radioButton_male.UseVisualStyleBackColor = true;
            // 
            // label_Gender
            // 
            this.label_Gender.AutoSize = true;
            this.label_Gender.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Gender.ForeColor = System.Drawing.Color.Black;
            this.label_Gender.Location = new System.Drawing.Point(60, 448);
            this.label_Gender.Name = "label_Gender";
            this.label_Gender.Size = new System.Drawing.Size(127, 37);
            this.label_Gender.TabIndex = 81;
            this.label_Gender.Text = "Giới tính:";
            // 
            // label_Addr
            // 
            this.label_Addr.AutoSize = true;
            this.label_Addr.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Addr.ForeColor = System.Drawing.Color.Black;
            this.label_Addr.Location = new System.Drawing.Point(60, 306);
            this.label_Addr.Name = "label_Addr";
            this.label_Addr.Size = new System.Drawing.Size(105, 37);
            this.label_Addr.TabIndex = 80;
            this.label_Addr.Text = "Địa chỉ:";
            // 
            // dateTimePicker_Bdate
            // 
            this.dateTimePicker_Bdate.CalendarForeColor = System.Drawing.Color.Gold;
            this.dateTimePicker_Bdate.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker_Bdate.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_Bdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_Bdate.Location = new System.Drawing.Point(267, 188);
            this.dateTimePicker_Bdate.Name = "dateTimePicker_Bdate";
            this.dateTimePicker_Bdate.Size = new System.Drawing.Size(199, 42);
            this.dateTimePicker_Bdate.TabIndex = 77;
            // 
            // textBox_fName
            // 
            this.textBox_fName.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_fName.ForeColor = System.Drawing.Color.Black;
            this.textBox_fName.Location = new System.Drawing.Point(267, 27);
            this.textBox_fName.Name = "textBox_fName";
            this.textBox_fName.Size = new System.Drawing.Size(310, 42);
            this.textBox_fName.TabIndex = 76;
            // 
            // label_showImage
            // 
            this.label_showImage.AutoSize = true;
            this.label_showImage.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_showImage.ForeColor = System.Drawing.Color.Black;
            this.label_showImage.Location = new System.Drawing.Point(613, 26);
            this.label_showImage.Name = "label_showImage";
            this.label_showImage.Size = new System.Drawing.Size(133, 37);
            this.label_showImage.TabIndex = 75;
            this.label_showImage.Text = "Hình ảnh:";
            // 
            // label_Bdate
            // 
            this.label_Bdate.AutoSize = true;
            this.label_Bdate.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Bdate.ForeColor = System.Drawing.Color.Black;
            this.label_Bdate.Location = new System.Drawing.Point(60, 188);
            this.label_Bdate.Name = "label_Bdate";
            this.label_Bdate.Size = new System.Drawing.Size(147, 37);
            this.label_Bdate.TabIndex = 74;
            this.label_Bdate.Text = "Ngày sinh: ";
            // 
            // label_FName
            // 
            this.label_FName.AutoSize = true;
            this.label_FName.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FName.ForeColor = System.Drawing.Color.Black;
            this.label_FName.Location = new System.Drawing.Point(103, 27);
            this.label_FName.Name = "label_FName";
            this.label_FName.Size = new System.Drawing.Size(57, 37);
            this.label_FName.TabIndex = 73;
            this.label_FName.Text = "Họ:";
            // 
            // textBox_id
            // 
            this.textBox_id.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_id.ForeColor = System.Drawing.Color.Black;
            this.textBox_id.Location = new System.Drawing.Point(598, 7);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(179, 42);
            this.textBox_id.TabIndex = 97;
            this.textBox_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_id_KeyDown);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.ForeColor = System.Drawing.Color.Black;
            this.label_id.Location = new System.Drawing.Point(272, 12);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(181, 37);
            this.label_id.TabIndex = 96;
            this.label_id.Text = "Mã Nhân Viên";
            // 
            // button_select
            // 
            this.button_select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_select.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_select.ForeColor = System.Drawing.Color.White;
            this.button_select.Location = new System.Drawing.Point(783, 7);
            this.button_select.Name = "button_select";
            this.button_select.Size = new System.Drawing.Size(272, 42);
            this.button_select.TabIndex = 96;
            this.button_select.Text = "Danh Sách Nhân Viên";
            this.button_select.UseVisualStyleBackColor = false;
            this.button_select.Click += new System.EventHandler(this.button_select_Click);
            // 
            // comboBox_work
            // 
            this.comboBox_work.FormattingEnabled = true;
            this.comboBox_work.Location = new System.Drawing.Point(598, 68);
            this.comboBox_work.Name = "comboBox_work";
            this.comboBox_work.Size = new System.Drawing.Size(179, 24);
            this.comboBox_work.TabIndex = 98;
            this.comboBox_work.SelectedIndexChanged += new System.EventHandler(this.comboBox_work_SelectedIndexChanged);
            // 
            // comboBox_spec
            // 
            this.comboBox_spec.FormattingEnabled = true;
            this.comboBox_spec.Location = new System.Drawing.Point(598, 114);
            this.comboBox_spec.Name = "comboBox_spec";
            this.comboBox_spec.Size = new System.Drawing.Size(179, 24);
            this.comboBox_spec.TabIndex = 99;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(272, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 37);
            this.label1.TabIndex = 96;
            this.label1.Text = "Công Việc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(272, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 37);
            this.label2.TabIndex = 100;
            this.label2.Text = "Chuyên Môn";
            // 
            // pictureBox_image
            // 
            this.pictureBox_image.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_image.Image = global::Parking_Lot_Project.Properties.Resources._435_4354686_login_icons_png_transparent_png;
            this.pictureBox_image.Location = new System.Drawing.Point(610, 71);
            this.pictureBox_image.Name = "pictureBox_image";
            this.pictureBox_image.Size = new System.Drawing.Size(265, 222);
            this.pictureBox_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_image.TabIndex = 78;
            this.pictureBox_image.TabStop = false;
            // 
            // addSpecForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1130, 771);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_spec);
            this.Controls.Add(this.comboBox_work);
            this.Controls.Add(this.button_select);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.panel_infor);
            this.Name = "addSpecForm";
            this.Text = "addSpecForm";
            this.Load += new System.EventHandler(this.addSpecForm_Load);
            this.panel_infor.ResumeLayout(false);
            this.panel_infor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_infor;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.TextBox textBox_Lname;
        private System.Windows.Forms.Label label_LName;
        private System.Windows.Forms.Button button_downImage;
        private System.Windows.Forms.ComboBox comboBox_cameras;
        private System.Windows.Forms.Button button_stopCam;
        private System.Windows.Forms.Button button_takePhoto;
        private System.Windows.Forms.Button button_openCam;
        private System.Windows.Forms.TextBox textBox_CMND;
        private System.Windows.Forms.Label label_CMND;
        private System.Windows.Forms.RichTextBox richTextBox_addr;
        private System.Windows.Forms.RadioButton radioButton_female;
        private System.Windows.Forms.RadioButton radioButton_male;
        private System.Windows.Forms.Label label_Gender;
        private System.Windows.Forms.Label label_Addr;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Bdate;
        private System.Windows.Forms.TextBox textBox_fName;
        private System.Windows.Forms.Label label_showImage;
        private System.Windows.Forms.Label label_Bdate;
        private System.Windows.Forms.Label label_FName;
        private System.Windows.Forms.PictureBox pictureBox_image;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Button button_select;
        private System.Windows.Forms.ComboBox comboBox_spec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_addSpec;
        public System.Windows.Forms.ComboBox comboBox_work;
    }
}