
namespace Parking_Lot_Project
{
    partial class settingPriceParkForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label_hour = new System.Windows.Forms.Label();
            this.materialTextBox_hour = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox_day = new MaterialSkin.Controls.MaterialTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.materialTextBox_month = new MaterialSkin.Controls.MaterialTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.materialTextBox_year = new MaterialSkin.Controls.MaterialTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.materialButton_update = new MaterialSkin.Controls.MaterialButton();
            this.materialComboBox_trans = new MaterialSkin.Controls.MaterialComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bảng Giá Gửi Xe";
            // 
            // label_hour
            // 
            this.label_hour.AutoSize = true;
            this.label_hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hour.Location = new System.Drawing.Point(73, 167);
            this.label_hour.Name = "label_hour";
            this.label_hour.Size = new System.Drawing.Size(132, 24);
            this.label_hour.TabIndex = 2;
            this.label_hour.Text = "Tiền Theo Giờ";
            // 
            // materialTextBox_hour
            // 
            this.materialTextBox_hour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox_hour.Depth = 0;
            this.materialTextBox_hour.Font = new System.Drawing.Font("Roboto", 12F);
            this.materialTextBox_hour.Location = new System.Drawing.Point(47, 203);
            this.materialTextBox_hour.MaxLength = 50;
            this.materialTextBox_hour.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox_hour.Multiline = false;
            this.materialTextBox_hour.Name = "materialTextBox_hour";
            this.materialTextBox_hour.Size = new System.Drawing.Size(216, 50);
            this.materialTextBox_hour.TabIndex = 3;
            this.materialTextBox_hour.Text = "";
            // 
            // materialTextBox_day
            // 
            this.materialTextBox_day.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox_day.Depth = 0;
            this.materialTextBox_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materialTextBox_day.Location = new System.Drawing.Point(369, 203);
            this.materialTextBox_day.MaxLength = 50;
            this.materialTextBox_day.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox_day.Multiline = false;
            this.materialTextBox_day.Name = "materialTextBox_day";
            this.materialTextBox_day.Size = new System.Drawing.Size(216, 50);
            this.materialTextBox_day.TabIndex = 5;
            this.materialTextBox_day.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(395, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tiền Theo Ngày";
            // 
            // materialTextBox_month
            // 
            this.materialTextBox_month.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox_month.Depth = 0;
            this.materialTextBox_month.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materialTextBox_month.Location = new System.Drawing.Point(47, 333);
            this.materialTextBox_month.MaxLength = 50;
            this.materialTextBox_month.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox_month.Multiline = false;
            this.materialTextBox_month.Name = "materialTextBox_month";
            this.materialTextBox_month.Size = new System.Drawing.Size(216, 50);
            this.materialTextBox_month.TabIndex = 7;
            this.materialTextBox_month.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tiền Theo Tháng";
            // 
            // materialTextBox_year
            // 
            this.materialTextBox_year.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox_year.Depth = 0;
            this.materialTextBox_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materialTextBox_year.Location = new System.Drawing.Point(369, 333);
            this.materialTextBox_year.MaxLength = 50;
            this.materialTextBox_year.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox_year.Multiline = false;
            this.materialTextBox_year.Name = "materialTextBox_year";
            this.materialTextBox_year.Size = new System.Drawing.Size(216, 50);
            this.materialTextBox_year.TabIndex = 9;
            this.materialTextBox_year.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(395, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tiền Theo Năm";
            // 
            // materialButton_update
            // 
            this.materialButton_update.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton_update.Depth = 0;
            this.materialButton_update.DrawShadows = true;
            this.materialButton_update.HighEmphasis = true;
            this.materialButton_update.Icon = null;
            this.materialButton_update.Location = new System.Drawing.Point(234, 464);
            this.materialButton_update.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton_update.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton_update.Name = "materialButton_update";
            this.materialButton_update.Size = new System.Drawing.Size(164, 36);
            this.materialButton_update.TabIndex = 10;
            this.materialButton_update.Text = "Cập Nhật Bảng Giá";
            this.materialButton_update.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton_update.UseAccentColor = false;
            this.materialButton_update.UseVisualStyleBackColor = true;
            this.materialButton_update.Click += new System.EventHandler(this.materialButton_update_Click);
            // 
            // materialComboBox_trans
            // 
            this.materialComboBox_trans.AutoResize = false;
            this.materialComboBox_trans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox_trans.Depth = 0;
            this.materialComboBox_trans.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox_trans.DropDownHeight = 174;
            this.materialComboBox_trans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox_trans.DropDownWidth = 121;
            this.materialComboBox_trans.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox_trans.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox_trans.FormattingEnabled = true;
            this.materialComboBox_trans.IntegralHeight = false;
            this.materialComboBox_trans.ItemHeight = 43;
            this.materialComboBox_trans.Items.AddRange(new object[] {
            "Xe Đạp",
            "Xe Máy",
            "Xe Hơi"});
            this.materialComboBox_trans.Location = new System.Drawing.Point(12, 76);
            this.materialComboBox_trans.MaxDropDownItems = 4;
            this.materialComboBox_trans.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox_trans.Name = "materialComboBox_trans";
            this.materialComboBox_trans.Size = new System.Drawing.Size(234, 49);
            this.materialComboBox_trans.StartIndex = 0;
            this.materialComboBox_trans.TabIndex = 11;
            this.materialComboBox_trans.SelectedIndexChanged += new System.EventHandler(this.materialComboBox_trans_SelectedIndexChanged_1);
            // 
            // settingPriceParkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 545);
            this.Controls.Add(this.materialComboBox_trans);
            this.Controls.Add(this.materialButton_update);
            this.Controls.Add(this.materialTextBox_year);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.materialTextBox_month);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.materialTextBox_day);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.materialTextBox_hour);
            this.Controls.Add(this.label_hour);
            this.Controls.Add(this.label1);
            this.Name = "settingPriceParkForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "settingPriceParkForm";
            this.Load += new System.EventHandler(this.settingPriceParkForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_hour;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox_hour;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox_day;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox_month;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox_year;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialButton materialButton_update;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox_trans;
    }
}