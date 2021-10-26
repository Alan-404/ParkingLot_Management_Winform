
namespace Parking_Lot_Project
{
    partial class customerListForm
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
            this.materialButton_add = new MaterialSkin.Controls.MaterialButton();
            this.label_cus = new System.Windows.Forms.Label();
            this.dataGridView_cus = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_dark = new System.Windows.Forms.Label();
            this.materialButton_remove = new MaterialSkin.Controls.MaterialButton();
            this.materialButton_edit = new MaterialSkin.Controls.MaterialButton();
            this.comboBox_gender = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_bdate = new System.Windows.Forms.DateTimePicker();
            this.pictureBox_img = new System.Windows.Forms.PictureBox();
            this.label_img = new System.Windows.Forms.Label();
            this.textBox_mail = new System.Windows.Forms.TextBox();
            this.label_mail = new System.Windows.Forms.Label();
            this.textBox_fname = new System.Windows.Forms.TextBox();
            this.label_fname = new System.Windows.Forms.Label();
            this.label_gender = new System.Windows.Forms.Label();
            this.textBox_country = new System.Windows.Forms.TextBox();
            this.label_country = new System.Windows.Forms.Label();
            this.textBox_addr = new System.Windows.Forms.TextBox();
            this.label_addr = new System.Windows.Forms.Label();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.label_phone = new System.Windows.Forms.Label();
            this.label_bdate = new System.Windows.Forms.Label();
            this.textBox_lname = new System.Windows.Forms.TextBox();
            this.label_lname = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.label_infor = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cus)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_img)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.materialButton_add);
            this.panel1.Controls.Add(this.label_cus);
            this.panel1.Controls.Add(this.dataGridView_cus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 747);
            this.panel1.TabIndex = 0;
            // 
            // materialButton_add
            // 
            this.materialButton_add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton_add.Depth = 0;
            this.materialButton_add.DrawShadows = true;
            this.materialButton_add.HighEmphasis = true;
            this.materialButton_add.Icon = null;
            this.materialButton_add.Location = new System.Drawing.Point(13, 657);
            this.materialButton_add.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton_add.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton_add.Name = "materialButton_add";
            this.materialButton_add.Size = new System.Drawing.Size(160, 36);
            this.materialButton_add.TabIndex = 33;
            this.materialButton_add.Text = "Thêm Khách Hàng";
            this.materialButton_add.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton_add.UseAccentColor = false;
            this.materialButton_add.UseVisualStyleBackColor = true;
            this.materialButton_add.Click += new System.EventHandler(this.materialButton_add_Click);
            // 
            // label_cus
            // 
            this.label_cus.AutoSize = true;
            this.label_cus.Font = new System.Drawing.Font("Myanmar Text", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cus.ForeColor = System.Drawing.Color.White;
            this.label_cus.Location = new System.Drawing.Point(309, 14);
            this.label_cus.Name = "label_cus";
            this.label_cus.Size = new System.Drawing.Size(421, 67);
            this.label_cus.TabIndex = 1;
            this.label_cus.Text = "Danh Sách Khách Hàng";
            this.label_cus.Click += new System.EventHandler(this.label_cus_Click);
            // 
            // dataGridView_cus
            // 
            this.dataGridView_cus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_cus.Location = new System.Drawing.Point(3, 104);
            this.dataGridView_cus.Name = "dataGridView_cus";
            this.dataGridView_cus.RowHeadersWidth = 51;
            this.dataGridView_cus.RowTemplate.Height = 24;
            this.dataGridView_cus.Size = new System.Drawing.Size(1001, 507);
            this.dataGridView_cus.TabIndex = 0;
            this.dataGridView_cus.DoubleClick += new System.EventHandler(this.dataGridView_cus_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.label_dark);
            this.panel2.Controls.Add(this.materialButton_remove);
            this.panel2.Controls.Add(this.materialButton_edit);
            this.panel2.Controls.Add(this.comboBox_gender);
            this.panel2.Controls.Add(this.dateTimePicker_bdate);
            this.panel2.Controls.Add(this.pictureBox_img);
            this.panel2.Controls.Add(this.label_img);
            this.panel2.Controls.Add(this.textBox_mail);
            this.panel2.Controls.Add(this.label_mail);
            this.panel2.Controls.Add(this.textBox_fname);
            this.panel2.Controls.Add(this.label_fname);
            this.panel2.Controls.Add(this.label_gender);
            this.panel2.Controls.Add(this.textBox_country);
            this.panel2.Controls.Add(this.label_country);
            this.panel2.Controls.Add(this.textBox_addr);
            this.panel2.Controls.Add(this.label_addr);
            this.panel2.Controls.Add(this.textBox_phone);
            this.panel2.Controls.Add(this.label_phone);
            this.panel2.Controls.Add(this.label_bdate);
            this.panel2.Controls.Add(this.textBox_lname);
            this.panel2.Controls.Add(this.label_lname);
            this.panel2.Controls.Add(this.textBox_id);
            this.panel2.Controls.Add(this.label_id);
            this.panel2.Controls.Add(this.label_infor);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(1010, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 747);
            this.panel2.TabIndex = 1;
            // 
            // label_dark
            // 
            this.label_dark.AutoSize = true;
            this.label_dark.Location = new System.Drawing.Point(47, 665);
            this.label_dark.Name = "label_dark";
            this.label_dark.Size = new System.Drawing.Size(46, 18);
            this.label_dark.TabIndex = 33;
            this.label_dark.Text = "label6";
            // 
            // materialButton_remove
            // 
            this.materialButton_remove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton_remove.Depth = 0;
            this.materialButton_remove.DrawShadows = true;
            this.materialButton_remove.HighEmphasis = true;
            this.materialButton_remove.Icon = null;
            this.materialButton_remove.Location = new System.Drawing.Point(211, 665);
            this.materialButton_remove.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton_remove.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton_remove.Name = "materialButton_remove";
            this.materialButton_remove.Size = new System.Drawing.Size(148, 36);
            this.materialButton_remove.TabIndex = 32;
            this.materialButton_remove.Text = "Xóa Khách Hàng";
            this.materialButton_remove.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton_remove.UseAccentColor = false;
            this.materialButton_remove.UseVisualStyleBackColor = true;
            this.materialButton_remove.Click += new System.EventHandler(this.materialButton_remove_Click);
            // 
            // materialButton_edit
            // 
            this.materialButton_edit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton_edit.Depth = 0;
            this.materialButton_edit.DrawShadows = true;
            this.materialButton_edit.HighEmphasis = true;
            this.materialButton_edit.Icon = null;
            this.materialButton_edit.Location = new System.Drawing.Point(211, 598);
            this.materialButton_edit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton_edit.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton_edit.Name = "materialButton_edit";
            this.materialButton_edit.Size = new System.Drawing.Size(174, 36);
            this.materialButton_edit.TabIndex = 31;
            this.materialButton_edit.Text = "Cập Nhật Thông Tin";
            this.materialButton_edit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton_edit.UseAccentColor = false;
            this.materialButton_edit.UseVisualStyleBackColor = true;
            this.materialButton_edit.Click += new System.EventHandler(this.materialButton_edit_Click);
            // 
            // comboBox_gender
            // 
            this.comboBox_gender.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_gender.FormattingEnabled = true;
            this.comboBox_gender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.comboBox_gender.Location = new System.Drawing.Point(211, 321);
            this.comboBox_gender.Name = "comboBox_gender";
            this.comboBox_gender.Size = new System.Drawing.Size(217, 26);
            this.comboBox_gender.TabIndex = 30;
            // 
            // dateTimePicker_bdate
            // 
            this.dateTimePicker_bdate.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker_bdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_bdate.Location = new System.Drawing.Point(211, 231);
            this.dateTimePicker_bdate.Name = "dateTimePicker_bdate";
            this.dateTimePicker_bdate.Size = new System.Drawing.Size(200, 24);
            this.dateTimePicker_bdate.TabIndex = 29;
            // 
            // pictureBox_img
            // 
            this.pictureBox_img.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_img.Location = new System.Drawing.Point(211, 492);
            this.pictureBox_img.Name = "pictureBox_img";
            this.pictureBox_img.Size = new System.Drawing.Size(217, 85);
            this.pictureBox_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_img.TabIndex = 28;
            this.pictureBox_img.TabStop = false;
            // 
            // label_img
            // 
            this.label_img.AutoSize = true;
            this.label_img.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_img.ForeColor = System.Drawing.Color.White;
            this.label_img.Location = new System.Drawing.Point(14, 492);
            this.label_img.Name = "label_img";
            this.label_img.Size = new System.Drawing.Size(150, 23);
            this.label_img.TabIndex = 27;
            this.label_img.Text = "Hình Khách Hàng";
            // 
            // textBox_mail
            // 
            this.textBox_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_mail.Location = new System.Drawing.Point(211, 454);
            this.textBox_mail.Name = "textBox_mail";
            this.textBox_mail.Size = new System.Drawing.Size(217, 24);
            this.textBox_mail.TabIndex = 26;
            // 
            // label_mail
            // 
            this.label_mail.AutoSize = true;
            this.label_mail.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mail.ForeColor = System.Drawing.Color.White;
            this.label_mail.Location = new System.Drawing.Point(14, 454);
            this.label_mail.Name = "label_mail";
            this.label_mail.Size = new System.Drawing.Size(46, 23);
            this.label_mail.TabIndex = 25;
            this.label_mail.Text = "Mail";
            // 
            // textBox_fname
            // 
            this.textBox_fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_fname.Location = new System.Drawing.Point(211, 144);
            this.textBox_fname.Name = "textBox_fname";
            this.textBox_fname.Size = new System.Drawing.Size(217, 24);
            this.textBox_fname.TabIndex = 24;
            // 
            // label_fname
            // 
            this.label_fname.AutoSize = true;
            this.label_fname.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fname.ForeColor = System.Drawing.Color.White;
            this.label_fname.Location = new System.Drawing.Point(11, 142);
            this.label_fname.Name = "label_fname";
            this.label_fname.Size = new System.Drawing.Size(134, 23);
            this.label_fname.TabIndex = 23;
            this.label_fname.Text = "Họ Khách Hàng";
            // 
            // label_gender
            // 
            this.label_gender.AutoSize = true;
            this.label_gender.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gender.ForeColor = System.Drawing.Color.White;
            this.label_gender.Location = new System.Drawing.Point(14, 320);
            this.label_gender.Name = "label_gender";
            this.label_gender.Size = new System.Drawing.Size(82, 23);
            this.label_gender.TabIndex = 21;
            this.label_gender.Text = "Giới Tính";
            // 
            // textBox_country
            // 
            this.textBox_country.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_country.Location = new System.Drawing.Point(211, 366);
            this.textBox_country.Name = "textBox_country";
            this.textBox_country.Size = new System.Drawing.Size(217, 24);
            this.textBox_country.TabIndex = 20;
            // 
            // label_country
            // 
            this.label_country.AutoSize = true;
            this.label_country.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_country.ForeColor = System.Drawing.Color.White;
            this.label_country.Location = new System.Drawing.Point(14, 412);
            this.label_country.Name = "label_country";
            this.label_country.Size = new System.Drawing.Size(90, 23);
            this.label_country.TabIndex = 19;
            this.label_country.Text = "Quốc Tịch";
            // 
            // textBox_addr
            // 
            this.textBox_addr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_addr.Location = new System.Drawing.Point(211, 412);
            this.textBox_addr.Name = "textBox_addr";
            this.textBox_addr.Size = new System.Drawing.Size(217, 24);
            this.textBox_addr.TabIndex = 18;
            // 
            // label_addr
            // 
            this.label_addr.AutoSize = true;
            this.label_addr.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_addr.ForeColor = System.Drawing.Color.White;
            this.label_addr.Location = new System.Drawing.Point(14, 366);
            this.label_addr.Name = "label_addr";
            this.label_addr.Size = new System.Drawing.Size(66, 23);
            this.label_addr.TabIndex = 17;
            this.label_addr.Text = "Địa Chỉ";
            // 
            // textBox_phone
            // 
            this.textBox_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_phone.Location = new System.Drawing.Point(211, 274);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(217, 24);
            this.textBox_phone.TabIndex = 10;
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_phone.ForeColor = System.Drawing.Color.White;
            this.label_phone.Location = new System.Drawing.Point(11, 275);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(121, 23);
            this.label_phone.TabIndex = 9;
            this.label_phone.Text = "Số Điện Thoại";
            // 
            // label_bdate
            // 
            this.label_bdate.AutoSize = true;
            this.label_bdate.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bdate.ForeColor = System.Drawing.Color.White;
            this.label_bdate.Location = new System.Drawing.Point(11, 230);
            this.label_bdate.Name = "label_bdate";
            this.label_bdate.Size = new System.Drawing.Size(93, 23);
            this.label_bdate.TabIndex = 7;
            this.label_bdate.Text = "Ngày Sinh";
            // 
            // textBox_lname
            // 
            this.textBox_lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_lname.Location = new System.Drawing.Point(211, 187);
            this.textBox_lname.Name = "textBox_lname";
            this.textBox_lname.Size = new System.Drawing.Size(217, 24);
            this.textBox_lname.TabIndex = 6;
            // 
            // label_lname
            // 
            this.label_lname.AutoSize = true;
            this.label_lname.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lname.ForeColor = System.Drawing.Color.White;
            this.label_lname.Location = new System.Drawing.Point(11, 185);
            this.label_lname.Name = "label_lname";
            this.label_lname.Size = new System.Drawing.Size(142, 23);
            this.label_lname.TabIndex = 5;
            this.label_lname.Text = "Tên Khách Hàng";
            // 
            // textBox_id
            // 
            this.textBox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_id.Location = new System.Drawing.Point(211, 103);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(217, 24);
            this.textBox_id.TabIndex = 4;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.ForeColor = System.Drawing.Color.White;
            this.label_id.Location = new System.Drawing.Point(7, 101);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(138, 23);
            this.label_id.TabIndex = 3;
            this.label_id.Text = "Mã Khách Hàng";
            // 
            // label_infor
            // 
            this.label_infor.AutoSize = true;
            this.label_infor.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_infor.ForeColor = System.Drawing.Color.White;
            this.label_infor.Location = new System.Drawing.Point(6, 28);
            this.label_infor.Name = "label_infor";
            this.label_infor.Size = new System.Drawing.Size(324, 53);
            this.label_infor.TabIndex = 2;
            this.label_infor.Text = "Thông Tin Khách Hàng";
            // 
            // customerListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 747);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "customerListForm";
            this.Text = "customerListForm";
            this.Load += new System.EventHandler(this.customerListForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cus)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_cus;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_cus;
        private MaterialSkin.Controls.MaterialButton materialButton_remove;
        private MaterialSkin.Controls.MaterialButton materialButton_edit;
        private System.Windows.Forms.ComboBox comboBox_gender;
        private System.Windows.Forms.DateTimePicker dateTimePicker_bdate;
        private System.Windows.Forms.PictureBox pictureBox_img;
        private System.Windows.Forms.Label label_img;
        private System.Windows.Forms.TextBox textBox_mail;
        private System.Windows.Forms.Label label_mail;
        private System.Windows.Forms.TextBox textBox_fname;
        private System.Windows.Forms.Label label_fname;
        private System.Windows.Forms.Label label_gender;
        private System.Windows.Forms.TextBox textBox_country;
        private System.Windows.Forms.Label label_country;
        private System.Windows.Forms.TextBox textBox_addr;
        private System.Windows.Forms.Label label_addr;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.Label label_bdate;
        private System.Windows.Forms.TextBox textBox_lname;
        private System.Windows.Forms.Label label_lname;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_infor;
        private MaterialSkin.Controls.MaterialButton materialButton_add;
        public System.Windows.Forms.Label label_dark;
    }
}