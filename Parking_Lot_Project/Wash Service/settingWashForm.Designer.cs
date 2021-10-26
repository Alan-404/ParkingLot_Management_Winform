
namespace Parking_Lot_Project
{
    partial class settingWashForm
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
            this.materialButton_update = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBox_name = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox_price = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox_id = new MaterialSkin.Controls.MaterialTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_list = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_list)).BeginInit();
            this.SuspendLayout();
            // 
            // materialButton_update
            // 
            this.materialButton_update.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton_update.Depth = 0;
            this.materialButton_update.DrawShadows = true;
            this.materialButton_update.HighEmphasis = true;
            this.materialButton_update.Icon = null;
            this.materialButton_update.Location = new System.Drawing.Point(707, 453);
            this.materialButton_update.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton_update.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton_update.Name = "materialButton_update";
            this.materialButton_update.Size = new System.Drawing.Size(93, 36);
            this.materialButton_update.TabIndex = 69;
            this.materialButton_update.Text = "Cập Nhật";
            this.materialButton_update.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton_update.UseAccentColor = false;
            this.materialButton_update.UseVisualStyleBackColor = true;
            this.materialButton_update.Click += new System.EventHandler(this.materialButton_update_Click);
            // 
            // materialTextBox_name
            // 
            this.materialTextBox_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox_name.Depth = 0;
            this.materialTextBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materialTextBox_name.Location = new System.Drawing.Point(707, 263);
            this.materialTextBox_name.MaxLength = 50;
            this.materialTextBox_name.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox_name.Multiline = false;
            this.materialTextBox_name.Name = "materialTextBox_name";
            this.materialTextBox_name.Size = new System.Drawing.Size(244, 50);
            this.materialTextBox_name.TabIndex = 68;
            this.materialTextBox_name.Text = "";
            // 
            // materialTextBox_price
            // 
            this.materialTextBox_price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox_price.Depth = 0;
            this.materialTextBox_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materialTextBox_price.Location = new System.Drawing.Point(707, 379);
            this.materialTextBox_price.MaxLength = 50;
            this.materialTextBox_price.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox_price.Multiline = false;
            this.materialTextBox_price.Name = "materialTextBox_price";
            this.materialTextBox_price.Size = new System.Drawing.Size(244, 50);
            this.materialTextBox_price.TabIndex = 67;
            this.materialTextBox_price.Text = "";
            // 
            // materialTextBox_id
            // 
            this.materialTextBox_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox_id.Depth = 0;
            this.materialTextBox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materialTextBox_id.Location = new System.Drawing.Point(879, 135);
            this.materialTextBox_id.MaxLength = 50;
            this.materialTextBox_id.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox_id.Multiline = false;
            this.materialTextBox_id.Name = "materialTextBox_id";
            this.materialTextBox_id.Size = new System.Drawing.Size(100, 50);
            this.materialTextBox_id.TabIndex = 66;
            this.materialTextBox_id.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(702, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 29);
            this.label5.TabIndex = 65;
            this.label5.Text = "Giá Tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(700, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 29);
            this.label4.TabIndex = 64;
            this.label4.Text = "Mã Dịch Vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(702, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 29);
            this.label3.TabIndex = 63;
            this.label3.Text = "Tên Dịch Vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(700, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 39);
            this.label2.TabIndex = 62;
            this.label2.Text = "Thông Tin Dịch Vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 44);
            this.label1.TabIndex = 61;
            this.label1.Text = "Bảng Giá Sửa Xe";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView_list
            // 
            this.dataGridView_list.BackgroundColor = System.Drawing.Color.Orchid;
            this.dataGridView_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_list.Location = new System.Drawing.Point(39, 106);
            this.dataGridView_list.Name = "dataGridView_list";
            this.dataGridView_list.RowHeadersWidth = 51;
            this.dataGridView_list.RowTemplate.Height = 24;
            this.dataGridView_list.Size = new System.Drawing.Size(593, 375);
            this.dataGridView_list.TabIndex = 60;
            this.dataGridView_list.DoubleClick += new System.EventHandler(this.dataGridView_list_DoubleClick);
            // 
            // settingWashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1100, 548);
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
            this.Name = "settingWashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "settingWashForm";
            this.Load += new System.EventHandler(this.settingWashForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton materialButton_update;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox_name;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox_price;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_list;
    }
}