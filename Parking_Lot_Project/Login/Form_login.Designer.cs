
namespace Parking_Lot_Project
{
    partial class Form_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_login));
            this.label_account = new System.Windows.Forms.Label();
            this.label_userName = new System.Windows.Forms.Label();
            this.label_pass = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.linkLabel_register = new System.Windows.Forms.LinkLabel();
            this.materialTextBox_userName = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox_pass = new MaterialSkin.Controls.MaterialTextBox();
            this.button_exit = new System.Windows.Forms.Button();
            this.linkLabel_forgotPass = new System.Windows.Forms.LinkLabel();
            this.panel_move = new System.Windows.Forms.Panel();
            this.circularPicturebox_logo = new Parking_Lot_Project.circularPicturebox();
            ((System.ComponentModel.ISupportInitialize)(this.circularPicturebox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label_account
            // 
            this.label_account.AutoSize = true;
            this.label_account.BackColor = System.Drawing.Color.Transparent;
            this.label_account.Font = new System.Drawing.Font("Stencil", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_account.ForeColor = System.Drawing.Color.DimGray;
            this.label_account.Location = new System.Drawing.Point(88, 177);
            this.label_account.Name = "label_account";
            this.label_account.Size = new System.Drawing.Size(319, 46);
            this.label_account.TabIndex = 0;
            this.label_account.Text = "Account Login";
            // 
            // label_userName
            // 
            this.label_userName.AutoSize = true;
            this.label_userName.BackColor = System.Drawing.Color.Transparent;
            this.label_userName.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_userName.ForeColor = System.Drawing.Color.Gray;
            this.label_userName.Location = new System.Drawing.Point(12, 230);
            this.label_userName.Name = "label_userName";
            this.label_userName.Size = new System.Drawing.Size(148, 30);
            this.label_userName.TabIndex = 1;
            this.label_userName.Text = "Username: ";
            // 
            // label_pass
            // 
            this.label_pass.AutoSize = true;
            this.label_pass.BackColor = System.Drawing.Color.Transparent;
            this.label_pass.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pass.ForeColor = System.Drawing.Color.Gray;
            this.label_pass.Location = new System.Drawing.Point(12, 344);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(156, 30);
            this.label_pass.TabIndex = 2;
            this.label_pass.Text = "Password: ";
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.Gold;
            this.button_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_login.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.ForeColor = System.Drawing.Color.White;
            this.button_login.Location = new System.Drawing.Point(253, 477);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(221, 76);
            this.button_login.TabIndex = 5;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // linkLabel_register
            // 
            this.linkLabel_register.AutoSize = true;
            this.linkLabel_register.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel_register.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_register.LinkColor = System.Drawing.Color.Goldenrod;
            this.linkLabel_register.Location = new System.Drawing.Point(380, 556);
            this.linkLabel_register.Name = "linkLabel_register";
            this.linkLabel_register.Size = new System.Drawing.Size(94, 28);
            this.linkLabel_register.TabIndex = 7;
            this.linkLabel_register.TabStop = true;
            this.linkLabel_register.Text = "Register";
            this.linkLabel_register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_register_LinkClicked);
            // 
            // materialTextBox_userName
            // 
            this.materialTextBox_userName.BackColor = System.Drawing.Color.White;
            this.materialTextBox_userName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox_userName.Depth = 0;
            this.materialTextBox_userName.Font = new System.Drawing.Font("Roboto", 12F);
            this.materialTextBox_userName.Location = new System.Drawing.Point(16, 260);
            this.materialTextBox_userName.MaxLength = 50;
            this.materialTextBox_userName.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox_userName.Multiline = false;
            this.materialTextBox_userName.Name = "materialTextBox_userName";
            this.materialTextBox_userName.Size = new System.Drawing.Size(458, 50);
            this.materialTextBox_userName.TabIndex = 10;
            this.materialTextBox_userName.Text = "";
            // 
            // materialTextBox_pass
            // 
            this.materialTextBox_pass.BackColor = System.Drawing.Color.White;
            this.materialTextBox_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox_pass.Depth = 0;
            this.materialTextBox_pass.Font = new System.Drawing.Font("Roboto", 12F);
            this.materialTextBox_pass.Location = new System.Drawing.Point(16, 374);
            this.materialTextBox_pass.MaxLength = 50;
            this.materialTextBox_pass.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox_pass.Multiline = false;
            this.materialTextBox_pass.Name = "materialTextBox_pass";
            this.materialTextBox_pass.Password = true;
            this.materialTextBox_pass.Size = new System.Drawing.Size(458, 50);
            this.materialTextBox_pass.TabIndex = 12;
            this.materialTextBox_pass.Text = "";
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.Orange;
            this.button_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_exit.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.ForeColor = System.Drawing.Color.White;
            this.button_exit.Location = new System.Drawing.Point(16, 477);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(232, 76);
            this.button_exit.TabIndex = 13;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // linkLabel_forgotPass
            // 
            this.linkLabel_forgotPass.AutoSize = true;
            this.linkLabel_forgotPass.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel_forgotPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel_forgotPass.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_forgotPass.LinkColor = System.Drawing.Color.Goldenrod;
            this.linkLabel_forgotPass.Location = new System.Drawing.Point(330, 442);
            this.linkLabel_forgotPass.Name = "linkLabel_forgotPass";
            this.linkLabel_forgotPass.Size = new System.Drawing.Size(144, 22);
            this.linkLabel_forgotPass.TabIndex = 14;
            this.linkLabel_forgotPass.TabStop = true;
            this.linkLabel_forgotPass.Text = "Forgot Password";
            // 
            // panel_move
            // 
            this.panel_move.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_move.Location = new System.Drawing.Point(0, 0);
            this.panel_move.Name = "panel_move";
            this.panel_move.Size = new System.Drawing.Size(487, 43);
            this.panel_move.TabIndex = 15;
            this.panel_move.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_move_MouseDown);
            // 
            // circularPicturebox_logo
            // 
            this.circularPicturebox_logo.Image = ((System.Drawing.Image)(resources.GetObject("circularPicturebox_logo.Image")));
            this.circularPicturebox_logo.Location = new System.Drawing.Point(185, 49);
            this.circularPicturebox_logo.Name = "circularPicturebox_logo";
            this.circularPicturebox_logo.Size = new System.Drawing.Size(145, 125);
            this.circularPicturebox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circularPicturebox_logo.TabIndex = 16;
            this.circularPicturebox_logo.TabStop = false;
            // 
            // Form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(487, 605);
            this.Controls.Add(this.circularPicturebox_logo);
            this.Controls.Add(this.panel_move);
            this.Controls.Add(this.linkLabel_forgotPass);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.materialTextBox_pass);
            this.Controls.Add(this.materialTextBox_userName);
            this.Controls.Add(this.linkLabel_register);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.label_pass);
            this.Controls.Add(this.label_userName);
            this.Controls.Add(this.label_account);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.circularPicturebox_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_account;
        private System.Windows.Forms.Label label_userName;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.LinkLabel linkLabel_register;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox_userName;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox_pass;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.LinkLabel linkLabel_forgotPass;
        private System.Windows.Forms.Panel panel_move;
        private circularPicturebox circularPicturebox_logo;
    }
}

