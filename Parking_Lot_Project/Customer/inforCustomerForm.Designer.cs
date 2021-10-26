
namespace Parking_Lot_Project
{
    partial class inforCustomerForm
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
            this.Female = new MaterialSkin.Controls.MaterialRadioButton();
            this.Male = new MaterialSkin.Controls.MaterialRadioButton();
            this.dateTimePicker_bdate = new System.Windows.Forms.DateTimePicker();
            this.textBox_mail = new System.Windows.Forms.TextBox();
            this.label_mail = new System.Windows.Forms.Label();
            this.textBox_addr = new System.Windows.Forms.TextBox();
            this.label_addr = new System.Windows.Forms.Label();
            this.textBox_country = new System.Windows.Forms.TextBox();
            this.label_country = new System.Windows.Forms.Label();
            this.label_gender = new System.Windows.Forms.Label();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.label_phone = new System.Windows.Forms.Label();
            this.label_bdate = new System.Windows.Forms.Label();
            this.textBox_lname = new System.Windows.Forms.TextBox();
            this.label_lname = new System.Windows.Forms.Label();
            this.textBox_fname = new System.Windows.Forms.TextBox();
            this.label_fname = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.label_img = new System.Windows.Forms.Label();
            this.pictureBox_img = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_img)).BeginInit();
            this.SuspendLayout();
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Depth = 0;
            this.Female.Location = new System.Drawing.Point(310, 214);
            this.Female.Margin = new System.Windows.Forms.Padding(0);
            this.Female.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Female.MouseState = MaterialSkin.MouseState.HOVER;
            this.Female.Name = "Female";
            this.Female.Ripple = true;
            this.Female.Size = new System.Drawing.Size(56, 37);
            this.Female.TabIndex = 48;
            this.Female.TabStop = true;
            this.Female.Text = "Nữ";
            this.Female.UseVisualStyleBackColor = true;
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Depth = 0;
            this.Male.Location = new System.Drawing.Point(209, 214);
            this.Male.Margin = new System.Windows.Forms.Padding(0);
            this.Male.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Male.MouseState = MaterialSkin.MouseState.HOVER;
            this.Male.Name = "Male";
            this.Male.Ripple = true;
            this.Male.Size = new System.Drawing.Size(69, 37);
            this.Male.TabIndex = 47;
            this.Male.TabStop = true;
            this.Male.Text = "Nam";
            this.Male.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_bdate
            // 
            this.dateTimePicker_bdate.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker_bdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_bdate.Location = new System.Drawing.Point(209, 145);
            this.dateTimePicker_bdate.Name = "dateTimePicker_bdate";
            this.dateTimePicker_bdate.Size = new System.Drawing.Size(218, 22);
            this.dateTimePicker_bdate.TabIndex = 46;
            // 
            // textBox_mail
            // 
            this.textBox_mail.Location = new System.Drawing.Point(209, 349);
            this.textBox_mail.Name = "textBox_mail";
            this.textBox_mail.Size = new System.Drawing.Size(218, 22);
            this.textBox_mail.TabIndex = 45;
            // 
            // label_mail
            // 
            this.label_mail.AutoSize = true;
            this.label_mail.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mail.ForeColor = System.Drawing.Color.White;
            this.label_mail.Location = new System.Drawing.Point(27, 347);
            this.label_mail.Name = "label_mail";
            this.label_mail.Size = new System.Drawing.Size(61, 23);
            this.label_mail.TabIndex = 44;
            this.label_mail.Text = "GMAIL";
            // 
            // textBox_addr
            // 
            this.textBox_addr.Location = new System.Drawing.Point(209, 312);
            this.textBox_addr.Multiline = true;
            this.textBox_addr.Name = "textBox_addr";
            this.textBox_addr.Size = new System.Drawing.Size(218, 22);
            this.textBox_addr.TabIndex = 43;
            // 
            // label_addr
            // 
            this.label_addr.AutoSize = true;
            this.label_addr.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_addr.ForeColor = System.Drawing.Color.White;
            this.label_addr.Location = new System.Drawing.Point(23, 310);
            this.label_addr.Name = "label_addr";
            this.label_addr.Size = new System.Drawing.Size(65, 23);
            this.label_addr.TabIndex = 42;
            this.label_addr.Text = "Địa Chỉ";
            // 
            // textBox_country
            // 
            this.textBox_country.Location = new System.Drawing.Point(209, 274);
            this.textBox_country.Name = "textBox_country";
            this.textBox_country.Size = new System.Drawing.Size(218, 22);
            this.textBox_country.TabIndex = 41;
            // 
            // label_country
            // 
            this.label_country.AutoSize = true;
            this.label_country.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_country.ForeColor = System.Drawing.Color.White;
            this.label_country.Location = new System.Drawing.Point(23, 272);
            this.label_country.Name = "label_country";
            this.label_country.Size = new System.Drawing.Size(86, 23);
            this.label_country.TabIndex = 40;
            this.label_country.Text = "Quốc Tịch";
            // 
            // label_gender
            // 
            this.label_gender.AutoSize = true;
            this.label_gender.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gender.ForeColor = System.Drawing.Color.White;
            this.label_gender.Location = new System.Drawing.Point(23, 222);
            this.label_gender.Name = "label_gender";
            this.label_gender.Size = new System.Drawing.Size(77, 23);
            this.label_gender.TabIndex = 39;
            this.label_gender.Text = "Giới Tính";
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(209, 183);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(218, 22);
            this.textBox_phone.TabIndex = 38;
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_phone.ForeColor = System.Drawing.Color.White;
            this.label_phone.Location = new System.Drawing.Point(23, 182);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(115, 23);
            this.label_phone.TabIndex = 37;
            this.label_phone.Text = "Số Điện Thoại";
            // 
            // label_bdate
            // 
            this.label_bdate.AutoSize = true;
            this.label_bdate.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bdate.ForeColor = System.Drawing.Color.White;
            this.label_bdate.Location = new System.Drawing.Point(23, 148);
            this.label_bdate.Name = "label_bdate";
            this.label_bdate.Size = new System.Drawing.Size(86, 23);
            this.label_bdate.TabIndex = 36;
            this.label_bdate.Text = "Sinh Nhật";
            // 
            // textBox_lname
            // 
            this.textBox_lname.Location = new System.Drawing.Point(209, 108);
            this.textBox_lname.Name = "textBox_lname";
            this.textBox_lname.Size = new System.Drawing.Size(218, 22);
            this.textBox_lname.TabIndex = 35;
            // 
            // label_lname
            // 
            this.label_lname.AutoSize = true;
            this.label_lname.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lname.ForeColor = System.Drawing.Color.White;
            this.label_lname.Location = new System.Drawing.Point(23, 107);
            this.label_lname.Name = "label_lname";
            this.label_lname.Size = new System.Drawing.Size(134, 23);
            this.label_lname.TabIndex = 34;
            this.label_lname.Text = "Tên Khách Hàng";
            // 
            // textBox_fname
            // 
            this.textBox_fname.Location = new System.Drawing.Point(209, 69);
            this.textBox_fname.Name = "textBox_fname";
            this.textBox_fname.Size = new System.Drawing.Size(218, 22);
            this.textBox_fname.TabIndex = 33;
            // 
            // label_fname
            // 
            this.label_fname.AutoSize = true;
            this.label_fname.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fname.ForeColor = System.Drawing.Color.White;
            this.label_fname.Location = new System.Drawing.Point(23, 68);
            this.label_fname.Name = "label_fname";
            this.label_fname.Size = new System.Drawing.Size(129, 23);
            this.label_fname.TabIndex = 32;
            this.label_fname.Text = "Họ Khách Hàng";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(209, 30);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(218, 22);
            this.textBox_id.TabIndex = 31;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.ForeColor = System.Drawing.Color.White;
            this.label_id.Location = new System.Drawing.Point(23, 28);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(132, 23);
            this.label_id.TabIndex = 30;
            this.label_id.Text = "Mã Khách Hàng";
            // 
            // label_img
            // 
            this.label_img.AutoSize = true;
            this.label_img.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_img.ForeColor = System.Drawing.Color.White;
            this.label_img.Location = new System.Drawing.Point(27, 389);
            this.label_img.Name = "label_img";
            this.label_img.Size = new System.Drawing.Size(144, 23);
            this.label_img.TabIndex = 50;
            this.label_img.Text = "Hình Khách Hàng";
            // 
            // pictureBox_img
            // 
            this.pictureBox_img.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_img.Location = new System.Drawing.Point(209, 389);
            this.pictureBox_img.Name = "pictureBox_img";
            this.pictureBox_img.Size = new System.Drawing.Size(218, 120);
            this.pictureBox_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_img.TabIndex = 49;
            this.pictureBox_img.TabStop = false;
            // 
            // inforCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(493, 546);
            this.Controls.Add(this.label_img);
            this.Controls.Add(this.pictureBox_img);
            this.Controls.Add(this.Female);
            this.Controls.Add(this.Male);
            this.Controls.Add(this.dateTimePicker_bdate);
            this.Controls.Add(this.textBox_mail);
            this.Controls.Add(this.label_mail);
            this.Controls.Add(this.textBox_addr);
            this.Controls.Add(this.label_addr);
            this.Controls.Add(this.textBox_country);
            this.Controls.Add(this.label_country);
            this.Controls.Add(this.label_gender);
            this.Controls.Add(this.textBox_phone);
            this.Controls.Add(this.label_phone);
            this.Controls.Add(this.label_bdate);
            this.Controls.Add(this.textBox_lname);
            this.Controls.Add(this.label_lname);
            this.Controls.Add(this.textBox_fname);
            this.Controls.Add(this.label_fname);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label_id);
            this.Name = "inforCustomerForm";
            this.Text = "inforCustomerForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MaterialSkin.Controls.MaterialRadioButton Female;
        public MaterialSkin.Controls.MaterialRadioButton Male;
        public System.Windows.Forms.DateTimePicker dateTimePicker_bdate;
        public System.Windows.Forms.TextBox textBox_mail;
        public System.Windows.Forms.Label label_mail;
        public System.Windows.Forms.TextBox textBox_addr;
        public System.Windows.Forms.Label label_addr;
        public System.Windows.Forms.TextBox textBox_country;
        public System.Windows.Forms.Label label_country;
        public System.Windows.Forms.Label label_gender;
        public System.Windows.Forms.TextBox textBox_phone;
        public System.Windows.Forms.Label label_phone;
        public System.Windows.Forms.Label label_bdate;
        public System.Windows.Forms.TextBox textBox_lname;
        public System.Windows.Forms.Label label_lname;
        public System.Windows.Forms.TextBox textBox_fname;
        public System.Windows.Forms.Label label_fname;
        public System.Windows.Forms.TextBox textBox_id;
        public System.Windows.Forms.Label label_id;
        public System.Windows.Forms.PictureBox pictureBox_img;
        public System.Windows.Forms.Label label_img;
    }
}