
namespace Parking_Lot_Project
{
    partial class inforMotorForm
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
            this.label_status = new System.Windows.Forms.Label();
            this.dateTimePicker_rental = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_timeEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_timeStart = new System.Windows.Forms.DateTimePicker();
            this.comboBox_typeCustomer = new System.Windows.Forms.ComboBox();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.pictureBox_motor = new System.Windows.Forms.PictureBox();
            this.pictureBox_user = new System.Windows.Forms.PictureBox();
            this.textBox_plate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_motor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_user)).BeginInit();
            this.SuspendLayout();
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.BackColor = System.Drawing.Color.Transparent;
            this.label_status.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.ForeColor = System.Drawing.Color.White;
            this.label_status.Location = new System.Drawing.Point(26, 19);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(124, 27);
            this.label_status.TabIndex = 58;
            this.label_status.Text = "Tình Trạng: ";
            // 
            // dateTimePicker_rental
            // 
            this.dateTimePicker_rental.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";
            this.dateTimePicker_rental.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_rental.Location = new System.Drawing.Point(250, 232);
            this.dateTimePicker_rental.Name = "dateTimePicker_rental";
            this.dateTimePicker_rental.Size = new System.Drawing.Size(243, 22);
            this.dateTimePicker_rental.TabIndex = 57;
            // 
            // dateTimePicker_timeEnd
            // 
            this.dateTimePicker_timeEnd.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";
            this.dateTimePicker_timeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_timeEnd.Location = new System.Drawing.Point(769, 175);
            this.dateTimePicker_timeEnd.Name = "dateTimePicker_timeEnd";
            this.dateTimePicker_timeEnd.Size = new System.Drawing.Size(261, 22);
            this.dateTimePicker_timeEnd.TabIndex = 55;
            // 
            // dateTimePicker_timeStart
            // 
            this.dateTimePicker_timeStart.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";
            this.dateTimePicker_timeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_timeStart.Location = new System.Drawing.Point(250, 121);
            this.dateTimePicker_timeStart.Name = "dateTimePicker_timeStart";
            this.dateTimePicker_timeStart.Size = new System.Drawing.Size(243, 22);
            this.dateTimePicker_timeStart.TabIndex = 54;
            // 
            // comboBox_typeCustomer
            // 
            this.comboBox_typeCustomer.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_typeCustomer.FormattingEnabled = true;
            this.comboBox_typeCustomer.Items.AddRange(new object[] {
            "PASSENGER CUSTOMERS",
            "RENT BY DAY",
            "RENT BY WEEK",
            "RENT BY MONTH",
            "RENT BY YEAR"});
            this.comboBox_typeCustomer.Location = new System.Drawing.Point(250, 172);
            this.comboBox_typeCustomer.Name = "comboBox_typeCustomer";
            this.comboBox_typeCustomer.Size = new System.Drawing.Size(243, 27);
            this.comboBox_typeCustomer.TabIndex = 53;
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(769, 123);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(137, 22);
            this.textBox_price.TabIndex = 47;
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(250, 78);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(261, 22);
            this.textBox_id.TabIndex = 43;
            // 
            // pictureBox_motor
            // 
            this.pictureBox_motor.Location = new System.Drawing.Point(769, 294);
            this.pictureBox_motor.Name = "pictureBox_motor";
            this.pictureBox_motor.Size = new System.Drawing.Size(261, 124);
            this.pictureBox_motor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_motor.TabIndex = 52;
            this.pictureBox_motor.TabStop = false;
            // 
            // pictureBox_user
            // 
            this.pictureBox_user.Location = new System.Drawing.Point(250, 291);
            this.pictureBox_user.Name = "pictureBox_user";
            this.pictureBox_user.Size = new System.Drawing.Size(261, 124);
            this.pictureBox_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_user.TabIndex = 49;
            this.pictureBox_user.TabStop = false;
            // 
            // textBox_plate
            // 
            this.textBox_plate.Location = new System.Drawing.Point(769, 424);
            this.textBox_plate.Name = "textBox_plate";
            this.textBox_plate.Size = new System.Drawing.Size(261, 22);
            this.textBox_plate.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 27);
            this.label1.TabIndex = 60;
            this.label1.Text = "Thời Gian Gửi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 27);
            this.label2.TabIndex = 61;
            this.label2.Text = "Loại Khách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 27);
            this.label3.TabIndex = 62;
            this.label3.Text = "Thời Hạn Thuê";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(30, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 27);
            this.label4.TabIndex = 63;
            this.label4.Text = "Hình Xe Gửi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(623, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 27);
            this.label5.TabIndex = 64;
            this.label5.Text = "Hình Xe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(589, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 27);
            this.label6.TabIndex = 65;
            this.label6.Text = "Thời Gian Trả";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(607, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 27);
            this.label7.TabIndex = 66;
            this.label7.Text = "Tiền Gửi Xe";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(30, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 27);
            this.label8.TabIndex = 67;
            this.label8.Text = "Mã Thẻ Xe";
            // 
            // inforMotorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1100, 493);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_plate);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.dateTimePicker_rental);
            this.Controls.Add(this.dateTimePicker_timeEnd);
            this.Controls.Add(this.dateTimePicker_timeStart);
            this.Controls.Add(this.comboBox_typeCustomer);
            this.Controls.Add(this.pictureBox_motor);
            this.Controls.Add(this.pictureBox_user);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.textBox_id);
            this.Name = "inforMotorForm";
            this.Text = "inforMotorForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_motor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label_status;
        public System.Windows.Forms.DateTimePicker dateTimePicker_rental;
        public System.Windows.Forms.DateTimePicker dateTimePicker_timeEnd;
        public System.Windows.Forms.DateTimePicker dateTimePicker_timeStart;
        public System.Windows.Forms.ComboBox comboBox_typeCustomer;
        public System.Windows.Forms.PictureBox pictureBox_motor;
        public System.Windows.Forms.PictureBox pictureBox_user;
        public System.Windows.Forms.TextBox textBox_price;
        public System.Windows.Forms.TextBox textBox_id;
        public System.Windows.Forms.TextBox textBox_plate;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
    }
}