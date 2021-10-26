
namespace Parking_Lot_Project
{
    partial class entranceForm
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
            this.label_typeCustomer = new System.Windows.Forms.Label();
            this.label_pic = new System.Windows.Forms.Label();
            this.label_pic2 = new System.Windows.Forms.Label();
            this.button_getPic1 = new System.Windows.Forms.Button();
            this.button_getPic2 = new System.Windows.Forms.Button();
            this.button_addTransport = new System.Windows.Forms.Button();
            this.label_plateNumber = new System.Windows.Forms.Label();
            this.textBox_plateNumber = new System.Windows.Forms.TextBox();
            this.comboBox_typeCustomer = new System.Windows.Forms.ComboBox();
            this.pictureBox_getPic2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_getPic1 = new System.Windows.Forms.PictureBox();
            this.numericUpDown_add = new System.Windows.Forms.NumericUpDown();
            this.label_count = new System.Windows.Forms.Label();
            this.label_darrk = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_getPic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_getPic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_add)).BeginInit();
            this.SuspendLayout();
            // 
            // label_typeCustomer
            // 
            this.label_typeCustomer.AutoSize = true;
            this.label_typeCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_typeCustomer.ForeColor = System.Drawing.Color.White;
            this.label_typeCustomer.Location = new System.Drawing.Point(636, 12);
            this.label_typeCustomer.Name = "label_typeCustomer";
            this.label_typeCustomer.Size = new System.Drawing.Size(107, 25);
            this.label_typeCustomer.TabIndex = 2;
            this.label_typeCustomer.Text = "Loại khách";
            // 
            // label_pic
            // 
            this.label_pic.AutoSize = true;
            this.label_pic.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pic.ForeColor = System.Drawing.Color.White;
            this.label_pic.Location = new System.Drawing.Point(21, 21);
            this.label_pic.Name = "label_pic";
            this.label_pic.Size = new System.Drawing.Size(97, 32);
            this.label_pic.TabIndex = 4;
            this.label_pic.Text = "Hình 1";
            // 
            // label_pic2
            // 
            this.label_pic2.AutoSize = true;
            this.label_pic2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pic2.ForeColor = System.Drawing.Color.White;
            this.label_pic2.Location = new System.Drawing.Point(21, 393);
            this.label_pic2.Name = "label_pic2";
            this.label_pic2.Size = new System.Drawing.Size(97, 32);
            this.label_pic2.TabIndex = 5;
            this.label_pic2.Text = "Hình 2";
            // 
            // button_getPic1
            // 
            this.button_getPic1.BackColor = System.Drawing.Color.Yellow;
            this.button_getPic1.Location = new System.Drawing.Point(27, 244);
            this.button_getPic1.Name = "button_getPic1";
            this.button_getPic1.Size = new System.Drawing.Size(120, 41);
            this.button_getPic1.TabIndex = 6;
            this.button_getPic1.Text = "Lấy hình";
            this.button_getPic1.UseVisualStyleBackColor = false;
            this.button_getPic1.Click += new System.EventHandler(this.button_getPic1_Click);
            // 
            // button_getPic2
            // 
            this.button_getPic2.BackColor = System.Drawing.Color.Yellow;
            this.button_getPic2.Location = new System.Drawing.Point(27, 610);
            this.button_getPic2.Name = "button_getPic2";
            this.button_getPic2.Size = new System.Drawing.Size(129, 41);
            this.button_getPic2.TabIndex = 7;
            this.button_getPic2.Text = "Lấy hình";
            this.button_getPic2.UseVisualStyleBackColor = false;
            this.button_getPic2.Click += new System.EventHandler(this.button_getPic2_Click);
            // 
            // button_addTransport
            // 
            this.button_addTransport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_addTransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addTransport.Location = new System.Drawing.Point(641, 149);
            this.button_addTransport.Name = "button_addTransport";
            this.button_addTransport.Size = new System.Drawing.Size(256, 61);
            this.button_addTransport.TabIndex = 8;
            this.button_addTransport.Text = "Thêm xe";
            this.button_addTransport.UseVisualStyleBackColor = false;
            this.button_addTransport.Click += new System.EventHandler(this.button_addTransport_Click);
            // 
            // label_plateNumber
            // 
            this.label_plateNumber.AutoSize = true;
            this.label_plateNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_plateNumber.ForeColor = System.Drawing.Color.White;
            this.label_plateNumber.Location = new System.Drawing.Point(22, 298);
            this.label_plateNumber.Name = "label_plateNumber";
            this.label_plateNumber.Size = new System.Drawing.Size(125, 29);
            this.label_plateNumber.TabIndex = 9;
            this.label_plateNumber.Text = "Biển số xe";
            // 
            // textBox_plateNumber
            // 
            this.textBox_plateNumber.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_plateNumber.Location = new System.Drawing.Point(224, 301);
            this.textBox_plateNumber.Name = "textBox_plateNumber";
            this.textBox_plateNumber.Size = new System.Drawing.Size(303, 43);
            this.textBox_plateNumber.TabIndex = 10;
            // 
            // comboBox_typeCustomer
            // 
            this.comboBox_typeCustomer.FormattingEnabled = true;
            this.comboBox_typeCustomer.Items.AddRange(new object[] {
            "PASSENGER CUSTOMERS",
            "RENT BY DAY",
            "RENT BY WEEK",
            "RENT BY MONTH",
            "RENT BY YEAR"});
            this.comboBox_typeCustomer.Location = new System.Drawing.Point(641, 53);
            this.comboBox_typeCustomer.Name = "comboBox_typeCustomer";
            this.comboBox_typeCustomer.Size = new System.Drawing.Size(240, 24);
            this.comboBox_typeCustomer.TabIndex = 3;
            // 
            // pictureBox_getPic2
            // 
            this.pictureBox_getPic2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_getPic2.Location = new System.Drawing.Point(224, 378);
            this.pictureBox_getPic2.Name = "pictureBox_getPic2";
            this.pictureBox_getPic2.Size = new System.Drawing.Size(386, 273);
            this.pictureBox_getPic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_getPic2.TabIndex = 1;
            this.pictureBox_getPic2.TabStop = false;
            // 
            // pictureBox_getPic1
            // 
            this.pictureBox_getPic1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_getPic1.Location = new System.Drawing.Point(224, 12);
            this.pictureBox_getPic1.Name = "pictureBox_getPic1";
            this.pictureBox_getPic1.Size = new System.Drawing.Size(386, 273);
            this.pictureBox_getPic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_getPic1.TabIndex = 0;
            this.pictureBox_getPic1.TabStop = false;
            // 
            // numericUpDown_add
            // 
            this.numericUpDown_add.Location = new System.Drawing.Point(641, 94);
            this.numericUpDown_add.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown_add.Name = "numericUpDown_add";
            this.numericUpDown_add.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_add.TabIndex = 11;
            this.numericUpDown_add.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_count.ForeColor = System.Drawing.Color.White;
            this.label_count.Location = new System.Drawing.Point(634, 238);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(224, 36);
            this.label_count.TabIndex = 12;
            this.label_count.Text = "Số Chỗ Còn Dư";
            // 
            // label_darrk
            // 
            this.label_darrk.AutoSize = true;
            this.label_darrk.Location = new System.Drawing.Point(1102, 12);
            this.label_darrk.Name = "label_darrk";
            this.label_darrk.Size = new System.Drawing.Size(46, 17);
            this.label_darrk.TabIndex = 13;
            this.label_darrk.Text = "label1";
            // 
            // entranceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1227, 707);
            this.Controls.Add(this.label_darrk);
            this.Controls.Add(this.label_count);
            this.Controls.Add(this.numericUpDown_add);
            this.Controls.Add(this.textBox_plateNumber);
            this.Controls.Add(this.label_plateNumber);
            this.Controls.Add(this.button_addTransport);
            this.Controls.Add(this.button_getPic2);
            this.Controls.Add(this.button_getPic1);
            this.Controls.Add(this.label_pic2);
            this.Controls.Add(this.label_pic);
            this.Controls.Add(this.comboBox_typeCustomer);
            this.Controls.Add(this.label_typeCustomer);
            this.Controls.Add(this.pictureBox_getPic2);
            this.Controls.Add(this.pictureBox_getPic1);
            this.Name = "entranceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "entranceForm";
            this.Load += new System.EventHandler(this.entranceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_getPic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_getPic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_add)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_getPic1;
        private System.Windows.Forms.PictureBox pictureBox_getPic2;
        private System.Windows.Forms.Label label_typeCustomer;
        private System.Windows.Forms.Button button_getPic1;
        private System.Windows.Forms.Button button_getPic2;
        public System.Windows.Forms.Button button_addTransport;
        public System.Windows.Forms.Label label_pic;
        public System.Windows.Forms.Label label_pic2;
        public System.Windows.Forms.Label label_plateNumber;
        public System.Windows.Forms.TextBox textBox_plateNumber;
        private System.Windows.Forms.ComboBox comboBox_typeCustomer;
        private System.Windows.Forms.NumericUpDown numericUpDown_add;
        public System.Windows.Forms.Label label_count;
        private System.Windows.Forms.Label label_darrk;
    }
}