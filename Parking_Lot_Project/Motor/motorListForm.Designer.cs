
namespace Parking_Lot_Project
{
    partial class motorListForm
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
            this.tabControl_bike = new System.Windows.Forms.TabControl();
            this.tabPage_park = new System.Windows.Forms.TabPage();
            this.textBox_plate = new System.Windows.Forms.TextBox();
            this.numericUpDown_add = new System.Windows.Forms.NumericUpDown();
            this.materialButton_editBike = new MaterialSkin.Controls.MaterialButton();
            this.dateTimePicker_timeStart = new System.Windows.Forms.DateTimePicker();
            this.pictureBox_imgMotor = new System.Windows.Forms.PictureBox();
            this.pictureBox_imgUser = new System.Windows.Forms.PictureBox();
            this.comboBox_typeCustomer = new System.Windows.Forms.ComboBox();
            this.label_imgUser = new System.Windows.Forms.Label();
            this.label_type = new System.Windows.Forms.Label();
            this.label_imgBike = new System.Windows.Forms.Label();
            this.label_timeStart = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.dataGridView_motor = new System.Windows.Forms.DataGridView();
            this.label_listMotor = new System.Windows.Forms.Label();
            this.tabPage_parked = new System.Windows.Forms.TabPage();
            this.label_dark = new System.Windows.Forms.Label();
            this.radioButton_timeEnd = new System.Windows.Forms.RadioButton();
            this.radioButton_rental = new System.Windows.Forms.RadioButton();
            this.radioButton_timeStart = new System.Windows.Forms.RadioButton();
            this.dateTimePicker_searchParked = new System.Windows.Forms.DateTimePicker();
            this.label_logo = new System.Windows.Forms.Label();
            this.dataGridView_parked = new System.Windows.Forms.DataGridView();
            this.button_printListWorker = new System.Windows.Forms.Button();
            this.tabControl_bike.SuspendLayout();
            this.tabPage_park.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_imgMotor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_imgUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_motor)).BeginInit();
            this.tabPage_parked.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_parked)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_bike
            // 
            this.tabControl_bike.Controls.Add(this.tabPage_park);
            this.tabControl_bike.Controls.Add(this.tabPage_parked);
            this.tabControl_bike.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_bike.Location = new System.Drawing.Point(12, 12);
            this.tabControl_bike.Name = "tabControl_bike";
            this.tabControl_bike.SelectedIndex = 0;
            this.tabControl_bike.Size = new System.Drawing.Size(1673, 717);
            this.tabControl_bike.TabIndex = 1;
            // 
            // tabPage_park
            // 
            this.tabPage_park.BackColor = System.Drawing.Color.Orange;
            this.tabPage_park.Controls.Add(this.textBox_plate);
            this.tabPage_park.Controls.Add(this.numericUpDown_add);
            this.tabPage_park.Controls.Add(this.materialButton_editBike);
            this.tabPage_park.Controls.Add(this.dateTimePicker_timeStart);
            this.tabPage_park.Controls.Add(this.pictureBox_imgMotor);
            this.tabPage_park.Controls.Add(this.pictureBox_imgUser);
            this.tabPage_park.Controls.Add(this.comboBox_typeCustomer);
            this.tabPage_park.Controls.Add(this.label_imgUser);
            this.tabPage_park.Controls.Add(this.label_type);
            this.tabPage_park.Controls.Add(this.label_imgBike);
            this.tabPage_park.Controls.Add(this.label_timeStart);
            this.tabPage_park.Controls.Add(this.label_id);
            this.tabPage_park.Controls.Add(this.textBox_id);
            this.tabPage_park.Controls.Add(this.dataGridView_motor);
            this.tabPage_park.Controls.Add(this.label_listMotor);
            this.tabPage_park.Location = new System.Drawing.Point(4, 31);
            this.tabPage_park.Name = "tabPage_park";
            this.tabPage_park.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_park.Size = new System.Drawing.Size(1561, 682);
            this.tabPage_park.TabIndex = 0;
            this.tabPage_park.Text = "Danh Sách Xe Đạp Đang Gửi";
            // 
            // textBox_plate
            // 
            this.textBox_plate.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_plate.Location = new System.Drawing.Point(616, 237);
            this.textBox_plate.Name = "textBox_plate";
            this.textBox_plate.Size = new System.Drawing.Size(243, 26);
            this.textBox_plate.TabIndex = 22;
            // 
            // numericUpDown_add
            // 
            this.numericUpDown_add.Location = new System.Drawing.Point(1214, 132);
            this.numericUpDown_add.Name = "numericUpDown_add";
            this.numericUpDown_add.Size = new System.Drawing.Size(120, 28);
            this.numericUpDown_add.TabIndex = 21;
            // 
            // materialButton_editBike
            // 
            this.materialButton_editBike.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton_editBike.Depth = 0;
            this.materialButton_editBike.DrawShadows = true;
            this.materialButton_editBike.HighEmphasis = true;
            this.materialButton_editBike.Icon = null;
            this.materialButton_editBike.Location = new System.Drawing.Point(901, 180);
            this.materialButton_editBike.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton_editBike.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton_editBike.Name = "materialButton_editBike";
            this.materialButton_editBike.Size = new System.Drawing.Size(131, 36);
            this.materialButton_editBike.TabIndex = 15;
            this.materialButton_editBike.Text = "Sửa Thông Tin";
            this.materialButton_editBike.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton_editBike.UseAccentColor = false;
            this.materialButton_editBike.UseVisualStyleBackColor = true;
            this.materialButton_editBike.Click += new System.EventHandler(this.materialButton_editBike_Click);
            // 
            // dateTimePicker_timeStart
            // 
            this.dateTimePicker_timeStart.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";
            this.dateTimePicker_timeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_timeStart.Location = new System.Drawing.Point(901, 132);
            this.dateTimePicker_timeStart.Name = "dateTimePicker_timeStart";
            this.dateTimePicker_timeStart.Size = new System.Drawing.Size(307, 28);
            this.dateTimePicker_timeStart.TabIndex = 14;
            // 
            // pictureBox_imgMotor
            // 
            this.pictureBox_imgMotor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_imgMotor.Location = new System.Drawing.Point(616, 141);
            this.pictureBox_imgMotor.Name = "pictureBox_imgMotor";
            this.pictureBox_imgMotor.Size = new System.Drawing.Size(187, 75);
            this.pictureBox_imgMotor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_imgMotor.TabIndex = 12;
            this.pictureBox_imgMotor.TabStop = false;
            // 
            // pictureBox_imgUser
            // 
            this.pictureBox_imgUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_imgUser.Location = new System.Drawing.Point(224, 141);
            this.pictureBox_imgUser.Name = "pictureBox_imgUser";
            this.pictureBox_imgUser.Size = new System.Drawing.Size(187, 122);
            this.pictureBox_imgUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_imgUser.TabIndex = 11;
            this.pictureBox_imgUser.TabStop = false;
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
            this.comboBox_typeCustomer.Location = new System.Drawing.Point(616, 92);
            this.comboBox_typeCustomer.Name = "comboBox_typeCustomer";
            this.comboBox_typeCustomer.Size = new System.Drawing.Size(243, 27);
            this.comboBox_typeCustomer.TabIndex = 10;
            // 
            // label_imgUser
            // 
            this.label_imgUser.AutoSize = true;
            this.label_imgUser.ForeColor = System.Drawing.Color.White;
            this.label_imgUser.Location = new System.Drawing.Point(19, 141);
            this.label_imgUser.Name = "label_imgUser";
            this.label_imgUser.Size = new System.Drawing.Size(135, 22);
            this.label_imgUser.TabIndex = 8;
            this.label_imgUser.Text = "Ảnh Người Gửi";
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.ForeColor = System.Drawing.Color.White;
            this.label_type.Location = new System.Drawing.Point(457, 95);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(107, 22);
            this.label_type.TabIndex = 7;
            this.label_type.Text = "Kiểu Khách";
            // 
            // label_imgBike
            // 
            this.label_imgBike.AutoSize = true;
            this.label_imgBike.ForeColor = System.Drawing.Color.White;
            this.label_imgBike.Location = new System.Drawing.Point(457, 132);
            this.label_imgBike.Name = "label_imgBike";
            this.label_imgBike.Size = new System.Drawing.Size(72, 22);
            this.label_imgBike.TabIndex = 6;
            this.label_imgBike.Text = "Ảnh Xe";
            // 
            // label_timeStart
            // 
            this.label_timeStart.AutoSize = true;
            this.label_timeStart.ForeColor = System.Drawing.Color.White;
            this.label_timeStart.Location = new System.Drawing.Point(897, 95);
            this.label_timeStart.Name = "label_timeStart";
            this.label_timeStart.Size = new System.Drawing.Size(126, 22);
            this.label_timeStart.TabIndex = 5;
            this.label_timeStart.Text = "Thời Gian Gửi";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.ForeColor = System.Drawing.Color.White;
            this.label_id.Location = new System.Drawing.Point(19, 95);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(99, 22);
            this.label_id.TabIndex = 4;
            this.label_id.Text = "Mã Thẻ Xe";
            // 
            // textBox_id
            // 
            this.textBox_id.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_id.Location = new System.Drawing.Point(174, 95);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(237, 26);
            this.textBox_id.TabIndex = 3;
            // 
            // dataGridView_motor
            // 
            this.dataGridView_motor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_motor.Location = new System.Drawing.Point(6, 293);
            this.dataGridView_motor.Name = "dataGridView_motor";
            this.dataGridView_motor.RowHeadersWidth = 51;
            this.dataGridView_motor.RowTemplate.Height = 24;
            this.dataGridView_motor.Size = new System.Drawing.Size(1412, 383);
            this.dataGridView_motor.TabIndex = 1;
            this.dataGridView_motor.DoubleClick += new System.EventHandler(this.dataGridView_motor_DoubleClick);
            // 
            // label_listMotor
            // 
            this.label_listMotor.AutoSize = true;
            this.label_listMotor.Font = new System.Drawing.Font("Sitka Text", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_listMotor.ForeColor = System.Drawing.Color.White;
            this.label_listMotor.Location = new System.Drawing.Point(399, 3);
            this.label_listMotor.Name = "label_listMotor";
            this.label_listMotor.Size = new System.Drawing.Size(560, 55);
            this.label_listMotor.TabIndex = 0;
            this.label_listMotor.Text = "Danh Sách Xe Máy Đang Gửi";
            this.label_listMotor.Click += new System.EventHandler(this.label_listMotor_Click);
            // 
            // tabPage_parked
            // 
            this.tabPage_parked.BackColor = System.Drawing.Color.SlateBlue;
            this.tabPage_parked.Controls.Add(this.button_printListWorker);
            this.tabPage_parked.Controls.Add(this.label_dark);
            this.tabPage_parked.Controls.Add(this.radioButton_timeEnd);
            this.tabPage_parked.Controls.Add(this.radioButton_rental);
            this.tabPage_parked.Controls.Add(this.radioButton_timeStart);
            this.tabPage_parked.Controls.Add(this.dateTimePicker_searchParked);
            this.tabPage_parked.Controls.Add(this.label_logo);
            this.tabPage_parked.Controls.Add(this.dataGridView_parked);
            this.tabPage_parked.Location = new System.Drawing.Point(4, 31);
            this.tabPage_parked.Name = "tabPage_parked";
            this.tabPage_parked.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_parked.Size = new System.Drawing.Size(1665, 682);
            this.tabPage_parked.TabIndex = 1;
            this.tabPage_parked.Text = "Danh Sách Xe Đạp Đã Gửi";
            // 
            // label_dark
            // 
            this.label_dark.AutoSize = true;
            this.label_dark.Location = new System.Drawing.Point(1080, 47);
            this.label_dark.Name = "label_dark";
            this.label_dark.Size = new System.Drawing.Size(62, 22);
            this.label_dark.TabIndex = 6;
            this.label_dark.Text = "label1";
            // 
            // radioButton_timeEnd
            // 
            this.radioButton_timeEnd.AutoSize = true;
            this.radioButton_timeEnd.ForeColor = System.Drawing.Color.White;
            this.radioButton_timeEnd.Location = new System.Drawing.Point(414, 120);
            this.radioButton_timeEnd.Name = "radioButton_timeEnd";
            this.radioButton_timeEnd.Size = new System.Drawing.Size(145, 26);
            this.radioButton_timeEnd.TabIndex = 5;
            this.radioButton_timeEnd.TabStop = true;
            this.radioButton_timeEnd.Text = "Thời Gian Trả";
            this.radioButton_timeEnd.UseVisualStyleBackColor = true;
            // 
            // radioButton_rental
            // 
            this.radioButton_rental.AutoSize = true;
            this.radioButton_rental.ForeColor = System.Drawing.Color.White;
            this.radioButton_rental.Location = new System.Drawing.Point(223, 120);
            this.radioButton_rental.Name = "radioButton_rental";
            this.radioButton_rental.Size = new System.Drawing.Size(140, 26);
            this.radioButton_rental.TabIndex = 4;
            this.radioButton_rental.TabStop = true;
            this.radioButton_rental.Text = "Thời Hạn Trả";
            this.radioButton_rental.UseVisualStyleBackColor = true;
            // 
            // radioButton_timeStart
            // 
            this.radioButton_timeStart.AutoSize = true;
            this.radioButton_timeStart.ForeColor = System.Drawing.Color.White;
            this.radioButton_timeStart.Location = new System.Drawing.Point(6, 120);
            this.radioButton_timeStart.Name = "radioButton_timeStart";
            this.radioButton_timeStart.Size = new System.Drawing.Size(147, 26);
            this.radioButton_timeStart.TabIndex = 3;
            this.radioButton_timeStart.TabStop = true;
            this.radioButton_timeStart.Text = "Thời Gian Gửi";
            this.radioButton_timeStart.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_searchParked
            // 
            this.dateTimePicker_searchParked.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker_searchParked.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_searchParked.Location = new System.Drawing.Point(6, 75);
            this.dateTimePicker_searchParked.Name = "dateTimePicker_searchParked";
            this.dateTimePicker_searchParked.Size = new System.Drawing.Size(190, 28);
            this.dateTimePicker_searchParked.TabIndex = 2;
            this.dateTimePicker_searchParked.ValueChanged += new System.EventHandler(this.dateTimePicker_searchParked_ValueChanged);
            // 
            // label_logo
            // 
            this.label_logo.AutoSize = true;
            this.label_logo.Font = new System.Drawing.Font("Sitka Text", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_logo.ForeColor = System.Drawing.Color.White;
            this.label_logo.Location = new System.Drawing.Point(571, 14);
            this.label_logo.Name = "label_logo";
            this.label_logo.Size = new System.Drawing.Size(370, 55);
            this.label_logo.TabIndex = 1;
            this.label_logo.Text = "Danh Sách Xe Máy";
            this.label_logo.Click += new System.EventHandler(this.label_logo_Click);
            // 
            // dataGridView_parked
            // 
            this.dataGridView_parked.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_parked.Location = new System.Drawing.Point(6, 166);
            this.dataGridView_parked.Name = "dataGridView_parked";
            this.dataGridView_parked.RowHeadersWidth = 51;
            this.dataGridView_parked.RowTemplate.Height = 24;
            this.dataGridView_parked.Size = new System.Drawing.Size(1640, 443);
            this.dataGridView_parked.TabIndex = 0;
            this.dataGridView_parked.DoubleClick += new System.EventHandler(this.dataGridView_parked_DoubleClick);
            // 
            // button_printListWorker
            // 
            this.button_printListWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_printListWorker.Location = new System.Drawing.Point(6, 615);
            this.button_printListWorker.Name = "button_printListWorker";
            this.button_printListWorker.Size = new System.Drawing.Size(156, 49);
            this.button_printListWorker.TabIndex = 8;
            this.button_printListWorker.Text = "Print";
            this.button_printListWorker.UseVisualStyleBackColor = true;
            this.button_printListWorker.Click += new System.EventHandler(this.button_printListWorker_Click);
            // 
            // motorListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1710, 741);
            this.Controls.Add(this.tabControl_bike);
            this.Name = "motorListForm";
            this.Text = "motorListForm";
            this.Load += new System.EventHandler(this.motorListForm_Load);
            this.tabControl_bike.ResumeLayout(false);
            this.tabPage_park.ResumeLayout(false);
            this.tabPage_park.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_imgMotor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_imgUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_motor)).EndInit();
            this.tabPage_parked.ResumeLayout(false);
            this.tabPage_parked.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_parked)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_bike;
        private System.Windows.Forms.TabPage tabPage_park;
        private System.Windows.Forms.NumericUpDown numericUpDown_add;
        private MaterialSkin.Controls.MaterialButton materialButton_editBike;
        private System.Windows.Forms.DateTimePicker dateTimePicker_timeStart;
        private System.Windows.Forms.PictureBox pictureBox_imgMotor;
        private System.Windows.Forms.PictureBox pictureBox_imgUser;
        private System.Windows.Forms.ComboBox comboBox_typeCustomer;
        private System.Windows.Forms.Label label_imgUser;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.Label label_imgBike;
        private System.Windows.Forms.Label label_timeStart;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.DataGridView dataGridView_motor;
        private System.Windows.Forms.Label label_listMotor;
        private System.Windows.Forms.TabPage tabPage_parked;
        private System.Windows.Forms.RadioButton radioButton_timeEnd;
        private System.Windows.Forms.RadioButton radioButton_rental;
        private System.Windows.Forms.RadioButton radioButton_timeStart;
        private System.Windows.Forms.DateTimePicker dateTimePicker_searchParked;
        private System.Windows.Forms.Label label_logo;
        private System.Windows.Forms.DataGridView dataGridView_parked;
        private System.Windows.Forms.TextBox textBox_plate;
        public System.Windows.Forms.Label label_dark;
        private System.Windows.Forms.Button button_printListWorker;
    }
}