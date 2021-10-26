
namespace Parking_Lot_Project
{
    partial class interfaceWasherForm
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
            this.tabControl_Fix = new System.Windows.Forms.TabControl();
            this.tabPage_list = new System.Windows.Forms.TabPage();
            this.materialButton_use = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_list = new System.Windows.Forms.DataGridView();
            this.tabPage_listService = new System.Windows.Forms.TabPage();
            this.materialButton_add = new MaterialSkin.Controls.MaterialButton();
            this.materialButton_cal = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1_open = new MaterialSkin.Controls.MaterialButton();
            this.listBox_use = new System.Windows.Forms.ListBox();
            this.listBox_fix = new System.Windows.Forms.ListBox();
            this.label_price = new System.Windows.Forms.Label();
            this.materialButton_upTrans = new MaterialSkin.Controls.MaterialButton();
            this.materialButton_up = new MaterialSkin.Controls.MaterialButton();
            this.label_trans = new System.Windows.Forms.Label();
            this.label_cus = new System.Windows.Forms.Label();
            this.label_logo = new System.Windows.Forms.Label();
            this.tabPage_listFixer = new System.Windows.Forms.TabPage();
            this.dataGridView_listFixer = new System.Windows.Forms.DataGridView();
            this.tabPage_cus = new System.Windows.Forms.TabPage();
            this.label_user = new System.Windows.Forms.Label();
            this.label_imgTrans = new System.Windows.Forms.Label();
            this.materialTextBox_price = new MaterialSkin.Controls.MaterialTextBox();
            this.label_priceService = new System.Windows.Forms.Label();
            this.materialTextBox_name = new MaterialSkin.Controls.MaterialTextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.materialTextBox_id = new MaterialSkin.Controls.MaterialTextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.label_infor = new System.Windows.Forms.Label();
            this.dataGridView_service = new System.Windows.Forms.DataGridView();
            this.pictureBox_trans = new System.Windows.Forms.PictureBox();
            this.pictureBox_cus = new System.Windows.Forms.PictureBox();
            this.pictureBox_transSer = new System.Windows.Forms.PictureBox();
            this.pictureBox_user = new System.Windows.Forms.PictureBox();
            this.tabControl_Fix.SuspendLayout();
            this.tabPage_list.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_list)).BeginInit();
            this.tabPage_listService.SuspendLayout();
            this.tabPage_listFixer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listFixer)).BeginInit();
            this.tabPage_cus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_service)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_trans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_transSer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_user)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_Fix
            // 
            this.tabControl_Fix.Controls.Add(this.tabPage_list);
            this.tabControl_Fix.Controls.Add(this.tabPage_listService);
            this.tabControl_Fix.Controls.Add(this.tabPage_listFixer);
            this.tabControl_Fix.Controls.Add(this.tabPage_cus);
            this.tabControl_Fix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_Fix.Location = new System.Drawing.Point(13, 14);
            this.tabControl_Fix.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl_Fix.Name = "tabControl_Fix";
            this.tabControl_Fix.SelectedIndex = 0;
            this.tabControl_Fix.Size = new System.Drawing.Size(1117, 557);
            this.tabControl_Fix.TabIndex = 1;
            // 
            // tabPage_list
            // 
            this.tabPage_list.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.tabPage_list.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage_list.Controls.Add(this.materialButton_use);
            this.tabPage_list.Controls.Add(this.label1);
            this.tabPage_list.Controls.Add(this.dataGridView_list);
            this.tabPage_list.Location = new System.Drawing.Point(4, 29);
            this.tabPage_list.Name = "tabPage_list";
            this.tabPage_list.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_list.Size = new System.Drawing.Size(1109, 524);
            this.tabPage_list.TabIndex = 2;
            this.tabPage_list.Text = "Danh Sách Dịch Vụ";
            // 
            // materialButton_use
            // 
            this.materialButton_use.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton_use.Depth = 0;
            this.materialButton_use.DrawShadows = true;
            this.materialButton_use.HighEmphasis = true;
            this.materialButton_use.Icon = null;
            this.materialButton_use.Location = new System.Drawing.Point(467, 469);
            this.materialButton_use.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton_use.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton_use.Name = "materialButton_use";
            this.materialButton_use.Size = new System.Drawing.Size(144, 36);
            this.materialButton_use.TabIndex = 51;
            this.materialButton_use.Text = "Sử Dụng Dịch Vụ";
            this.materialButton_use.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton_use.UseAccentColor = false;
            this.materialButton_use.UseVisualStyleBackColor = true;
            this.materialButton_use.Click += new System.EventHandler(this.materialButton_use_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(336, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 50);
            this.label1.TabIndex = 50;
            this.label1.Text = "Menu Dịch Vụ Rửa Xe";
            // 
            // dataGridView_list
            // 
            this.dataGridView_list.BackgroundColor = System.Drawing.Color.Orchid;
            this.dataGridView_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_list.Location = new System.Drawing.Point(325, 85);
            this.dataGridView_list.Name = "dataGridView_list";
            this.dataGridView_list.RowHeadersWidth = 51;
            this.dataGridView_list.RowTemplate.Height = 24;
            this.dataGridView_list.Size = new System.Drawing.Size(443, 375);
            this.dataGridView_list.TabIndex = 49;
            // 
            // tabPage_listService
            // 
            this.tabPage_listService.BackColor = System.Drawing.Color.Pink;
            this.tabPage_listService.Controls.Add(this.materialButton_add);
            this.tabPage_listService.Controls.Add(this.materialButton_cal);
            this.tabPage_listService.Controls.Add(this.materialButton1_open);
            this.tabPage_listService.Controls.Add(this.listBox_use);
            this.tabPage_listService.Controls.Add(this.listBox_fix);
            this.tabPage_listService.Controls.Add(this.label_price);
            this.tabPage_listService.Controls.Add(this.materialButton_upTrans);
            this.tabPage_listService.Controls.Add(this.materialButton_up);
            this.tabPage_listService.Controls.Add(this.label_trans);
            this.tabPage_listService.Controls.Add(this.label_cus);
            this.tabPage_listService.Controls.Add(this.label_logo);
            this.tabPage_listService.Controls.Add(this.pictureBox_trans);
            this.tabPage_listService.Controls.Add(this.pictureBox_cus);
            this.tabPage_listService.Location = new System.Drawing.Point(4, 29);
            this.tabPage_listService.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage_listService.Name = "tabPage_listService";
            this.tabPage_listService.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage_listService.Size = new System.Drawing.Size(1109, 524);
            this.tabPage_listService.TabIndex = 0;
            this.tabPage_listService.Text = "Menu Dịch Vụ";
            // 
            // materialButton_add
            // 
            this.materialButton_add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton_add.Depth = 0;
            this.materialButton_add.DrawShadows = true;
            this.materialButton_add.HighEmphasis = true;
            this.materialButton_add.Icon = null;
            this.materialButton_add.Location = new System.Drawing.Point(762, 334);
            this.materialButton_add.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton_add.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton_add.Name = "materialButton_add";
            this.materialButton_add.Size = new System.Drawing.Size(155, 36);
            this.materialButton_add.TabIndex = 48;
            this.materialButton_add.Text = "Xác Nhận Dịch Vụ";
            this.materialButton_add.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton_add.UseAccentColor = false;
            this.materialButton_add.UseVisualStyleBackColor = true;
            this.materialButton_add.Click += new System.EventHandler(this.materialButton_add_Click);
            // 
            // materialButton_cal
            // 
            this.materialButton_cal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton_cal.Depth = 0;
            this.materialButton_cal.DrawShadows = true;
            this.materialButton_cal.HighEmphasis = true;
            this.materialButton_cal.Icon = null;
            this.materialButton_cal.Location = new System.Drawing.Point(553, 480);
            this.materialButton_cal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton_cal.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton_cal.Name = "materialButton_cal";
            this.materialButton_cal.Size = new System.Drawing.Size(91, 36);
            this.materialButton_cal.TabIndex = 47;
            this.materialButton_cal.Text = "Tính tiền";
            this.materialButton_cal.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton_cal.UseAccentColor = false;
            this.materialButton_cal.UseVisualStyleBackColor = true;
            this.materialButton_cal.Click += new System.EventHandler(this.materialButton_cal_Click);
            // 
            // materialButton1_open
            // 
            this.materialButton1_open.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1_open.Depth = 0;
            this.materialButton1_open.DrawShadows = true;
            this.materialButton1_open.HighEmphasis = true;
            this.materialButton1_open.Icon = null;
            this.materialButton1_open.Location = new System.Drawing.Point(812, 152);
            this.materialButton1_open.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1_open.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1_open.Name = "materialButton1_open";
            this.materialButton1_open.Size = new System.Drawing.Size(107, 36);
            this.materialButton1_open.TabIndex = 46;
            this.materialButton1_open.Text = "Mở Camera";
            this.materialButton1_open.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1_open.UseAccentColor = false;
            this.materialButton1_open.UseVisualStyleBackColor = true;
            // 
            // listBox_use
            // 
            this.listBox_use.FormattingEnabled = true;
            this.listBox_use.ItemHeight = 20;
            this.listBox_use.Location = new System.Drawing.Point(553, 274);
            this.listBox_use.Name = "listBox_use";
            this.listBox_use.Size = new System.Drawing.Size(181, 184);
            this.listBox_use.TabIndex = 45;
            this.listBox_use.Click += new System.EventHandler(this.listBox_use_Click);
            // 
            // listBox_fix
            // 
            this.listBox_fix.FormattingEnabled = true;
            this.listBox_fix.ItemHeight = 20;
            this.listBox_fix.Location = new System.Drawing.Point(285, 274);
            this.listBox_fix.Name = "listBox_fix";
            this.listBox_fix.Size = new System.Drawing.Size(181, 184);
            this.listBox_fix.TabIndex = 44;
            this.listBox_fix.Click += new System.EventHandler(this.listBox_fix_Click);
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Location = new System.Drawing.Point(758, 274);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(40, 20);
            this.label_price.TabIndex = 43;
            this.label_price.Text = "Giá:";
            // 
            // materialButton_upTrans
            // 
            this.materialButton_upTrans.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton_upTrans.Depth = 0;
            this.materialButton_upTrans.DrawShadows = true;
            this.materialButton_upTrans.HighEmphasis = true;
            this.materialButton_upTrans.Icon = null;
            this.materialButton_upTrans.Location = new System.Drawing.Point(840, 104);
            this.materialButton_upTrans.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton_upTrans.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton_upTrans.Name = "materialButton_upTrans";
            this.materialButton_upTrans.Size = new System.Drawing.Size(78, 36);
            this.materialButton_upTrans.TabIndex = 42;
            this.materialButton_upTrans.Text = "Upload";
            this.materialButton_upTrans.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton_upTrans.UseAccentColor = false;
            this.materialButton_upTrans.UseVisualStyleBackColor = true;
            this.materialButton_upTrans.Click += new System.EventHandler(this.materialButton_upTrans_Click);
            // 
            // materialButton_up
            // 
            this.materialButton_up.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton_up.Depth = 0;
            this.materialButton_up.DrawShadows = true;
            this.materialButton_up.HighEmphasis = true;
            this.materialButton_up.Icon = null;
            this.materialButton_up.Location = new System.Drawing.Point(360, 104);
            this.materialButton_up.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton_up.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton_up.Name = "materialButton_up";
            this.materialButton_up.Size = new System.Drawing.Size(78, 36);
            this.materialButton_up.TabIndex = 41;
            this.materialButton_up.Text = "Upload";
            this.materialButton_up.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton_up.UseAccentColor = false;
            this.materialButton_up.UseVisualStyleBackColor = true;
            this.materialButton_up.Click += new System.EventHandler(this.materialButton_up_Click);
            // 
            // label_trans
            // 
            this.label_trans.AutoSize = true;
            this.label_trans.Location = new System.Drawing.Point(552, 104);
            this.label_trans.Name = "label_trans";
            this.label_trans.Size = new System.Drawing.Size(66, 20);
            this.label_trans.TabIndex = 40;
            this.label_trans.Text = "Hình xe";
            // 
            // label_cus
            // 
            this.label_cus.AutoSize = true;
            this.label_cus.Location = new System.Drawing.Point(7, 104);
            this.label_cus.Name = "label_cus";
            this.label_cus.Size = new System.Drawing.Size(134, 20);
            this.label_cus.TabIndex = 39;
            this.label_cus.Text = "Hình khách hàng";
            // 
            // label_logo
            // 
            this.label_logo.AutoSize = true;
            this.label_logo.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_logo.Location = new System.Drawing.Point(332, 22);
            this.label_logo.Name = "label_logo";
            this.label_logo.Size = new System.Drawing.Size(436, 50);
            this.label_logo.TabIndex = 27;
            this.label_logo.Text = "Menu Dịch Vụ Rửa Xe";
            // 
            // tabPage_listFixer
            // 
            this.tabPage_listFixer.BackColor = System.Drawing.Color.Wheat;
            this.tabPage_listFixer.Controls.Add(this.dataGridView_listFixer);
            this.tabPage_listFixer.Location = new System.Drawing.Point(4, 29);
            this.tabPage_listFixer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage_listFixer.Name = "tabPage_listFixer";
            this.tabPage_listFixer.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage_listFixer.Size = new System.Drawing.Size(1109, 524);
            this.tabPage_listFixer.TabIndex = 1;
            this.tabPage_listFixer.Text = "Danh Sách Thợ Rửa Xe";
            // 
            // dataGridView_listFixer
            // 
            this.dataGridView_listFixer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_listFixer.Location = new System.Drawing.Point(7, 8);
            this.dataGridView_listFixer.Name = "dataGridView_listFixer";
            this.dataGridView_listFixer.RowHeadersWidth = 51;
            this.dataGridView_listFixer.RowTemplate.Height = 24;
            this.dataGridView_listFixer.Size = new System.Drawing.Size(1129, 432);
            this.dataGridView_listFixer.TabIndex = 0;
            // 
            // tabPage_cus
            // 
            this.tabPage_cus.BackColor = System.Drawing.Color.Silver;
            this.tabPage_cus.Controls.Add(this.pictureBox_transSer);
            this.tabPage_cus.Controls.Add(this.pictureBox_user);
            this.tabPage_cus.Controls.Add(this.label_user);
            this.tabPage_cus.Controls.Add(this.label_imgTrans);
            this.tabPage_cus.Controls.Add(this.materialTextBox_price);
            this.tabPage_cus.Controls.Add(this.label_priceService);
            this.tabPage_cus.Controls.Add(this.materialTextBox_name);
            this.tabPage_cus.Controls.Add(this.label_name);
            this.tabPage_cus.Controls.Add(this.materialTextBox_id);
            this.tabPage_cus.Controls.Add(this.label_id);
            this.tabPage_cus.Controls.Add(this.label_infor);
            this.tabPage_cus.Controls.Add(this.dataGridView_service);
            this.tabPage_cus.Location = new System.Drawing.Point(4, 29);
            this.tabPage_cus.Name = "tabPage_cus";
            this.tabPage_cus.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_cus.Size = new System.Drawing.Size(1109, 524);
            this.tabPage_cus.TabIndex = 3;
            this.tabPage_cus.Text = "Danh Sách Khách Hàng";
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.ForeColor = System.Drawing.Color.White;
            this.label_user.Location = new System.Drawing.Point(600, 318);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(93, 20);
            this.label_user.TabIndex = 21;
            this.label_user.Text = "Hình khách";
            // 
            // label_imgTrans
            // 
            this.label_imgTrans.AutoSize = true;
            this.label_imgTrans.ForeColor = System.Drawing.Color.White;
            this.label_imgTrans.Location = new System.Drawing.Point(849, 318);
            this.label_imgTrans.Name = "label_imgTrans";
            this.label_imgTrans.Size = new System.Drawing.Size(66, 20);
            this.label_imgTrans.TabIndex = 20;
            this.label_imgTrans.Text = "Hình xe";
            // 
            // materialTextBox_price
            // 
            this.materialTextBox_price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox_price.Depth = 0;
            this.materialTextBox_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materialTextBox_price.Location = new System.Drawing.Point(604, 245);
            this.materialTextBox_price.MaxLength = 50;
            this.materialTextBox_price.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox_price.Multiline = false;
            this.materialTextBox_price.Name = "materialTextBox_price";
            this.materialTextBox_price.Size = new System.Drawing.Size(231, 50);
            this.materialTextBox_price.TabIndex = 19;
            this.materialTextBox_price.Text = "";
            // 
            // label_priceService
            // 
            this.label_priceService.AutoSize = true;
            this.label_priceService.ForeColor = System.Drawing.Color.White;
            this.label_priceService.Location = new System.Drawing.Point(600, 208);
            this.label_priceService.Name = "label_priceService";
            this.label_priceService.Size = new System.Drawing.Size(93, 20);
            this.label_priceService.TabIndex = 18;
            this.label_priceService.Text = "Giá dịch vụ";
            // 
            // materialTextBox_name
            // 
            this.materialTextBox_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox_name.Depth = 0;
            this.materialTextBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materialTextBox_name.Location = new System.Drawing.Point(799, 133);
            this.materialTextBox_name.MaxLength = 50;
            this.materialTextBox_name.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox_name.Multiline = false;
            this.materialTextBox_name.Name = "materialTextBox_name";
            this.materialTextBox_name.Size = new System.Drawing.Size(231, 50);
            this.materialTextBox_name.TabIndex = 17;
            this.materialTextBox_name.Text = "";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.ForeColor = System.Drawing.Color.White;
            this.label_name.Location = new System.Drawing.Point(795, 96);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(95, 20);
            this.label_name.TabIndex = 16;
            this.label_name.Text = "Tên dịch vụ";
            // 
            // materialTextBox_id
            // 
            this.materialTextBox_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox_id.Depth = 0;
            this.materialTextBox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materialTextBox_id.Location = new System.Drawing.Point(604, 134);
            this.materialTextBox_id.MaxLength = 50;
            this.materialTextBox_id.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox_id.Multiline = false;
            this.materialTextBox_id.Name = "materialTextBox_id";
            this.materialTextBox_id.Size = new System.Drawing.Size(90, 50);
            this.materialTextBox_id.TabIndex = 15;
            this.materialTextBox_id.Text = "";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.ForeColor = System.Drawing.Color.White;
            this.label_id.Location = new System.Drawing.Point(600, 97);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(90, 20);
            this.label_id.TabIndex = 14;
            this.label_id.Text = "Mã dịch vụ";
            // 
            // label_infor
            // 
            this.label_infor.AutoSize = true;
            this.label_infor.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_infor.ForeColor = System.Drawing.Color.White;
            this.label_infor.Location = new System.Drawing.Point(655, 28);
            this.label_infor.Name = "label_infor";
            this.label_infor.Size = new System.Drawing.Size(287, 38);
            this.label_infor.TabIndex = 13;
            this.label_infor.Text = "Thông Tin Dịch Vụ";
            // 
            // dataGridView_service
            // 
            this.dataGridView_service.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_service.Location = new System.Drawing.Point(6, 59);
            this.dataGridView_service.Name = "dataGridView_service";
            this.dataGridView_service.RowHeadersWidth = 51;
            this.dataGridView_service.RowTemplate.Height = 24;
            this.dataGridView_service.Size = new System.Drawing.Size(544, 413);
            this.dataGridView_service.TabIndex = 0;
            this.dataGridView_service.DoubleClick += new System.EventHandler(this.dataGridView_service_DoubleClick);
            // 
            // pictureBox_trans
            // 
            this.pictureBox_trans.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_trans.Location = new System.Drawing.Point(624, 104);
            this.pictureBox_trans.Name = "pictureBox_trans";
            this.pictureBox_trans.Size = new System.Drawing.Size(181, 152);
            this.pictureBox_trans.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_trans.TabIndex = 38;
            this.pictureBox_trans.TabStop = false;
            // 
            // pictureBox_cus
            // 
            this.pictureBox_cus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_cus.Location = new System.Drawing.Point(172, 104);
            this.pictureBox_cus.Name = "pictureBox_cus";
            this.pictureBox_cus.Size = new System.Drawing.Size(181, 139);
            this.pictureBox_cus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_cus.TabIndex = 37;
            this.pictureBox_cus.TabStop = false;
            // 
            // pictureBox_transSer
            // 
            this.pictureBox_transSer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_transSer.Location = new System.Drawing.Point(853, 361);
            this.pictureBox_transSer.Name = "pictureBox_transSer";
            this.pictureBox_transSer.Size = new System.Drawing.Size(197, 111);
            this.pictureBox_transSer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_transSer.TabIndex = 23;
            this.pictureBox_transSer.TabStop = false;
            // 
            // pictureBox_user
            // 
            this.pictureBox_user.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_user.Location = new System.Drawing.Point(604, 361);
            this.pictureBox_user.Name = "pictureBox_user";
            this.pictureBox_user.Size = new System.Drawing.Size(197, 111);
            this.pictureBox_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_user.TabIndex = 22;
            this.pictureBox_user.TabStop = false;
            // 
            // interfaceWasherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 588);
            this.Controls.Add(this.tabControl_Fix);
            this.Name = "interfaceWasherForm";
            this.Text = "interfaceWasherForm";
            this.Load += new System.EventHandler(this.interfaceWasherForm_Load);
            this.tabControl_Fix.ResumeLayout(false);
            this.tabPage_list.ResumeLayout(false);
            this.tabPage_list.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_list)).EndInit();
            this.tabPage_listService.ResumeLayout(false);
            this.tabPage_listService.PerformLayout();
            this.tabPage_listFixer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listFixer)).EndInit();
            this.tabPage_cus.ResumeLayout(false);
            this.tabPage_cus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_service)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_trans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_transSer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_user)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage_list;
        private MaterialSkin.Controls.MaterialButton materialButton_use;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_list;
        private System.Windows.Forms.TabPage tabPage_listService;
        private MaterialSkin.Controls.MaterialButton materialButton_add;
        private MaterialSkin.Controls.MaterialButton materialButton_cal;
        private MaterialSkin.Controls.MaterialButton materialButton1_open;
        private System.Windows.Forms.ListBox listBox_use;
        private System.Windows.Forms.ListBox listBox_fix;
        private System.Windows.Forms.Label label_price;
        private MaterialSkin.Controls.MaterialButton materialButton_upTrans;
        private MaterialSkin.Controls.MaterialButton materialButton_up;
        private System.Windows.Forms.Label label_trans;
        private System.Windows.Forms.Label label_cus;
        private System.Windows.Forms.PictureBox pictureBox_trans;
        private System.Windows.Forms.PictureBox pictureBox_cus;
        private System.Windows.Forms.Label label_logo;
        private System.Windows.Forms.TabPage tabPage_listFixer;
        private System.Windows.Forms.DataGridView dataGridView_listFixer;
        private System.Windows.Forms.DataGridView dataGridView_service;
        private System.Windows.Forms.PictureBox pictureBox_transSer;
        private System.Windows.Forms.PictureBox pictureBox_user;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.Label label_imgTrans;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox_price;
        private System.Windows.Forms.Label label_priceService;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox_name;
        private System.Windows.Forms.Label label_name;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox_id;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_infor;
        public System.Windows.Forms.TabControl tabControl_Fix;
        public System.Windows.Forms.TabPage tabPage_cus;
    }
}