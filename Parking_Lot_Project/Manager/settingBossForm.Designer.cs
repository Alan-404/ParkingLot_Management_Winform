
namespace Parking_Lot_Project
{
    partial class settingBossForm
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
            this.materialLabel_name = new MaterialSkin.Controls.MaterialLabel();
            this.circularPicturebox_avatar = new Parking_Lot_Project.circularPicturebox();
            this.panel_changePass = new System.Windows.Forms.Panel();
            this.textBox_oldPass = new System.Windows.Forms.TextBox();
            this.panel_open = new System.Windows.Forms.Panel();
            this.materialButton_ok = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel_newPass = new MaterialSkin.Controls.MaterialLabel();
            this.textBox_rePass = new System.Windows.Forms.TextBox();
            this.textBox_newPass = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel_pass = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton_changePass = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel_username = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton_exit = new MaterialSkin.Controls.MaterialButton();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_username = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.circularPicturebox_avatar)).BeginInit();
            this.panel_changePass.SuspendLayout();
            this.panel_open.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel_name
            // 
            this.materialLabel_name.AutoSize = true;
            this.materialLabel_name.Depth = 0;
            this.materialLabel_name.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel_name.Location = new System.Drawing.Point(12, 227);
            this.materialLabel_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel_name.Name = "materialLabel_name";
            this.materialLabel_name.Size = new System.Drawing.Size(73, 19);
            this.materialLabel_name.TabIndex = 0;
            this.materialLabel_name.Text = "Họ và Tên";
            // 
            // circularPicturebox_avatar
            // 
            this.circularPicturebox_avatar.Image = global::Parking_Lot_Project.Properties.Resources._435_4354686_login_icons_png_transparent_png;
            this.circularPicturebox_avatar.Location = new System.Drawing.Point(169, 84);
            this.circularPicturebox_avatar.Name = "circularPicturebox_avatar";
            this.circularPicturebox_avatar.Size = new System.Drawing.Size(127, 119);
            this.circularPicturebox_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circularPicturebox_avatar.TabIndex = 4;
            this.circularPicturebox_avatar.TabStop = false;
            // 
            // panel_changePass
            // 
            this.panel_changePass.Controls.Add(this.textBox_oldPass);
            this.panel_changePass.Controls.Add(this.panel_open);
            this.panel_changePass.Controls.Add(this.materialLabel_pass);
            this.panel_changePass.Location = new System.Drawing.Point(12, 374);
            this.panel_changePass.Name = "panel_changePass";
            this.panel_changePass.Size = new System.Drawing.Size(449, 274);
            this.panel_changePass.TabIndex = 5;
            // 
            // textBox_oldPass
            // 
            this.textBox_oldPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_oldPass.Location = new System.Drawing.Point(156, 14);
            this.textBox_oldPass.Name = "textBox_oldPass";
            this.textBox_oldPass.Size = new System.Drawing.Size(278, 27);
            this.textBox_oldPass.TabIndex = 2;
            this.textBox_oldPass.UseSystemPasswordChar = true;
            this.textBox_oldPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_oldPass_KeyDown);
            // 
            // panel_open
            // 
            this.panel_open.Controls.Add(this.materialButton_ok);
            this.panel_open.Controls.Add(this.materialLabel_newPass);
            this.panel_open.Controls.Add(this.textBox_rePass);
            this.panel_open.Controls.Add(this.textBox_newPass);
            this.panel_open.Controls.Add(this.materialLabel1);
            this.panel_open.Location = new System.Drawing.Point(3, 62);
            this.panel_open.Name = "panel_open";
            this.panel_open.Size = new System.Drawing.Size(443, 209);
            this.panel_open.TabIndex = 9;
            // 
            // materialButton_ok
            // 
            this.materialButton_ok.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton_ok.Depth = 0;
            this.materialButton_ok.DrawShadows = true;
            this.materialButton_ok.HighEmphasis = true;
            this.materialButton_ok.Icon = null;
            this.materialButton_ok.Location = new System.Drawing.Point(294, 141);
            this.materialButton_ok.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton_ok.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton_ok.Name = "materialButton_ok";
            this.materialButton_ok.Size = new System.Drawing.Size(95, 36);
            this.materialButton_ok.TabIndex = 9;
            this.materialButton_ok.Text = "Xác Nhận";
            this.materialButton_ok.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton_ok.UseAccentColor = false;
            this.materialButton_ok.UseVisualStyleBackColor = true;
            this.materialButton_ok.Click += new System.EventHandler(this.materialButton_ok_Click);
            // 
            // materialLabel_newPass
            // 
            this.materialLabel_newPass.AutoSize = true;
            this.materialLabel_newPass.Depth = 0;
            this.materialLabel_newPass.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel_newPass.Location = new System.Drawing.Point(13, 0);
            this.materialLabel_newPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel_newPass.Name = "materialLabel_newPass";
            this.materialLabel_newPass.Size = new System.Drawing.Size(102, 19);
            this.materialLabel_newPass.TabIndex = 1;
            this.materialLabel_newPass.Text = "Password Mới";
            // 
            // textBox_rePass
            // 
            this.textBox_rePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_rePass.Location = new System.Drawing.Point(16, 105);
            this.textBox_rePass.Name = "textBox_rePass";
            this.textBox_rePass.Size = new System.Drawing.Size(415, 27);
            this.textBox_rePass.TabIndex = 5;
            this.textBox_rePass.UseSystemPasswordChar = true;
            // 
            // textBox_newPass
            // 
            this.textBox_newPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_newPass.Location = new System.Drawing.Point(16, 33);
            this.textBox_newPass.Name = "textBox_newPass";
            this.textBox_newPass.Size = new System.Drawing.Size(415, 27);
            this.textBox_newPass.TabIndex = 3;
            this.textBox_newPass.UseSystemPasswordChar = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(13, 72);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(134, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Nhập lại Password";
            // 
            // materialLabel_pass
            // 
            this.materialLabel_pass.AutoSize = true;
            this.materialLabel_pass.Depth = 0;
            this.materialLabel_pass.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel_pass.Location = new System.Drawing.Point(16, 17);
            this.materialLabel_pass.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel_pass.Name = "materialLabel_pass";
            this.materialLabel_pass.Size = new System.Drawing.Size(94, 19);
            this.materialLabel_pass.TabIndex = 0;
            this.materialLabel_pass.Text = "Password Cũ";
            // 
            // materialButton_changePass
            // 
            this.materialButton_changePass.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton_changePass.Depth = 0;
            this.materialButton_changePass.DrawShadows = true;
            this.materialButton_changePass.HighEmphasis = true;
            this.materialButton_changePass.Icon = null;
            this.materialButton_changePass.Location = new System.Drawing.Point(12, 329);
            this.materialButton_changePass.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton_changePass.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton_changePass.Name = "materialButton_changePass";
            this.materialButton_changePass.Size = new System.Drawing.Size(123, 36);
            this.materialButton_changePass.TabIndex = 6;
            this.materialButton_changePass.Text = "Đổi Mật Khẩu";
            this.materialButton_changePass.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton_changePass.UseAccentColor = false;
            this.materialButton_changePass.UseVisualStyleBackColor = true;
            this.materialButton_changePass.Click += new System.EventHandler(this.materialButton_changePass_Click);
            // 
            // materialLabel_username
            // 
            this.materialLabel_username.AutoSize = true;
            this.materialLabel_username.Depth = 0;
            this.materialLabel_username.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel_username.Location = new System.Drawing.Point(9, 277);
            this.materialLabel_username.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel_username.Name = "materialLabel_username";
            this.materialLabel_username.Size = new System.Drawing.Size(74, 19);
            this.materialLabel_username.TabIndex = 7;
            this.materialLabel_username.Text = "Tài Khoản";
            // 
            // materialButton_exit
            // 
            this.materialButton_exit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton_exit.Depth = 0;
            this.materialButton_exit.DrawShadows = true;
            this.materialButton_exit.HighEmphasis = true;
            this.materialButton_exit.Icon = null;
            this.materialButton_exit.Location = new System.Drawing.Point(194, 329);
            this.materialButton_exit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton_exit.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton_exit.Name = "materialButton_exit";
            this.materialButton_exit.Size = new System.Drawing.Size(52, 36);
            this.materialButton_exit.TabIndex = 10;
            this.materialButton_exit.Text = "Exit";
            this.materialButton_exit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton_exit.UseAccentColor = false;
            this.materialButton_exit.UseVisualStyleBackColor = true;
            this.materialButton_exit.Click += new System.EventHandler(this.materialButton_exit_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_name.Location = new System.Drawing.Point(144, 227);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(193, 24);
            this.textBox_name.TabIndex = 10;
            // 
            // textBox_username
            // 
            this.textBox_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_username.Location = new System.Drawing.Point(144, 274);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(193, 24);
            this.textBox_username.TabIndex = 11;
            // 
            // settingBossForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 654);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.materialButton_exit);
            this.Controls.Add(this.materialLabel_username);
            this.Controls.Add(this.materialButton_changePass);
            this.Controls.Add(this.panel_changePass);
            this.Controls.Add(this.circularPicturebox_avatar);
            this.Controls.Add(this.materialLabel_name);
            this.Name = "settingBossForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.settingBossForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.circularPicturebox_avatar)).EndInit();
            this.panel_changePass.ResumeLayout(false);
            this.panel_changePass.PerformLayout();
            this.panel_open.ResumeLayout(false);
            this.panel_open.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel_name;
        private circularPicturebox circularPicturebox_avatar;
        private System.Windows.Forms.Panel panel_changePass;
        private MaterialSkin.Controls.MaterialButton materialButton_ok;
        private System.Windows.Forms.TextBox textBox_rePass;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TextBox textBox_newPass;
        private System.Windows.Forms.TextBox textBox_oldPass;
        private MaterialSkin.Controls.MaterialLabel materialLabel_newPass;
        private MaterialSkin.Controls.MaterialLabel materialLabel_pass;
        private MaterialSkin.Controls.MaterialButton materialButton_changePass;
        private MaterialSkin.Controls.MaterialLabel materialLabel_username;
        private System.Windows.Forms.Panel panel_open;
        private MaterialSkin.Controls.MaterialButton materialButton_exit;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_username;
    }
}