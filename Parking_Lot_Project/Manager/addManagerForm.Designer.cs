
namespace Parking_Lot_Project
{
    partial class addManagerForm
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
            this.materialLabel_id = new MaterialSkin.Controls.MaterialLabel();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.materialButton_select = new MaterialSkin.Controls.MaterialButton();
            this.panel_infor = new System.Windows.Forms.Panel();
            this.comboBox_work = new System.Windows.Forms.ComboBox();
            this.materialLabel_work = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton_ok = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox_image = new System.Windows.Forms.PictureBox();
            this.materialLabel_image = new MaterialSkin.Controls.MaterialLabel();
            this.textBox_gender = new System.Windows.Forms.TextBox();
            this.textBox_bdate = new System.Windows.Forms.TextBox();
            this.materialLabel_gender = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel_bdate = new MaterialSkin.Controls.MaterialLabel();
            this.textBox_addr = new System.Windows.Forms.TextBox();
            this.materialLabel_addr = new MaterialSkin.Controls.MaterialLabel();
            this.textBox_cmnd = new System.Windows.Forms.TextBox();
            this.materialLabel_cmnd = new MaterialSkin.Controls.MaterialLabel();
            this.textBox_fullName = new System.Windows.Forms.TextBox();
            this.materialLabel_fullName = new MaterialSkin.Controls.MaterialLabel();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.materialLabel_phone = new MaterialSkin.Controls.MaterialLabel();
            this.panel_infor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel_id
            // 
            this.materialLabel_id.AutoSize = true;
            this.materialLabel_id.Depth = 0;
            this.materialLabel_id.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel_id.Location = new System.Drawing.Point(40, 115);
            this.materialLabel_id.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel_id.Name = "materialLabel_id";
            this.materialLabel_id.Size = new System.Drawing.Size(16, 19);
            this.materialLabel_id.TabIndex = 0;
            this.materialLabel_id.Text = "ID";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(81, 112);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(136, 22);
            this.textBox_id.TabIndex = 1;
            this.textBox_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_id_KeyDown);
            // 
            // materialButton_select
            // 
            this.materialButton_select.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton_select.Depth = 0;
            this.materialButton_select.DrawShadows = true;
            this.materialButton_select.HighEmphasis = true;
            this.materialButton_select.Icon = null;
            this.materialButton_select.Location = new System.Drawing.Point(239, 98);
            this.materialButton_select.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton_select.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton_select.Name = "materialButton_select";
            this.materialButton_select.Size = new System.Drawing.Size(143, 36);
            this.materialButton_select.TabIndex = 2;
            this.materialButton_select.Text = "Chọn Nhân Viên";
            this.materialButton_select.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton_select.UseAccentColor = false;
            this.materialButton_select.UseVisualStyleBackColor = true;
            this.materialButton_select.Click += new System.EventHandler(this.materialButton_select_Click);
            // 
            // panel_infor
            // 
            this.panel_infor.Controls.Add(this.textBox_phone);
            this.panel_infor.Controls.Add(this.materialLabel_phone);
            this.panel_infor.Controls.Add(this.comboBox_work);
            this.panel_infor.Controls.Add(this.materialLabel_work);
            this.panel_infor.Controls.Add(this.materialButton_ok);
            this.panel_infor.Controls.Add(this.pictureBox_image);
            this.panel_infor.Controls.Add(this.materialLabel_image);
            this.panel_infor.Controls.Add(this.textBox_gender);
            this.panel_infor.Controls.Add(this.textBox_bdate);
            this.panel_infor.Controls.Add(this.materialLabel_gender);
            this.panel_infor.Controls.Add(this.materialLabel_bdate);
            this.panel_infor.Controls.Add(this.textBox_addr);
            this.panel_infor.Controls.Add(this.materialLabel_addr);
            this.panel_infor.Controls.Add(this.textBox_cmnd);
            this.panel_infor.Controls.Add(this.materialLabel_cmnd);
            this.panel_infor.Controls.Add(this.textBox_fullName);
            this.panel_infor.Controls.Add(this.materialLabel_fullName);
            this.panel_infor.Location = new System.Drawing.Point(6, 150);
            this.panel_infor.Name = "panel_infor";
            this.panel_infor.Size = new System.Drawing.Size(572, 669);
            this.panel_infor.TabIndex = 3;
            // 
            // comboBox_work
            // 
            this.comboBox_work.FormattingEnabled = true;
            this.comboBox_work.Items.AddRange(new object[] {
            "Bảo Vệ",
            "Sửa Xe",
            "Rửa Xe"});
            this.comboBox_work.Location = new System.Drawing.Point(269, 544);
            this.comboBox_work.Name = "comboBox_work";
            this.comboBox_work.Size = new System.Drawing.Size(261, 24);
            this.comboBox_work.TabIndex = 15;
            // 
            // materialLabel_work
            // 
            this.materialLabel_work.AutoSize = true;
            this.materialLabel_work.Depth = 0;
            this.materialLabel_work.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel_work.Location = new System.Drawing.Point(34, 549);
            this.materialLabel_work.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel_work.Name = "materialLabel_work";
            this.materialLabel_work.Size = new System.Drawing.Size(72, 19);
            this.materialLabel_work.TabIndex = 14;
            this.materialLabel_work.Text = "Công Việc";
            // 
            // materialButton_ok
            // 
            this.materialButton_ok.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton_ok.Depth = 0;
            this.materialButton_ok.DrawShadows = true;
            this.materialButton_ok.HighEmphasis = true;
            this.materialButton_ok.Icon = null;
            this.materialButton_ok.Location = new System.Drawing.Point(435, 614);
            this.materialButton_ok.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton_ok.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton_ok.Name = "materialButton_ok";
            this.materialButton_ok.Size = new System.Drawing.Size(95, 36);
            this.materialButton_ok.TabIndex = 4;
            this.materialButton_ok.Text = "Xác Nhận";
            this.materialButton_ok.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton_ok.UseAccentColor = false;
            this.materialButton_ok.UseVisualStyleBackColor = true;
            this.materialButton_ok.Click += new System.EventHandler(this.materialButton_ok_Click);
            // 
            // pictureBox_image
            // 
            this.pictureBox_image.Location = new System.Drawing.Point(269, 393);
            this.pictureBox_image.Name = "pictureBox_image";
            this.pictureBox_image.Size = new System.Drawing.Size(261, 124);
            this.pictureBox_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_image.TabIndex = 13;
            this.pictureBox_image.TabStop = false;
            // 
            // materialLabel_image
            // 
            this.materialLabel_image.AutoSize = true;
            this.materialLabel_image.Depth = 0;
            this.materialLabel_image.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel_image.Location = new System.Drawing.Point(34, 393);
            this.materialLabel_image.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel_image.Name = "materialLabel_image";
            this.materialLabel_image.Size = new System.Drawing.Size(66, 19);
            this.materialLabel_image.TabIndex = 12;
            this.materialLabel_image.Text = "Hình Ảnh";
            // 
            // textBox_gender
            // 
            this.textBox_gender.Location = new System.Drawing.Point(269, 338);
            this.textBox_gender.Name = "textBox_gender";
            this.textBox_gender.Size = new System.Drawing.Size(261, 22);
            this.textBox_gender.TabIndex = 7;
            // 
            // textBox_bdate
            // 
            this.textBox_bdate.Location = new System.Drawing.Point(269, 115);
            this.textBox_bdate.Name = "textBox_bdate";
            this.textBox_bdate.Size = new System.Drawing.Size(261, 22);
            this.textBox_bdate.TabIndex = 11;
            // 
            // materialLabel_gender
            // 
            this.materialLabel_gender.AutoSize = true;
            this.materialLabel_gender.Depth = 0;
            this.materialLabel_gender.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel_gender.Location = new System.Drawing.Point(34, 338);
            this.materialLabel_gender.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel_gender.Name = "materialLabel_gender";
            this.materialLabel_gender.Size = new System.Drawing.Size(65, 19);
            this.materialLabel_gender.TabIndex = 6;
            this.materialLabel_gender.Text = "Giới Tính";
            // 
            // materialLabel_bdate
            // 
            this.materialLabel_bdate.AutoSize = true;
            this.materialLabel_bdate.Depth = 0;
            this.materialLabel_bdate.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel_bdate.Location = new System.Drawing.Point(34, 115);
            this.materialLabel_bdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel_bdate.Name = "materialLabel_bdate";
            this.materialLabel_bdate.Size = new System.Drawing.Size(74, 19);
            this.materialLabel_bdate.TabIndex = 10;
            this.materialLabel_bdate.Text = "Ngày Sinh";
            // 
            // textBox_addr
            // 
            this.textBox_addr.Location = new System.Drawing.Point(269, 229);
            this.textBox_addr.Multiline = true;
            this.textBox_addr.Name = "textBox_addr";
            this.textBox_addr.Size = new System.Drawing.Size(261, 70);
            this.textBox_addr.TabIndex = 7;
            // 
            // materialLabel_addr
            // 
            this.materialLabel_addr.AutoSize = true;
            this.materialLabel_addr.Depth = 0;
            this.materialLabel_addr.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel_addr.Location = new System.Drawing.Point(34, 229);
            this.materialLabel_addr.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel_addr.Name = "materialLabel_addr";
            this.materialLabel_addr.Size = new System.Drawing.Size(52, 19);
            this.materialLabel_addr.TabIndex = 6;
            this.materialLabel_addr.Text = "Địa Chỉ";
            // 
            // textBox_cmnd
            // 
            this.textBox_cmnd.Location = new System.Drawing.Point(269, 65);
            this.textBox_cmnd.Name = "textBox_cmnd";
            this.textBox_cmnd.Size = new System.Drawing.Size(261, 22);
            this.textBox_cmnd.TabIndex = 5;
            // 
            // materialLabel_cmnd
            // 
            this.materialLabel_cmnd.AutoSize = true;
            this.materialLabel_cmnd.Depth = 0;
            this.materialLabel_cmnd.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel_cmnd.Location = new System.Drawing.Point(34, 65);
            this.materialLabel_cmnd.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel_cmnd.Name = "materialLabel_cmnd";
            this.materialLabel_cmnd.Size = new System.Drawing.Size(47, 19);
            this.materialLabel_cmnd.TabIndex = 4;
            this.materialLabel_cmnd.Text = "CMND";
            // 
            // textBox_fullName
            // 
            this.textBox_fullName.Location = new System.Drawing.Point(269, 14);
            this.textBox_fullName.Name = "textBox_fullName";
            this.textBox_fullName.Size = new System.Drawing.Size(261, 22);
            this.textBox_fullName.TabIndex = 3;
            // 
            // materialLabel_fullName
            // 
            this.materialLabel_fullName.AutoSize = true;
            this.materialLabel_fullName.Depth = 0;
            this.materialLabel_fullName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel_fullName.Location = new System.Drawing.Point(34, 14);
            this.materialLabel_fullName.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel_fullName.Name = "materialLabel_fullName";
            this.materialLabel_fullName.Size = new System.Drawing.Size(150, 19);
            this.materialLabel_fullName.TabIndex = 2;
            this.materialLabel_fullName.Text = "Họ và Tên Nhân Viên";
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(269, 175);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(261, 22);
            this.textBox_phone.TabIndex = 17;
            // 
            // materialLabel_phone
            // 
            this.materialLabel_phone.AutoSize = true;
            this.materialLabel_phone.Depth = 0;
            this.materialLabel_phone.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel_phone.Location = new System.Drawing.Point(34, 175);
            this.materialLabel_phone.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel_phone.Name = "materialLabel_phone";
            this.materialLabel_phone.Size = new System.Drawing.Size(101, 19);
            this.materialLabel_phone.TabIndex = 16;
            this.materialLabel_phone.Text = "Số Điện Thoại";
            // 
            // addManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 844);
            this.Controls.Add(this.panel_infor);
            this.Controls.Add(this.materialButton_select);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.materialLabel_id);
            this.Name = "addManagerForm";
            this.Text = "Thêm Quản Lý";
            this.Load += new System.EventHandler(this.addManagerForm_Load);
            this.panel_infor.ResumeLayout(false);
            this.panel_infor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel_id;
        private System.Windows.Forms.TextBox textBox_id;
        private MaterialSkin.Controls.MaterialButton materialButton_select;
        private System.Windows.Forms.Panel panel_infor;
        private System.Windows.Forms.TextBox textBox_cmnd;
        private MaterialSkin.Controls.MaterialLabel materialLabel_cmnd;
        private System.Windows.Forms.TextBox textBox_fullName;
        private MaterialSkin.Controls.MaterialLabel materialLabel_fullName;
        private MaterialSkin.Controls.MaterialButton materialButton_ok;
        private System.Windows.Forms.PictureBox pictureBox_image;
        private MaterialSkin.Controls.MaterialLabel materialLabel_image;
        private System.Windows.Forms.TextBox textBox_gender;
        private System.Windows.Forms.TextBox textBox_bdate;
        private MaterialSkin.Controls.MaterialLabel materialLabel_gender;
        private MaterialSkin.Controls.MaterialLabel materialLabel_bdate;
        private System.Windows.Forms.TextBox textBox_addr;
        private MaterialSkin.Controls.MaterialLabel materialLabel_addr;
        private System.Windows.Forms.ComboBox comboBox_work;
        private MaterialSkin.Controls.MaterialLabel materialLabel_work;
        private System.Windows.Forms.TextBox textBox_phone;
        private MaterialSkin.Controls.MaterialLabel materialLabel_phone;
    }
}