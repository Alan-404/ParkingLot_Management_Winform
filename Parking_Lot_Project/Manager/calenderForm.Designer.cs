
namespace Parking_Lot_Project
{
    partial class calenderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calenderForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPreviours = new System.Windows.Forms.Button();
            this.button_sun = new System.Windows.Forms.Button();
            this.button_sat = new System.Windows.Forms.Button();
            this.button_fri = new System.Windows.Forms.Button();
            this.button_thurs = new System.Windows.Forms.Button();
            this.button_wed = new System.Windows.Forms.Button();
            this.button_mon = new System.Windows.Forms.Button();
            this.button_tues = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDown_notify = new System.Windows.Forms.NumericUpDown();
            this.checkBox_notify = new System.Windows.Forms.CheckBox();
            this.btnToDay = new System.Windows.Forms.Button();
            this.dtpkDate = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_calender = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_notify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Controls.Add(this.btnPreviours);
            this.panel2.Controls.Add(this.button_sun);
            this.panel2.Controls.Add(this.button_sat);
            this.panel2.Controls.Add(this.button_fri);
            this.panel2.Controls.Add(this.button_thurs);
            this.panel2.Controls.Add(this.button_wed);
            this.panel2.Controls.Add(this.button_mon);
            this.panel2.Controls.Add(this.button_tues);
            this.panel2.Location = new System.Drawing.Point(13, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(820, 56);
            this.panel2.TabIndex = 4;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Yellow;
            this.btnNext.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(690, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(114, 42);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "Tháng Sau";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPreviours
            // 
            this.btnPreviours.BackColor = System.Drawing.Color.Purple;
            this.btnPreviours.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviours.ForeColor = System.Drawing.Color.White;
            this.btnPreviours.Location = new System.Drawing.Point(-1, 3);
            this.btnPreviours.Name = "btnPreviours";
            this.btnPreviours.Size = new System.Drawing.Size(125, 42);
            this.btnPreviours.TabIndex = 8;
            this.btnPreviours.Text = "Tháng Trước ";
            this.btnPreviours.UseVisualStyleBackColor = false;
            this.btnPreviours.Click += new System.EventHandler(this.btnPreviours_Click);
            // 
            // button_sun
            // 
            this.button_sun.BackColor = System.Drawing.Color.Magenta;
            this.button_sun.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sun.ForeColor = System.Drawing.Color.White;
            this.button_sun.Location = new System.Drawing.Point(609, 3);
            this.button_sun.Name = "button_sun";
            this.button_sun.Size = new System.Drawing.Size(75, 42);
            this.button_sun.TabIndex = 7;
            this.button_sun.Text = "CN";
            this.button_sun.UseVisualStyleBackColor = false;
            // 
            // button_sat
            // 
            this.button_sat.BackColor = System.Drawing.Color.Blue;
            this.button_sat.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sat.ForeColor = System.Drawing.Color.White;
            this.button_sat.Location = new System.Drawing.Point(528, 3);
            this.button_sat.Name = "button_sat";
            this.button_sat.Size = new System.Drawing.Size(75, 42);
            this.button_sat.TabIndex = 2;
            this.button_sat.Text = "Thứ 7";
            this.button_sat.UseVisualStyleBackColor = false;
            // 
            // button_fri
            // 
            this.button_fri.BackColor = System.Drawing.Color.Aqua;
            this.button_fri.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_fri.ForeColor = System.Drawing.Color.White;
            this.button_fri.Location = new System.Drawing.Point(447, 3);
            this.button_fri.Name = "button_fri";
            this.button_fri.Size = new System.Drawing.Size(75, 42);
            this.button_fri.TabIndex = 3;
            this.button_fri.Text = "Thứ 6";
            this.button_fri.UseVisualStyleBackColor = false;
            // 
            // button_thurs
            // 
            this.button_thurs.BackColor = System.Drawing.Color.Lime;
            this.button_thurs.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_thurs.ForeColor = System.Drawing.Color.White;
            this.button_thurs.Location = new System.Drawing.Point(366, 3);
            this.button_thurs.Name = "button_thurs";
            this.button_thurs.Size = new System.Drawing.Size(75, 42);
            this.button_thurs.TabIndex = 4;
            this.button_thurs.Text = "Thứ 5";
            this.button_thurs.UseVisualStyleBackColor = false;
            // 
            // button_wed
            // 
            this.button_wed.BackColor = System.Drawing.Color.Yellow;
            this.button_wed.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_wed.ForeColor = System.Drawing.Color.Black;
            this.button_wed.Location = new System.Drawing.Point(285, 3);
            this.button_wed.Name = "button_wed";
            this.button_wed.Size = new System.Drawing.Size(75, 42);
            this.button_wed.TabIndex = 5;
            this.button_wed.Text = "Thứ 4";
            this.button_wed.UseVisualStyleBackColor = false;
            // 
            // button_mon
            // 
            this.button_mon.BackColor = System.Drawing.Color.Red;
            this.button_mon.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_mon.ForeColor = System.Drawing.Color.White;
            this.button_mon.Location = new System.Drawing.Point(123, 3);
            this.button_mon.Name = "button_mon";
            this.button_mon.Size = new System.Drawing.Size(75, 42);
            this.button_mon.TabIndex = 6;
            this.button_mon.Text = "Thứ 2";
            this.button_mon.UseVisualStyleBackColor = false;
            // 
            // button_tues
            // 
            this.button_tues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_tues.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_tues.ForeColor = System.Drawing.Color.White;
            this.button_tues.Location = new System.Drawing.Point(204, 3);
            this.button_tues.Name = "button_tues";
            this.button_tues.Size = new System.Drawing.Size(75, 42);
            this.button_tues.TabIndex = 1;
            this.button_tues.Text = "Thứ 3";
            this.button_tues.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericUpDown_notify);
            this.panel1.Controls.Add(this.checkBox_notify);
            this.panel1.Controls.Add(this.btnToDay);
            this.panel1.Controls.Add(this.dtpkDate);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 53);
            this.panel1.TabIndex = 3;
            // 
            // numericUpDown_notify
            // 
            this.numericUpDown_notify.Location = new System.Drawing.Point(124, 16);
            this.numericUpDown_notify.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.numericUpDown_notify.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_notify.Name = "numericUpDown_notify";
            this.numericUpDown_notify.Size = new System.Drawing.Size(61, 28);
            this.numericUpDown_notify.TabIndex = 10;
            this.numericUpDown_notify.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBox_notify
            // 
            this.checkBox_notify.AutoSize = true;
            this.checkBox_notify.Location = new System.Drawing.Point(18, 16);
            this.checkBox_notify.Name = "checkBox_notify";
            this.checkBox_notify.Size = new System.Drawing.Size(98, 22);
            this.checkBox_notify.TabIndex = 9;
            this.checkBox_notify.Text = "Thông Báo";
            this.checkBox_notify.UseVisualStyleBackColor = true;
            // 
            // btnToDay
            // 
            this.btnToDay.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnToDay.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToDay.ForeColor = System.Drawing.Color.White;
            this.btnToDay.Location = new System.Drawing.Point(529, 3);
            this.btnToDay.Name = "btnToDay";
            this.btnToDay.Size = new System.Drawing.Size(110, 47);
            this.btnToDay.TabIndex = 0;
            this.btnToDay.Text = "Hôm Nay";
            this.btnToDay.UseVisualStyleBackColor = false;
            this.btnToDay.Click += new System.EventHandler(this.btnToDay_Click);
            // 
            // dtpkDate
            // 
            this.dtpkDate.Location = new System.Drawing.Point(255, 13);
            this.dtpkDate.Name = "dtpkDate";
            this.dtpkDate.Size = new System.Drawing.Size(268, 28);
            this.dtpkDate.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Parking_Lot_Project.Properties.Resources.cropped_pastel_rainbow_transparent_23;
            this.pictureBox1.Location = new System.Drawing.Point(703, 364);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel_calender
            // 
            this.panel_calender.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_calender.BackgroundImage")));
            this.panel_calender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_calender.Location = new System.Drawing.Point(136, 135);
            this.panel_calender.Name = "panel_calender";
            this.panel_calender.Size = new System.Drawing.Size(561, 369);
            this.panel_calender.TabIndex = 5;
            // 
            // calenderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(848, 542);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel_calender);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "calenderForm";
            this.Text = "Back";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_notify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_calender;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPreviours;
        private System.Windows.Forms.Button button_sun;
        private System.Windows.Forms.Button button_sat;
        private System.Windows.Forms.Button button_fri;
        private System.Windows.Forms.Button button_thurs;
        private System.Windows.Forms.Button button_wed;
        private System.Windows.Forms.Button button_mon;
        private System.Windows.Forms.Button button_tues;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericUpDown_notify;
        private System.Windows.Forms.CheckBox checkBox_notify;
        private System.Windows.Forms.Button btnToDay;
        private System.Windows.Forms.DateTimePicker dtpkDate;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}