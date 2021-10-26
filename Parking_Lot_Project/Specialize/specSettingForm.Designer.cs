
namespace Parking_Lot_Project
{
    partial class specSettingForm
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
            this.label_id = new System.Windows.Forms.Label();
            this.comboBox_spec = new System.Windows.Forms.ComboBox();
            this.comboBox_work = new System.Windows.Forms.ComboBox();
            this.label_work = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.materialButton_add = new MaterialSkin.Controls.MaterialButton();
            this.materialButton_edit = new MaterialSkin.Controls.MaterialButton();
            this.materialButton_remove = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.Location = new System.Drawing.Point(65, 90);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(154, 32);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "Chuyên Môn";
            // 
            // comboBox_spec
            // 
            this.comboBox_spec.FormattingEnabled = true;
            this.comboBox_spec.Location = new System.Drawing.Point(396, 95);
            this.comboBox_spec.Name = "comboBox_spec";
            this.comboBox_spec.Size = new System.Drawing.Size(173, 24);
            this.comboBox_spec.TabIndex = 1;
            // 
            // comboBox_work
            // 
            this.comboBox_work.FormattingEnabled = true;
            this.comboBox_work.Location = new System.Drawing.Point(396, 42);
            this.comboBox_work.Name = "comboBox_work";
            this.comboBox_work.Size = new System.Drawing.Size(173, 24);
            this.comboBox_work.TabIndex = 3;
            this.comboBox_work.SelectedIndexChanged += new System.EventHandler(this.comboBox_work_SelectedIndexChanged);
            // 
            // label_work
            // 
            this.label_work.AutoSize = true;
            this.label_work.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_work.Location = new System.Drawing.Point(65, 34);
            this.label_work.Name = "label_work";
            this.label_work.Size = new System.Drawing.Size(248, 32);
            this.label_work.TabIndex = 2;
            this.label_work.Text = "Phòng Ban Công Việc";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(65, 145);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(199, 32);
            this.label_name.TabIndex = 4;
            this.label_name.Text = "Tên Chuyên Môn";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(396, 150);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(173, 22);
            this.textBox_name.TabIndex = 5;
            // 
            // materialButton_add
            // 
            this.materialButton_add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton_add.Depth = 0;
            this.materialButton_add.DrawShadows = true;
            this.materialButton_add.HighEmphasis = true;
            this.materialButton_add.Icon = null;
            this.materialButton_add.Location = new System.Drawing.Point(248, 240);
            this.materialButton_add.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton_add.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton_add.Name = "materialButton_add";
            this.materialButton_add.Size = new System.Drawing.Size(161, 36);
            this.materialButton_add.TabIndex = 6;
            this.materialButton_add.Text = "Thêm Chuyên Môn";
            this.materialButton_add.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton_add.UseAccentColor = false;
            this.materialButton_add.UseVisualStyleBackColor = true;
            this.materialButton_add.Click += new System.EventHandler(this.materialButton_add_Click);
            // 
            // materialButton_edit
            // 
            this.materialButton_edit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton_edit.Depth = 0;
            this.materialButton_edit.DrawShadows = true;
            this.materialButton_edit.HighEmphasis = true;
            this.materialButton_edit.Icon = null;
            this.materialButton_edit.Location = new System.Drawing.Point(121, 297);
            this.materialButton_edit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton_edit.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton_edit.Name = "materialButton_edit";
            this.materialButton_edit.Size = new System.Drawing.Size(168, 36);
            this.materialButton_edit.TabIndex = 7;
            this.materialButton_edit.Text = "Thay Đổi Thông Tin";
            this.materialButton_edit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton_edit.UseAccentColor = false;
            this.materialButton_edit.UseVisualStyleBackColor = true;
            this.materialButton_edit.Click += new System.EventHandler(this.materialButton_edit_Click);
            // 
            // materialButton_remove
            // 
            this.materialButton_remove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton_remove.Depth = 0;
            this.materialButton_remove.DrawShadows = true;
            this.materialButton_remove.HighEmphasis = true;
            this.materialButton_remove.Icon = null;
            this.materialButton_remove.Location = new System.Drawing.Point(374, 297);
            this.materialButton_remove.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton_remove.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton_remove.Name = "materialButton_remove";
            this.materialButton_remove.Size = new System.Drawing.Size(149, 36);
            this.materialButton_remove.TabIndex = 8;
            this.materialButton_remove.Text = "Xóa Chuyên Môn";
            this.materialButton_remove.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton_remove.UseAccentColor = false;
            this.materialButton_remove.UseVisualStyleBackColor = true;
            this.materialButton_remove.Click += new System.EventHandler(this.materialButton_remove_Click);
            // 
            // specSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(708, 397);
            this.Controls.Add(this.materialButton_remove);
            this.Controls.Add(this.materialButton_edit);
            this.Controls.Add(this.materialButton_add);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.comboBox_work);
            this.Controls.Add(this.label_work);
            this.Controls.Add(this.comboBox_spec);
            this.Controls.Add(this.label_id);
            this.Name = "specSettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa Thông Tin Chuyên Môn";
            this.Load += new System.EventHandler(this.specSettingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.ComboBox comboBox_spec;
        private System.Windows.Forms.ComboBox comboBox_work;
        private System.Windows.Forms.Label label_work;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox_name;
        private MaterialSkin.Controls.MaterialButton materialButton_add;
        private MaterialSkin.Controls.MaterialButton materialButton_edit;
        private MaterialSkin.Controls.MaterialButton materialButton_remove;
    }
}