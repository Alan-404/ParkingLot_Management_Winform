
namespace Parking_Lot_Project
{
    partial class contractForm
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
            this.tabControl_rent = new System.Windows.Forms.TabControl();
            this.tabPage_rent = new System.Windows.Forms.TabPage();
            this.panel_inforCustomer = new System.Windows.Forms.Panel();
            this.button_Customer = new System.Windows.Forms.Button();
            this.textBox_customer = new System.Windows.Forms.TextBox();
            this.label_idCus = new System.Windows.Forms.Label();
            this.panel_rent = new System.Windows.Forms.Panel();
            this.label_price = new System.Windows.Forms.Label();
            this.comboBox_select = new System.Windows.Forms.ComboBox();
            this.numericUpDown_get = new System.Windows.Forms.NumericUpDown();
            this.label_inforRent = new System.Windows.Forms.Label();
            this.materialButton_rent = new MaterialSkin.Controls.MaterialButton();
            this.label_pic = new System.Windows.Forms.Label();
            this.pictureBox_rent = new System.Windows.Forms.PictureBox();
            this.textBox_rent = new System.Windows.Forms.TextBox();
            this.label_idRent = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.pictureBox_trans = new System.Windows.Forms.PictureBox();
            this.button_up = new System.Windows.Forms.Button();
            this.dataGridView_rent = new System.Windows.Forms.DataGridView();
            this.label_listRent = new System.Windows.Forms.Label();
            this.tabPage_add = new System.Windows.Forms.TabPage();
            this.label_money = new System.Windows.Forms.Label();
            this.comboBox_typeCustomer = new System.Windows.Forms.ComboBox();
            this.comboBox_trans = new System.Windows.Forms.ComboBox();
            this.panel_trans = new System.Windows.Forms.Panel();
            this.panel_Customer = new System.Windows.Forms.Panel();
            this.numericUpDown_add = new System.Windows.Forms.NumericUpDown();
            this.materialButton_add = new MaterialSkin.Controls.MaterialButton();
            this.button_trans = new System.Windows.Forms.Button();
            this.textBox_trans = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.button_listCus = new System.Windows.Forms.Button();
            this.textBox_idCus = new System.Windows.Forms.TextBox();
            this.label_idCustomer = new System.Windows.Forms.Label();
            this.tabPage_contract = new System.Windows.Forms.TabPage();
            this.label_contract = new System.Windows.Forms.Label();
            this.dataGridView_rentalList = new System.Windows.Forms.DataGridView();
            this.materialButton_print = new MaterialSkin.Controls.MaterialButton();
            this.tabControl_rent.SuspendLayout();
            this.tabPage_rent.SuspendLayout();
            this.panel_rent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_get)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_rent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_trans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_rent)).BeginInit();
            this.tabPage_add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_add)).BeginInit();
            this.tabPage_contract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_rentalList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_rent
            // 
            this.tabControl_rent.Controls.Add(this.tabPage_rent);
            this.tabControl_rent.Controls.Add(this.tabPage_add);
            this.tabControl_rent.Controls.Add(this.tabPage_contract);
            this.tabControl_rent.Location = new System.Drawing.Point(12, 12);
            this.tabControl_rent.Name = "tabControl_rent";
            this.tabControl_rent.SelectedIndex = 0;
            this.tabControl_rent.Size = new System.Drawing.Size(1509, 717);
            this.tabControl_rent.TabIndex = 0;
            // 
            // tabPage_rent
            // 
            this.tabPage_rent.BackColor = System.Drawing.Color.PapayaWhip;
            this.tabPage_rent.Controls.Add(this.panel_inforCustomer);
            this.tabPage_rent.Controls.Add(this.button_Customer);
            this.tabPage_rent.Controls.Add(this.textBox_customer);
            this.tabPage_rent.Controls.Add(this.label_idCus);
            this.tabPage_rent.Controls.Add(this.panel_rent);
            this.tabPage_rent.Controls.Add(this.button_add);
            this.tabPage_rent.Controls.Add(this.pictureBox_trans);
            this.tabPage_rent.Controls.Add(this.button_up);
            this.tabPage_rent.Controls.Add(this.dataGridView_rent);
            this.tabPage_rent.Controls.Add(this.label_listRent);
            this.tabPage_rent.Location = new System.Drawing.Point(4, 25);
            this.tabPage_rent.Name = "tabPage_rent";
            this.tabPage_rent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_rent.Size = new System.Drawing.Size(1501, 688);
            this.tabPage_rent.TabIndex = 0;
            this.tabPage_rent.Text = "Cho Thuê Xe";
            // 
            // panel_inforCustomer
            // 
            this.panel_inforCustomer.Location = new System.Drawing.Point(900, 111);
            this.panel_inforCustomer.Name = "panel_inforCustomer";
            this.panel_inforCustomer.Size = new System.Drawing.Size(488, 522);
            this.panel_inforCustomer.TabIndex = 17;
            // 
            // button_Customer
            // 
            this.button_Customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_Customer.ForeColor = System.Drawing.Color.White;
            this.button_Customer.Location = new System.Drawing.Point(1087, 16);
            this.button_Customer.Name = "button_Customer";
            this.button_Customer.Size = new System.Drawing.Size(234, 34);
            this.button_Customer.TabIndex = 16;
            this.button_Customer.Text = "Danh Sách Khách Hàng";
            this.button_Customer.UseVisualStyleBackColor = false;
            this.button_Customer.Click += new System.EventHandler(this.button_Customer_Click);
            // 
            // textBox_customer
            // 
            this.textBox_customer.Location = new System.Drawing.Point(900, 65);
            this.textBox_customer.Name = "textBox_customer";
            this.textBox_customer.Size = new System.Drawing.Size(184, 22);
            this.textBox_customer.TabIndex = 15;
            this.textBox_customer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_customer_KeyDown);
            // 
            // label_idCus
            // 
            this.label_idCus.AutoSize = true;
            this.label_idCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_idCus.Location = new System.Drawing.Point(895, 25);
            this.label_idCus.Name = "label_idCus";
            this.label_idCus.Size = new System.Drawing.Size(154, 25);
            this.label_idCus.TabIndex = 14;
            this.label_idCus.Text = "Mã Khách Hàng";
            // 
            // panel_rent
            // 
            this.panel_rent.Controls.Add(this.label_price);
            this.panel_rent.Controls.Add(this.comboBox_select);
            this.panel_rent.Controls.Add(this.numericUpDown_get);
            this.panel_rent.Controls.Add(this.label_inforRent);
            this.panel_rent.Controls.Add(this.materialButton_rent);
            this.panel_rent.Controls.Add(this.label_pic);
            this.panel_rent.Controls.Add(this.pictureBox_rent);
            this.panel_rent.Controls.Add(this.textBox_rent);
            this.panel_rent.Controls.Add(this.label_idRent);
            this.panel_rent.Location = new System.Drawing.Point(442, 111);
            this.panel_rent.Name = "panel_rent";
            this.panel_rent.Size = new System.Drawing.Size(367, 511);
            this.panel_rent.TabIndex = 5;
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_price.Location = new System.Drawing.Point(22, 373);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(73, 25);
            this.label_price.TabIndex = 18;
            this.label_price.Text = "Giá Cả";
            // 
            // comboBox_select
            // 
            this.comboBox_select.FormattingEnabled = true;
            this.comboBox_select.Items.AddRange(new object[] {
            "RENT BY DAY",
            "RENT BY MONTH",
            "RENT BY YEAR"});
            this.comboBox_select.Location = new System.Drawing.Point(27, 297);
            this.comboBox_select.Name = "comboBox_select";
            this.comboBox_select.Size = new System.Drawing.Size(215, 24);
            this.comboBox_select.TabIndex = 20;
            this.comboBox_select.SelectedIndexChanged += new System.EventHandler(this.comboBox_select_SelectedIndexChanged);
            // 
            // numericUpDown_get
            // 
            this.numericUpDown_get.Location = new System.Drawing.Point(278, 298);
            this.numericUpDown_get.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_get.Name = "numericUpDown_get";
            this.numericUpDown_get.Size = new System.Drawing.Size(71, 22);
            this.numericUpDown_get.TabIndex = 19;
            this.numericUpDown_get.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_get.ValueChanged += new System.EventHandler(this.numericUpDown_get_ValueChanged);
            // 
            // label_inforRent
            // 
            this.label_inforRent.AutoSize = true;
            this.label_inforRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_inforRent.Location = new System.Drawing.Point(91, 18);
            this.label_inforRent.Name = "label_inforRent";
            this.label_inforRent.Size = new System.Drawing.Size(185, 32);
            this.label_inforRent.TabIndex = 6;
            this.label_inforRent.Text = "Thông Tin Xe";
            // 
            // materialButton_rent
            // 
            this.materialButton_rent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton_rent.Depth = 0;
            this.materialButton_rent.DrawShadows = true;
            this.materialButton_rent.HighEmphasis = true;
            this.materialButton_rent.Icon = null;
            this.materialButton_rent.Location = new System.Drawing.Point(27, 439);
            this.materialButton_rent.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton_rent.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton_rent.Name = "materialButton_rent";
            this.materialButton_rent.Size = new System.Drawing.Size(114, 36);
            this.materialButton_rent.TabIndex = 18;
            this.materialButton_rent.Text = "Cho Thuê Xe";
            this.materialButton_rent.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton_rent.UseAccentColor = false;
            this.materialButton_rent.UseVisualStyleBackColor = true;
            this.materialButton_rent.Click += new System.EventHandler(this.materialButton_rent_Click);
            // 
            // label_pic
            // 
            this.label_pic.AutoSize = true;
            this.label_pic.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pic.Location = new System.Drawing.Point(22, 141);
            this.label_pic.Name = "label_pic";
            this.label_pic.Size = new System.Drawing.Size(99, 29);
            this.label_pic.TabIndex = 3;
            this.label_pic.Text = "Hình Xe";
            // 
            // pictureBox_rent
            // 
            this.pictureBox_rent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_rent.Location = new System.Drawing.Point(150, 141);
            this.pictureBox_rent.Name = "pictureBox_rent";
            this.pictureBox_rent.Size = new System.Drawing.Size(160, 133);
            this.pictureBox_rent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_rent.TabIndex = 2;
            this.pictureBox_rent.TabStop = false;
            // 
            // textBox_rent
            // 
            this.textBox_rent.Location = new System.Drawing.Point(150, 78);
            this.textBox_rent.Name = "textBox_rent";
            this.textBox_rent.Size = new System.Drawing.Size(160, 22);
            this.textBox_rent.TabIndex = 1;
            // 
            // label_idRent
            // 
            this.label_idRent.AutoSize = true;
            this.label_idRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_idRent.Location = new System.Drawing.Point(85, 78);
            this.label_idRent.Name = "label_idRent";
            this.label_idRent.Size = new System.Drawing.Size(36, 29);
            this.label_idRent.TabIndex = 0;
            this.label_idRent.Text = "ID";
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.Chocolate;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(62, 611);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(163, 45);
            this.button_add.TabIndex = 4;
            this.button_add.Text = "Thêm Xe";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // pictureBox_trans
            // 
            this.pictureBox_trans.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_trans.Location = new System.Drawing.Point(62, 434);
            this.pictureBox_trans.Name = "pictureBox_trans";
            this.pictureBox_trans.Size = new System.Drawing.Size(163, 120);
            this.pictureBox_trans.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_trans.TabIndex = 3;
            this.pictureBox_trans.TabStop = false;
            // 
            // button_up
            // 
            this.button_up.BackColor = System.Drawing.Color.Bisque;
            this.button_up.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_up.Location = new System.Drawing.Point(62, 560);
            this.button_up.Name = "button_up";
            this.button_up.Size = new System.Drawing.Size(163, 45);
            this.button_up.TabIndex = 2;
            this.button_up.Text = "Upload";
            this.button_up.UseVisualStyleBackColor = false;
            this.button_up.Click += new System.EventHandler(this.button_up_Click);
            // 
            // dataGridView_rent
            // 
            this.dataGridView_rent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_rent.Location = new System.Drawing.Point(6, 75);
            this.dataGridView_rent.Name = "dataGridView_rent";
            this.dataGridView_rent.RowHeadersWidth = 51;
            this.dataGridView_rent.RowTemplate.Height = 24;
            this.dataGridView_rent.Size = new System.Drawing.Size(282, 339);
            this.dataGridView_rent.TabIndex = 1;
            this.dataGridView_rent.DoubleClick += new System.EventHandler(this.dataGridView_rent_DoubleClick);
            // 
            // label_listRent
            // 
            this.label_listRent.AutoSize = true;
            this.label_listRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_listRent.Location = new System.Drawing.Point(10, 25);
            this.label_listRent.Name = "label_listRent";
            this.label_listRent.Size = new System.Drawing.Size(328, 32);
            this.label_listRent.TabIndex = 0;
            this.label_listRent.Text = "Danh Sách Xe Cho Thuê";
            // 
            // tabPage_add
            // 
            this.tabPage_add.BackColor = System.Drawing.Color.LimeGreen;
            this.tabPage_add.Controls.Add(this.label_money);
            this.tabPage_add.Controls.Add(this.comboBox_typeCustomer);
            this.tabPage_add.Controls.Add(this.comboBox_trans);
            this.tabPage_add.Controls.Add(this.panel_trans);
            this.tabPage_add.Controls.Add(this.panel_Customer);
            this.tabPage_add.Controls.Add(this.numericUpDown_add);
            this.tabPage_add.Controls.Add(this.materialButton_add);
            this.tabPage_add.Controls.Add(this.button_trans);
            this.tabPage_add.Controls.Add(this.textBox_trans);
            this.tabPage_add.Controls.Add(this.label_id);
            this.tabPage_add.Controls.Add(this.button_listCus);
            this.tabPage_add.Controls.Add(this.textBox_idCus);
            this.tabPage_add.Controls.Add(this.label_idCustomer);
            this.tabPage_add.Location = new System.Drawing.Point(4, 25);
            this.tabPage_add.Name = "tabPage_add";
            this.tabPage_add.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_add.Size = new System.Drawing.Size(1501, 688);
            this.tabPage_add.TabIndex = 1;
            this.tabPage_add.Text = "Ký Gửi Xe";
            // 
            // label_money
            // 
            this.label_money.AutoSize = true;
            this.label_money.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_money.ForeColor = System.Drawing.Color.White;
            this.label_money.Location = new System.Drawing.Point(885, 579);
            this.label_money.Name = "label_money";
            this.label_money.Size = new System.Drawing.Size(73, 25);
            this.label_money.TabIndex = 19;
            this.label_money.Text = "Giá Cả";
            // 
            // comboBox_typeCustomer
            // 
            this.comboBox_typeCustomer.FormattingEnabled = true;
            this.comboBox_typeCustomer.Items.AddRange(new object[] {
            "RENT BY DAY",
            "RENT BY MONTH",
            "RENT BY YEAR"});
            this.comboBox_typeCustomer.Location = new System.Drawing.Point(534, 579);
            this.comboBox_typeCustomer.Name = "comboBox_typeCustomer";
            this.comboBox_typeCustomer.Size = new System.Drawing.Size(240, 24);
            this.comboBox_typeCustomer.TabIndex = 16;
            this.comboBox_typeCustomer.SelectedIndexChanged += new System.EventHandler(this.comboBox_typeCustomer_SelectedIndexChanged);
            // 
            // comboBox_trans
            // 
            this.comboBox_trans.FormattingEnabled = true;
            this.comboBox_trans.Items.AddRange(new object[] {
            "Bike",
            "Motor",
            "Car"});
            this.comboBox_trans.Location = new System.Drawing.Point(672, 70);
            this.comboBox_trans.Name = "comboBox_trans";
            this.comboBox_trans.Size = new System.Drawing.Size(184, 24);
            this.comboBox_trans.TabIndex = 15;
            // 
            // panel_trans
            // 
            this.panel_trans.Location = new System.Drawing.Point(534, 109);
            this.panel_trans.Name = "panel_trans";
            this.panel_trans.Size = new System.Drawing.Size(961, 451);
            this.panel_trans.TabIndex = 14;
            // 
            // panel_Customer
            // 
            this.panel_Customer.Location = new System.Drawing.Point(11, 109);
            this.panel_Customer.Name = "panel_Customer";
            this.panel_Customer.Size = new System.Drawing.Size(488, 540);
            this.panel_Customer.TabIndex = 13;
            // 
            // numericUpDown_add
            // 
            this.numericUpDown_add.Location = new System.Drawing.Point(785, 580);
            this.numericUpDown_add.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_add.Name = "numericUpDown_add";
            this.numericUpDown_add.Size = new System.Drawing.Size(71, 22);
            this.numericUpDown_add.TabIndex = 12;
            this.numericUpDown_add.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_add.ValueChanged += new System.EventHandler(this.numericUpDown_add_ValueChanged);
            // 
            // materialButton_add
            // 
            this.materialButton_add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton_add.Depth = 0;
            this.materialButton_add.DrawShadows = true;
            this.materialButton_add.HighEmphasis = true;
            this.materialButton_add.Icon = null;
            this.materialButton_add.Location = new System.Drawing.Point(534, 612);
            this.materialButton_add.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton_add.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton_add.Name = "materialButton_add";
            this.materialButton_add.Size = new System.Drawing.Size(133, 36);
            this.materialButton_add.TabIndex = 6;
            this.materialButton_add.Text = "Thêm Xe Ký Gửi";
            this.materialButton_add.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton_add.UseAccentColor = false;
            this.materialButton_add.UseVisualStyleBackColor = true;
            this.materialButton_add.Click += new System.EventHandler(this.materialButton_add_Click);
            // 
            // button_trans
            // 
            this.button_trans.BackColor = System.Drawing.Color.Aqua;
            this.button_trans.Location = new System.Drawing.Point(877, 64);
            this.button_trans.Name = "button_trans";
            this.button_trans.Size = new System.Drawing.Size(236, 34);
            this.button_trans.TabIndex = 5;
            this.button_trans.Text = "Danh Sách Xe Đang Gửi";
            this.button_trans.UseVisualStyleBackColor = false;
            this.button_trans.Click += new System.EventHandler(this.button_trans_Click);
            // 
            // textBox_trans
            // 
            this.textBox_trans.Location = new System.Drawing.Point(672, 28);
            this.textBox_trans.Name = "textBox_trans";
            this.textBox_trans.Size = new System.Drawing.Size(184, 22);
            this.textBox_trans.TabIndex = 4;
            this.textBox_trans.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_trans_KeyDown);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.ForeColor = System.Drawing.Color.White;
            this.label_id.Location = new System.Drawing.Point(529, 25);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(110, 25);
            this.label_id.TabIndex = 3;
            this.label_id.Text = "Mã Thẻ Xe";
            // 
            // button_listCus
            // 
            this.button_listCus.BackColor = System.Drawing.Color.Yellow;
            this.button_listCus.Location = new System.Drawing.Point(227, 63);
            this.button_listCus.Name = "button_listCus";
            this.button_listCus.Size = new System.Drawing.Size(234, 34);
            this.button_listCus.TabIndex = 2;
            this.button_listCus.Text = "Danh Sách Khách Hàng";
            this.button_listCus.UseVisualStyleBackColor = false;
            this.button_listCus.Click += new System.EventHandler(this.button_listCus_Click);
            // 
            // textBox_idCus
            // 
            this.textBox_idCus.Location = new System.Drawing.Point(227, 29);
            this.textBox_idCus.Name = "textBox_idCus";
            this.textBox_idCus.Size = new System.Drawing.Size(184, 22);
            this.textBox_idCus.TabIndex = 1;
            this.textBox_idCus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_idCus_KeyDown);
            // 
            // label_idCustomer
            // 
            this.label_idCustomer.AutoSize = true;
            this.label_idCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_idCustomer.ForeColor = System.Drawing.Color.White;
            this.label_idCustomer.Location = new System.Drawing.Point(6, 25);
            this.label_idCustomer.Name = "label_idCustomer";
            this.label_idCustomer.Size = new System.Drawing.Size(154, 25);
            this.label_idCustomer.TabIndex = 0;
            this.label_idCustomer.Text = "Mã Khách Hàng";
            // 
            // tabPage_contract
            // 
            this.tabPage_contract.BackColor = System.Drawing.Color.BurlyWood;
            this.tabPage_contract.Controls.Add(this.materialButton_print);
            this.tabPage_contract.Controls.Add(this.label_contract);
            this.tabPage_contract.Controls.Add(this.dataGridView_rentalList);
            this.tabPage_contract.Location = new System.Drawing.Point(4, 25);
            this.tabPage_contract.Name = "tabPage_contract";
            this.tabPage_contract.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_contract.Size = new System.Drawing.Size(1501, 688);
            this.tabPage_contract.TabIndex = 2;
            this.tabPage_contract.Text = "Danh Sách Hợp Đồng";
            // 
            // label_contract
            // 
            this.label_contract.AutoSize = true;
            this.label_contract.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_contract.Location = new System.Drawing.Point(477, 39);
            this.label_contract.Name = "label_contract";
            this.label_contract.Size = new System.Drawing.Size(616, 44);
            this.label_contract.TabIndex = 1;
            this.label_contract.Text = "Danh Sách Hợp Đồng Của Công Ty";
            this.label_contract.Click += new System.EventHandler(this.label_contract_Click);
            // 
            // dataGridView_rentalList
            // 
            this.dataGridView_rentalList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_rentalList.Location = new System.Drawing.Point(171, 116);
            this.dataGridView_rentalList.Name = "dataGridView_rentalList";
            this.dataGridView_rentalList.RowHeadersWidth = 51;
            this.dataGridView_rentalList.RowTemplate.Height = 24;
            this.dataGridView_rentalList.Size = new System.Drawing.Size(1151, 477);
            this.dataGridView_rentalList.TabIndex = 0;
            // 
            // materialButton_print
            // 
            this.materialButton_print.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton_print.Depth = 0;
            this.materialButton_print.DrawShadows = true;
            this.materialButton_print.HighEmphasis = true;
            this.materialButton_print.Icon = null;
            this.materialButton_print.Location = new System.Drawing.Point(691, 602);
            this.materialButton_print.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton_print.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton_print.Name = "materialButton_print";
            this.materialButton_print.Size = new System.Drawing.Size(158, 36);
            this.materialButton_print.TabIndex = 2;
            this.materialButton_print.Text = "Print";
            this.materialButton_print.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton_print.UseAccentColor = false;
            this.materialButton_print.UseVisualStyleBackColor = true;
            this.materialButton_print.Click += new System.EventHandler(this.materialButton_print_Click);
            // 
            // contractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1533, 741);
            this.Controls.Add(this.tabControl_rent);
            this.Name = "contractForm";
            this.Text = "Hợp Đồng";
            this.Load += new System.EventHandler(this.contractForm_Load);
            this.tabControl_rent.ResumeLayout(false);
            this.tabPage_rent.ResumeLayout(false);
            this.tabPage_rent.PerformLayout();
            this.panel_rent.ResumeLayout(false);
            this.panel_rent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_get)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_rent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_trans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_rent)).EndInit();
            this.tabPage_add.ResumeLayout(false);
            this.tabPage_add.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_add)).EndInit();
            this.tabPage_contract.ResumeLayout(false);
            this.tabPage_contract.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_rentalList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage_rent;
        private System.Windows.Forms.TabPage tabPage_add;
        private System.Windows.Forms.Button button_trans;
        private System.Windows.Forms.TextBox textBox_trans;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Button button_listCus;
        private System.Windows.Forms.TextBox textBox_idCus;
        private System.Windows.Forms.Label label_idCustomer;
        private System.Windows.Forms.TabPage tabPage_contract;
        private MaterialSkin.Controls.MaterialButton materialButton_add;
        private System.Windows.Forms.NumericUpDown numericUpDown_add;
        private System.Windows.Forms.Panel panel_Customer;
        private System.Windows.Forms.Panel panel_trans;
        public System.Windows.Forms.TabControl tabControl_rent;
        private System.Windows.Forms.ComboBox comboBox_trans;
        private System.Windows.Forms.ComboBox comboBox_typeCustomer;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.PictureBox pictureBox_trans;
        private System.Windows.Forms.Button button_up;
        private System.Windows.Forms.DataGridView dataGridView_rent;
        private System.Windows.Forms.Label label_listRent;
        private System.Windows.Forms.Panel panel_rent;
        private System.Windows.Forms.Label label_pic;
        private System.Windows.Forms.PictureBox pictureBox_rent;
        private System.Windows.Forms.TextBox textBox_rent;
        private System.Windows.Forms.Label label_idRent;
        private System.Windows.Forms.Panel panel_inforCustomer;
        private System.Windows.Forms.Button button_Customer;
        private System.Windows.Forms.TextBox textBox_customer;
        private System.Windows.Forms.Label label_idCus;
        private System.Windows.Forms.Label label_inforRent;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.ComboBox comboBox_select;
        private System.Windows.Forms.NumericUpDown numericUpDown_get;
        private MaterialSkin.Controls.MaterialButton materialButton_rent;
        private System.Windows.Forms.Label label_money;
        private System.Windows.Forms.DataGridView dataGridView_rentalList;
        private System.Windows.Forms.Label label_contract;
        private MaterialSkin.Controls.MaterialButton materialButton_print;
    }
}