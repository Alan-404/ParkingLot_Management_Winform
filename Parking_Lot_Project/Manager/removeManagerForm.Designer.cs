
namespace Parking_Lot_Project
{
    partial class removeManagerForm
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
            this.dataGridView_admin = new System.Windows.Forms.DataGridView();
            this.label_listAdmin = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.materialButton_remove = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_admin)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_admin
            // 
            this.dataGridView_admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_admin.Location = new System.Drawing.Point(12, 84);
            this.dataGridView_admin.Name = "dataGridView_admin";
            this.dataGridView_admin.RowHeadersWidth = 51;
            this.dataGridView_admin.RowTemplate.Height = 24;
            this.dataGridView_admin.Size = new System.Drawing.Size(889, 252);
            this.dataGridView_admin.TabIndex = 0;
            this.dataGridView_admin.DoubleClick += new System.EventHandler(this.dataGridView_admin_DoubleClick);
            // 
            // label_listAdmin
            // 
            this.label_listAdmin.AutoSize = true;
            this.label_listAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_listAdmin.Location = new System.Drawing.Point(286, 9);
            this.label_listAdmin.Name = "label_listAdmin";
            this.label_listAdmin.Size = new System.Drawing.Size(408, 51);
            this.label_listAdmin.TabIndex = 1;
            this.label_listAdmin.Text = "Danh Sách Quản Lý";
            this.label_listAdmin.Click += new System.EventHandler(this.label_listAdmin_Click);
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(12, 342);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(138, 22);
            this.textBox_id.TabIndex = 2;
            // 
            // materialButton_remove
            // 
            this.materialButton_remove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton_remove.Depth = 0;
            this.materialButton_remove.DrawShadows = true;
            this.materialButton_remove.HighEmphasis = true;
            this.materialButton_remove.Icon = null;
            this.materialButton_remove.Location = new System.Drawing.Point(13, 373);
            this.materialButton_remove.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton_remove.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton_remove.Name = "materialButton_remove";
            this.materialButton_remove.Size = new System.Drawing.Size(115, 36);
            this.materialButton_remove.TabIndex = 3;
            this.materialButton_remove.Text = "Xóa Quản Lý";
            this.materialButton_remove.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton_remove.UseAccentColor = false;
            this.materialButton_remove.UseVisualStyleBackColor = true;
            this.materialButton_remove.Click += new System.EventHandler(this.materialButton_remove_Click);
            // 
            // removeManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(918, 450);
            this.Controls.Add(this.materialButton_remove);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label_listAdmin);
            this.Controls.Add(this.dataGridView_admin);
            this.Name = "removeManagerForm";
            this.Text = "removeManagerForm";
            this.Load += new System.EventHandler(this.removeManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_admin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_admin;
        private System.Windows.Forms.Label label_listAdmin;
        private System.Windows.Forms.TextBox textBox_id;
        private MaterialSkin.Controls.MaterialButton materialButton_remove;
    }
}