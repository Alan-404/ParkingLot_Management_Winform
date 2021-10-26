
namespace Parking_Lot_Project
{
    partial class inforCarForm
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
            this.textBox_plate = new System.Windows.Forms.TextBox();
            this.label_status = new System.Windows.Forms.Label();
            this.dateTimePicker_rental = new System.Windows.Forms.DateTimePicker();
            this.materialLabel_rental = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimePicker_timeEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_timeStart = new System.Windows.Forms.DateTimePicker();
            this.comboBox_typeCustomer = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel_type = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel_image = new MaterialSkin.Controls.MaterialLabel();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.materialLabel_price = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel_timeEnd = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel_timeStart = new MaterialSkin.Controls.MaterialLabel();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.materialLabel_fullName = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox_motor = new System.Windows.Forms.PictureBox();
            this.pictureBox_user = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_motor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_user)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_plate
            // 
            this.textBox_plate.Location = new System.Drawing.Point(665, 417);
            this.textBox_plate.Name = "textBox_plate";
            this.textBox_plate.Size = new System.Drawing.Size(261, 22);
            this.textBox_plate.TabIndex = 77;
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.Location = new System.Drawing.Point(521, 28);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(124, 27);
            this.label_status.TabIndex = 76;
            this.label_status.Text = "Tình Trạng: ";
            // 
            // dateTimePicker_rental
            // 
            this.dateTimePicker_rental.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";
            this.dateTimePicker_rental.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_rental.Location = new System.Drawing.Point(237, 228);
            this.dateTimePicker_rental.Name = "dateTimePicker_rental";
            this.dateTimePicker_rental.Size = new System.Drawing.Size(243, 22);
            this.dateTimePicker_rental.TabIndex = 75;
            // 
            // materialLabel_rental
            // 
            this.materialLabel_rental.AutoSize = true;
            this.materialLabel_rental.Depth = 0;
            this.materialLabel_rental.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel_rental.Location = new System.Drawing.Point(64, 234);
            this.materialLabel_rental.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel_rental.Name = "materialLabel_rental";
            this.materialLabel_rental.Size = new System.Drawing.Size(106, 19);
            this.materialLabel_rental.TabIndex = 74;
            this.materialLabel_rental.Text = "Thời Hạn Thuê";
            // 
            // dateTimePicker_timeEnd
            // 
            this.dateTimePicker_timeEnd.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";
            this.dateTimePicker_timeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_timeEnd.Location = new System.Drawing.Point(665, 168);
            this.dateTimePicker_timeEnd.Name = "dateTimePicker_timeEnd";
            this.dateTimePicker_timeEnd.Size = new System.Drawing.Size(261, 22);
            this.dateTimePicker_timeEnd.TabIndex = 73;
            // 
            // dateTimePicker_timeStart
            // 
            this.dateTimePicker_timeStart.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";
            this.dateTimePicker_timeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_timeStart.Location = new System.Drawing.Point(237, 117);
            this.dateTimePicker_timeStart.Name = "dateTimePicker_timeStart";
            this.dateTimePicker_timeStart.Size = new System.Drawing.Size(243, 22);
            this.dateTimePicker_timeStart.TabIndex = 72;
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
            this.comboBox_typeCustomer.Location = new System.Drawing.Point(237, 168);
            this.comboBox_typeCustomer.Name = "comboBox_typeCustomer";
            this.comboBox_typeCustomer.Size = new System.Drawing.Size(243, 27);
            this.comboBox_typeCustomer.TabIndex = 71;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(523, 287);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(88, 19);
            this.materialLabel1.TabIndex = 69;
            this.materialLabel1.Text = "Hình Sau Xe";
            // 
            // materialLabel_type
            // 
            this.materialLabel_type.AutoSize = true;
            this.materialLabel_type.Depth = 0;
            this.materialLabel_type.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel_type.Location = new System.Drawing.Point(64, 173);
            this.materialLabel_type.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel_type.Name = "materialLabel_type";
            this.materialLabel_type.Size = new System.Drawing.Size(81, 19);
            this.materialLabel_type.TabIndex = 68;
            this.materialLabel_type.Text = "Loại Khách";
            // 
            // materialLabel_image
            // 
            this.materialLabel_image.AutoSize = true;
            this.materialLabel_image.Depth = 0;
            this.materialLabel_image.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel_image.Location = new System.Drawing.Point(64, 287);
            this.materialLabel_image.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel_image.Name = "materialLabel_image";
            this.materialLabel_image.Size = new System.Drawing.Size(102, 19);
            this.materialLabel_image.TabIndex = 66;
            this.materialLabel_image.Text = "Hình Trước Xe";
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(665, 116);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(137, 22);
            this.textBox_price.TabIndex = 65;
            // 
            // materialLabel_price
            // 
            this.materialLabel_price.AutoSize = true;
            this.materialLabel_price.Depth = 0;
            this.materialLabel_price.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel_price.Location = new System.Drawing.Point(523, 119);
            this.materialLabel_price.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel_price.Name = "materialLabel_price";
            this.materialLabel_price.Size = new System.Drawing.Size(83, 19);
            this.materialLabel_price.TabIndex = 64;
            this.materialLabel_price.Text = "Tiền Gửi Xe";
            // 
            // materialLabel_timeEnd
            // 
            this.materialLabel_timeEnd.AutoSize = true;
            this.materialLabel_timeEnd.Depth = 0;
            this.materialLabel_timeEnd.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel_timeEnd.Location = new System.Drawing.Point(523, 173);
            this.materialLabel_timeEnd.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel_timeEnd.Name = "materialLabel_timeEnd";
            this.materialLabel_timeEnd.Size = new System.Drawing.Size(98, 19);
            this.materialLabel_timeEnd.TabIndex = 63;
            this.materialLabel_timeEnd.Text = "Thời Gian Trả";
            // 
            // materialLabel_timeStart
            // 
            this.materialLabel_timeStart.AutoSize = true;
            this.materialLabel_timeStart.Depth = 0;
            this.materialLabel_timeStart.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel_timeStart.Location = new System.Drawing.Point(64, 119);
            this.materialLabel_timeStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel_timeStart.Name = "materialLabel_timeStart";
            this.materialLabel_timeStart.Size = new System.Drawing.Size(99, 19);
            this.materialLabel_timeStart.TabIndex = 62;
            this.materialLabel_timeStart.Text = "Thời Gian Gửi";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(237, 74);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(261, 22);
            this.textBox_id.TabIndex = 61;
            // 
            // materialLabel_fullName
            // 
            this.materialLabel_fullName.AutoSize = true;
            this.materialLabel_fullName.Depth = 0;
            this.materialLabel_fullName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel_fullName.Location = new System.Drawing.Point(64, 74);
            this.materialLabel_fullName.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel_fullName.Name = "materialLabel_fullName";
            this.materialLabel_fullName.Size = new System.Drawing.Size(110, 19);
            this.materialLabel_fullName.TabIndex = 60;
            this.materialLabel_fullName.Text = "Mã Thẻ Xe Đạp";
            // 
            // pictureBox_motor
            // 
            this.pictureBox_motor.Location = new System.Drawing.Point(665, 287);
            this.pictureBox_motor.Name = "pictureBox_motor";
            this.pictureBox_motor.Size = new System.Drawing.Size(261, 124);
            this.pictureBox_motor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_motor.TabIndex = 70;
            this.pictureBox_motor.TabStop = false;
            // 
            // pictureBox_user
            // 
            this.pictureBox_user.Location = new System.Drawing.Point(237, 287);
            this.pictureBox_user.Name = "pictureBox_user";
            this.pictureBox_user.Size = new System.Drawing.Size(261, 124);
            this.pictureBox_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_user.TabIndex = 67;
            this.pictureBox_user.TabStop = false;
            // 
            // inforCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(992, 500);
            this.Controls.Add(this.textBox_plate);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.dateTimePicker_rental);
            this.Controls.Add(this.materialLabel_rental);
            this.Controls.Add(this.dateTimePicker_timeEnd);
            this.Controls.Add(this.dateTimePicker_timeStart);
            this.Controls.Add(this.comboBox_typeCustomer);
            this.Controls.Add(this.pictureBox_motor);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialLabel_type);
            this.Controls.Add(this.pictureBox_user);
            this.Controls.Add(this.materialLabel_image);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.materialLabel_price);
            this.Controls.Add(this.materialLabel_timeEnd);
            this.Controls.Add(this.materialLabel_timeStart);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.materialLabel_fullName);
            this.Name = "inforCarForm";
            this.Text = "inforCarForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_motor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBox_plate;
        public System.Windows.Forms.Label label_status;
        public System.Windows.Forms.DateTimePicker dateTimePicker_rental;
        private MaterialSkin.Controls.MaterialLabel materialLabel_rental;
        public System.Windows.Forms.DateTimePicker dateTimePicker_timeEnd;
        public System.Windows.Forms.DateTimePicker dateTimePicker_timeStart;
        public System.Windows.Forms.ComboBox comboBox_typeCustomer;
        public System.Windows.Forms.PictureBox pictureBox_motor;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel_type;
        public System.Windows.Forms.PictureBox pictureBox_user;
        private MaterialSkin.Controls.MaterialLabel materialLabel_image;
        public System.Windows.Forms.TextBox textBox_price;
        private MaterialSkin.Controls.MaterialLabel materialLabel_price;
        private MaterialSkin.Controls.MaterialLabel materialLabel_timeEnd;
        private MaterialSkin.Controls.MaterialLabel materialLabel_timeStart;
        public System.Windows.Forms.TextBox textBox_id;
        private MaterialSkin.Controls.MaterialLabel materialLabel_fullName;
    }
}