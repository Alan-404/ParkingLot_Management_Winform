
namespace Parking_Lot_Project
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.panel_title = new System.Windows.Forms.Panel();
            this.label_darkID = new System.Windows.Forms.Label();
            this.label_welcome = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.panel_shadow = new System.Windows.Forms.Panel();
            this.panel_Desktop = new System.Windows.Forms.Panel();
            this.label_date = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.timer_getDateAndTime = new System.Windows.Forms.Timer(this.components);
            this.pictureBox_main = new System.Windows.Forms.PictureBox();
            this.iconButton_exit = new FontAwesome.Sharp.IconButton();
            this.iconButton_child = new FontAwesome.Sharp.IconButton();
            this.iconButton_spec = new FontAwesome.Sharp.IconButton();
            this.iconButton_shift = new FontAwesome.Sharp.IconButton();
            this.iconButton_customer = new FontAwesome.Sharp.IconButton();
            this.iconButton_work = new FontAwesome.Sharp.IconButton();
            this.iconButton_infor = new FontAwesome.Sharp.IconButton();
            this.iconButton_Dashboard = new FontAwesome.Sharp.IconButton();
            this.circularPicturebox_avatar = new Parking_Lot_Project.circularPicturebox();
            this.circularPicturebox1 = new Parking_Lot_Project.circularPicturebox();
            this.panel_menu.SuspendLayout();
            this.panel_logo.SuspendLayout();
            this.panel_title.SuspendLayout();
            this.panel_Desktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPicturebox_avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPicturebox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.Indigo;
            this.panel_menu.Controls.Add(this.iconButton_spec);
            this.panel_menu.Controls.Add(this.iconButton_shift);
            this.panel_menu.Controls.Add(this.iconButton_customer);
            this.panel_menu.Controls.Add(this.iconButton_work);
            this.panel_menu.Controls.Add(this.iconButton_infor);
            this.panel_menu.Controls.Add(this.iconButton_Dashboard);
            this.panel_menu.Controls.Add(this.panel_logo);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(337, 821);
            this.panel_menu.TabIndex = 0;
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.Indigo;
            this.panel_logo.Controls.Add(this.circularPicturebox1);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(337, 114);
            this.panel_logo.TabIndex = 1;
            // 
            // panel_title
            // 
            this.panel_title.BackColor = System.Drawing.Color.Indigo;
            this.panel_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_title.Controls.Add(this.circularPicturebox_avatar);
            this.panel_title.Controls.Add(this.label_darkID);
            this.panel_title.Controls.Add(this.label_welcome);
            this.panel_title.Controls.Add(this.iconButton_exit);
            this.panel_title.Controls.Add(this.label_title);
            this.panel_title.Controls.Add(this.iconButton_child);
            this.panel_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_title.Location = new System.Drawing.Point(337, 0);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(1587, 65);
            this.panel_title.TabIndex = 1;
            this.panel_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_title_MouseDown);
            // 
            // label_darkID
            // 
            this.label_darkID.AutoSize = true;
            this.label_darkID.Location = new System.Drawing.Point(687, 31);
            this.label_darkID.Name = "label_darkID";
            this.label_darkID.Size = new System.Drawing.Size(46, 17);
            this.label_darkID.TabIndex = 4;
            this.label_darkID.Text = "label1";
            // 
            // label_welcome
            // 
            this.label_welcome.AutoSize = true;
            this.label_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_welcome.ForeColor = System.Drawing.Color.Gold;
            this.label_welcome.Location = new System.Drawing.Point(559, 19);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(0, 29);
            this.label_welcome.TabIndex = 3;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.DeepPink;
            this.label_title.Location = new System.Drawing.Point(56, 19);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(64, 25);
            this.label_title.TabIndex = 2;
            this.label_title.Text = "Home";
            // 
            // panel_shadow
            // 
            this.panel_shadow.BackColor = System.Drawing.Color.Indigo;
            this.panel_shadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_shadow.Location = new System.Drawing.Point(337, 65);
            this.panel_shadow.Name = "panel_shadow";
            this.panel_shadow.Size = new System.Drawing.Size(1587, 9);
            this.panel_shadow.TabIndex = 2;
            // 
            // panel_Desktop
            // 
            this.panel_Desktop.BackColor = System.Drawing.Color.Indigo;
            this.panel_Desktop.Controls.Add(this.label_date);
            this.panel_Desktop.Controls.Add(this.label_time);
            this.panel_Desktop.Controls.Add(this.pictureBox_main);
            this.panel_Desktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Desktop.ForeColor = System.Drawing.Color.Black;
            this.panel_Desktop.Location = new System.Drawing.Point(337, 74);
            this.panel_Desktop.Name = "panel_Desktop";
            this.panel_Desktop.Size = new System.Drawing.Size(1587, 747);
            this.panel_Desktop.TabIndex = 3;
            this.panel_Desktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Desktop_Paint);
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_date.Location = new System.Drawing.Point(540, 408);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(79, 29);
            this.label_date.TabIndex = 2;
            this.label_date.Text = "label2";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time.Location = new System.Drawing.Point(612, 345);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(138, 51);
            this.label_time.TabIndex = 1;
            this.label_time.Text = "label1";
            // 
            // timer_getDateAndTime
            // 
            this.timer_getDateAndTime.Interval = 1000;
            this.timer_getDateAndTime.Tick += new System.EventHandler(this.timer_getDateAndTime_Tick);
            // 
            // pictureBox_main
            // 
            this.pictureBox_main.Image = global::Parking_Lot_Project.Properties.Resources.dcfc0d53b43830766dabcbcad94f17aa;
            this.pictureBox_main.Location = new System.Drawing.Point(691, 170);
            this.pictureBox_main.Name = "pictureBox_main";
            this.pictureBox_main.Size = new System.Drawing.Size(183, 147);
            this.pictureBox_main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_main.TabIndex = 0;
            this.pictureBox_main.TabStop = false;
            // 
            // iconButton_exit
            // 
            this.iconButton_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_exit.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            this.iconButton_exit.IconColor = System.Drawing.Color.Red;
            this.iconButton_exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_exit.Location = new System.Drawing.Point(1494, 6);
            this.iconButton_exit.Name = "iconButton_exit";
            this.iconButton_exit.Size = new System.Drawing.Size(55, 52);
            this.iconButton_exit.TabIndex = 0;
            this.iconButton_exit.UseVisualStyleBackColor = true;
            this.iconButton_exit.Click += new System.EventHandler(this.iconButton_exit_Click);
            // 
            // iconButton_child
            // 
            this.iconButton_child.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_child.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconButton_child.IconColor = System.Drawing.Color.Fuchsia;
            this.iconButton_child.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_child.Location = new System.Drawing.Point(6, 12);
            this.iconButton_child.Name = "iconButton_child";
            this.iconButton_child.Size = new System.Drawing.Size(44, 44);
            this.iconButton_child.TabIndex = 2;
            this.iconButton_child.UseVisualStyleBackColor = true;
            this.iconButton_child.Click += new System.EventHandler(this.iconButton_child_Click);
            // 
            // iconButton_spec
            // 
            this.iconButton_spec.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_spec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_spec.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_spec.ForeColor = System.Drawing.Color.White;
            this.iconButton_spec.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.iconButton_spec.IconColor = System.Drawing.Color.White;
            this.iconButton_spec.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_spec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_spec.Location = new System.Drawing.Point(0, 439);
            this.iconButton_spec.Name = "iconButton_spec";
            this.iconButton_spec.Size = new System.Drawing.Size(337, 65);
            this.iconButton_spec.TabIndex = 6;
            this.iconButton_spec.Text = "Specialize";
            this.iconButton_spec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_spec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_spec.UseVisualStyleBackColor = true;
            this.iconButton_spec.Click += new System.EventHandler(this.iconButton_spec_Click);
            // 
            // iconButton_shift
            // 
            this.iconButton_shift.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_shift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_shift.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_shift.ForeColor = System.Drawing.Color.White;
            this.iconButton_shift.IconChar = FontAwesome.Sharp.IconChar.Ioxhost;
            this.iconButton_shift.IconColor = System.Drawing.Color.White;
            this.iconButton_shift.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_shift.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_shift.Location = new System.Drawing.Point(0, 374);
            this.iconButton_shift.Name = "iconButton_shift";
            this.iconButton_shift.Size = new System.Drawing.Size(337, 65);
            this.iconButton_shift.TabIndex = 5;
            this.iconButton_shift.Text = "Shift";
            this.iconButton_shift.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_shift.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_shift.UseVisualStyleBackColor = true;
            this.iconButton_shift.Click += new System.EventHandler(this.iconButton_shift_Click);
            // 
            // iconButton_customer
            // 
            this.iconButton_customer.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_customer.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_customer.ForeColor = System.Drawing.Color.White;
            this.iconButton_customer.IconChar = FontAwesome.Sharp.IconChar.Instagram;
            this.iconButton_customer.IconColor = System.Drawing.Color.White;
            this.iconButton_customer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_customer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_customer.Location = new System.Drawing.Point(0, 309);
            this.iconButton_customer.Name = "iconButton_customer";
            this.iconButton_customer.Size = new System.Drawing.Size(337, 65);
            this.iconButton_customer.TabIndex = 4;
            this.iconButton_customer.Text = "Customer";
            this.iconButton_customer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_customer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_customer.UseVisualStyleBackColor = true;
            this.iconButton_customer.Click += new System.EventHandler(this.iconButton_customer_Click);
            // 
            // iconButton_work
            // 
            this.iconButton_work.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_work.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_work.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_work.ForeColor = System.Drawing.Color.White;
            this.iconButton_work.IconChar = FontAwesome.Sharp.IconChar.Code;
            this.iconButton_work.IconColor = System.Drawing.Color.White;
            this.iconButton_work.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_work.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_work.Location = new System.Drawing.Point(0, 244);
            this.iconButton_work.Name = "iconButton_work";
            this.iconButton_work.Size = new System.Drawing.Size(337, 65);
            this.iconButton_work.TabIndex = 3;
            this.iconButton_work.Text = "Work";
            this.iconButton_work.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_work.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_work.UseVisualStyleBackColor = true;
            this.iconButton_work.Click += new System.EventHandler(this.iconButton_work_Click);
            // 
            // iconButton_infor
            // 
            this.iconButton_infor.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_infor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_infor.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_infor.ForeColor = System.Drawing.Color.White;
            this.iconButton_infor.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.iconButton_infor.IconColor = System.Drawing.Color.White;
            this.iconButton_infor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_infor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_infor.Location = new System.Drawing.Point(0, 179);
            this.iconButton_infor.Name = "iconButton_infor";
            this.iconButton_infor.Size = new System.Drawing.Size(337, 65);
            this.iconButton_infor.TabIndex = 2;
            this.iconButton_infor.Text = "Setting";
            this.iconButton_infor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_infor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_infor.UseVisualStyleBackColor = true;
            this.iconButton_infor.Click += new System.EventHandler(this.iconButton_infor_Click);
            // 
            // iconButton_Dashboard
            // 
            this.iconButton_Dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_Dashboard.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_Dashboard.ForeColor = System.Drawing.Color.White;
            this.iconButton_Dashboard.IconChar = FontAwesome.Sharp.IconChar.Desktop;
            this.iconButton_Dashboard.IconColor = System.Drawing.Color.White;
            this.iconButton_Dashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_Dashboard.Location = new System.Drawing.Point(0, 114);
            this.iconButton_Dashboard.Name = "iconButton_Dashboard";
            this.iconButton_Dashboard.Size = new System.Drawing.Size(337, 65);
            this.iconButton_Dashboard.TabIndex = 1;
            this.iconButton_Dashboard.Text = "Dashboard";
            this.iconButton_Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_Dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_Dashboard.UseVisualStyleBackColor = true;
            this.iconButton_Dashboard.Click += new System.EventHandler(this.iconButton_Dashboard_Click);
            // 
            // circularPicturebox_avatar
            // 
            this.circularPicturebox_avatar.Location = new System.Drawing.Point(433, 12);
            this.circularPicturebox_avatar.Name = "circularPicturebox_avatar";
            this.circularPicturebox_avatar.Size = new System.Drawing.Size(60, 46);
            this.circularPicturebox_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circularPicturebox_avatar.TabIndex = 3;
            this.circularPicturebox_avatar.TabStop = false;
            // 
            // circularPicturebox1
            // 
            this.circularPicturebox1.Image = global::Parking_Lot_Project.Properties.Resources.dcfc0d53b43830766dabcbcad94f17aa;
            this.circularPicturebox1.Location = new System.Drawing.Point(102, 3);
            this.circularPicturebox1.Name = "circularPicturebox1";
            this.circularPicturebox1.Size = new System.Drawing.Size(128, 111);
            this.circularPicturebox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circularPicturebox1.TabIndex = 3;
            this.circularPicturebox1.TabStop = false;
            this.circularPicturebox1.Click += new System.EventHandler(this.circularPicturebox1_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 821);
            this.Controls.Add(this.panel_Desktop);
            this.Controls.Add(this.panel_shadow);
            this.Controls.Add(this.panel_title);
            this.Controls.Add(this.panel_menu);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainForm";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.panel_menu.ResumeLayout(false);
            this.panel_logo.ResumeLayout(false);
            this.panel_title.ResumeLayout(false);
            this.panel_title.PerformLayout();
            this.panel_Desktop.ResumeLayout(false);
            this.panel_Desktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPicturebox_avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPicturebox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Panel panel_logo;
        private FontAwesome.Sharp.IconButton iconButton_Dashboard;
        private System.Windows.Forms.Panel panel_title;
        private System.Windows.Forms.Label label_title;
        private FontAwesome.Sharp.IconButton iconButton_child;
        private System.Windows.Forms.Panel panel_shadow;
        private System.Windows.Forms.Panel panel_Desktop;
        private System.Windows.Forms.PictureBox pictureBox_main;
        private System.Windows.Forms.Timer timer_getDateAndTime;
        public System.Windows.Forms.Label label_welcome;
        private FontAwesome.Sharp.IconButton iconButton_work;
        private FontAwesome.Sharp.IconButton iconButton_infor;
        public FontAwesome.Sharp.IconButton iconButton_exit;
        public System.Windows.Forms.Label label_darkID;
        public System.Windows.Forms.Label label_date;
        public System.Windows.Forms.Label label_time;
        private FontAwesome.Sharp.IconButton iconButton_customer;
        public circularPicturebox circularPicturebox_avatar;
        private FontAwesome.Sharp.IconButton iconButton_shift;
        private FontAwesome.Sharp.IconButton iconButton_spec;
        private circularPicturebox circularPicturebox1;
    }
}