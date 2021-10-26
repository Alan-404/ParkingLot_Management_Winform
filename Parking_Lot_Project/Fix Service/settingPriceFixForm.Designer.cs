
namespace Parking_Lot_Project
{
    partial class settingPriceFixForm
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
            this.dataGridView_list = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.materialTextBox_id = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox_price = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox_name = new MaterialSkin.Controls.MaterialTextBox();
            this.materialButton_update = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_list)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_list
            // 
            this.dataGridView_list.BackgroundColor = System.Drawing.Color.Orchid;
            this.dataGridView_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_list.Location = new System.Drawing.Point(12, 90);
            this.dataGridView_list.Name = "dataGridView_list";
            this.dataGridView_list.RowHeadersWidth = 51;
            this.dataGridView_list.RowTemplate.Height = 24;
            this.dataGridView_list.Size = new System.Drawing.Size(577, 375);
            this.dataGridView_list.TabIndex = 50;
            this.dataGridView_list.DoubleClick += new System.EventHandler(this.dataGridView_list_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 44);
            this.label1.TabIndex = 51;
            this.label1.Text = "Bảng Giá Sửa Xe";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(654, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 39);
            this.label2.TabIndex = 52;
            this.label2.Text = "Thông Tin Dịch Vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(656, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 29);
            this.label3.TabIndex = 53;
            this.label3.Text = "Tên Dịch Vụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(654, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 29);
            this.label4.TabIndex = 54;
            this.label4.Text = "Mã Dịch Vụ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(656, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 29);
            this.label5.TabIndex = 55;
            this.label5.Text = "Giá Tiền";
            // 
            // materialTextBox_id
            // 
            this.materialTextBox_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox_id.Depth = 0;
            this.materialTextBox_id.Font = new System.Drawing.Font("Roboto", 12F);
            this.materialTextBox_id.Location = new System.Drawing.Point(830, 127);
            this.materialTextBox_id.MaxLength = 50;
            this.materialTextBox_id.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox_id.Multiline = false;
            this.materialTextBox_id.Name = "materialTextBox_id";
            this.materialTextBox_id.Size = new System.Drawing.Size(100, 50);
            this.materialTextBox_id.TabIndex = 56;
            this.materialTextBox_id.Text = "";
            // 
            // materialTextBox_price
            // 
            this.materialTextBox_price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox_price.Depth = 0;
            this.materialTextBox_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materialTextBox_price.Location = new System.Drawing.Point(661, 370);
            this.materialTextBox_price.MaxLength = 50;
            this.materialTextBox_price.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox_price.Multiline = false;
            this.materialTextBox_price.Name = "materialTextBox_price";
            this.materialTextBox_price.Size = new System.Drawing.Size(244, 50);
            this.materialTextBox_price.TabIndex = 57;
            this.materialTextBox_price.Text = "";
            // 
            // materialTextBox_name
            // 
            this.materialTextBox_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox_name.Depth = 0;
            this.materialTextBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materialTextBox_name.Location = new System.Drawing.Point(661, 254);
            this.materialTextBox_name.MaxLength = 50;
            this.materialTextBox_name.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox_name.Multiline = false;
            this.materialTextBox_name.Name = "materialTextBox_name";
            this.materialTextBox_name.Size = new System.Drawing.Size(244, 50);
            this.materialTextBox_name.TabIndex = 58;
            this.materialTextBox_name.Text = "";
            // 
            // materialButton_update
            // 
            this.materialButton_update.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton_update.Depth = 0;
            this.materialButton_update.DrawShadows = true;
            this.materialButton_update.HighEmphasis = true;
            this.materialButton_update.Icon = null;
            this.materialButton_update.Location = new System.Drawing.Point(661, 444);
            this.materialButton_update.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton_update.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton_update.Name = "materialButton_update";
            this.materialButton_update.Size = new System.Drawing.Size(93, 36);
            this.materialButton_update.TabIndex = 59;
            this.materialButton_update.Text = "Cập Nhật";
            this.materialButton_update.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton_update.UseAccentColor = false;
            this.materialButton_update.UseVisualStyleBackColor = true;
            this.materialButton_update.Click += new System.EventHandler(this.materialButton_update_Click);
            // 
            // settingPriceFixForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1064, 528);
            this.Controls.Add(this.materialButton_update);
            this.Controls.Add(this.materialTextBox_name);
            this.Controls.Add(this.materialTextBox_price);
            this.Controls.Add(this.materialTextBox_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_list);
            this.Name = "settingPriceFixForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "settingPriceFixForm";
            this.Load += new System.EventHandler(this.settingPriceFixForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox_id;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox_price;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox_name;
        private MaterialSkin.Controls.MaterialButton materialButton_update;
    }
}