
namespace Parking_Lot_Project
{
    partial class outGateForm
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
            this.button_removeTransport = new System.Windows.Forms.Button();
            this.label_pic2 = new System.Windows.Forms.Label();
            this.label_pic = new System.Windows.Forms.Label();
            this.pictureBox_getPic2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_getPic1 = new System.Windows.Forms.PictureBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label_price = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_getPic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_getPic1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_removeTransport
            // 
            this.button_removeTransport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_removeTransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_removeTransport.Location = new System.Drawing.Point(693, 218);
            this.button_removeTransport.Name = "button_removeTransport";
            this.button_removeTransport.Size = new System.Drawing.Size(262, 61);
            this.button_removeTransport.TabIndex = 20;
            this.button_removeTransport.Text = "Cho Ra Xe";
            this.button_removeTransport.UseVisualStyleBackColor = false;
            this.button_removeTransport.Click += new System.EventHandler(this.button_removeTransport_Click);
            // 
            // label_pic2
            // 
            this.label_pic2.AutoSize = true;
            this.label_pic2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pic2.ForeColor = System.Drawing.Color.White;
            this.label_pic2.Location = new System.Drawing.Point(55, 423);
            this.label_pic2.Name = "label_pic2";
            this.label_pic2.Size = new System.Drawing.Size(97, 32);
            this.label_pic2.TabIndex = 17;
            this.label_pic2.Text = "Hình 2";
            // 
            // label_pic
            // 
            this.label_pic.AutoSize = true;
            this.label_pic.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pic.ForeColor = System.Drawing.Color.White;
            this.label_pic.Location = new System.Drawing.Point(55, 51);
            this.label_pic.Name = "label_pic";
            this.label_pic.Size = new System.Drawing.Size(97, 32);
            this.label_pic.TabIndex = 16;
            this.label_pic.Text = "Hình 1";
            // 
            // pictureBox_getPic2
            // 
            this.pictureBox_getPic2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_getPic2.Location = new System.Drawing.Point(258, 408);
            this.pictureBox_getPic2.Name = "pictureBox_getPic2";
            this.pictureBox_getPic2.Size = new System.Drawing.Size(386, 273);
            this.pictureBox_getPic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_getPic2.TabIndex = 13;
            this.pictureBox_getPic2.TabStop = false;
            // 
            // pictureBox_getPic1
            // 
            this.pictureBox_getPic1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_getPic1.Location = new System.Drawing.Point(258, 42);
            this.pictureBox_getPic1.Name = "pictureBox_getPic1";
            this.pictureBox_getPic1.Size = new System.Drawing.Size(386, 273);
            this.pictureBox_getPic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_getPic1.TabIndex = 12;
            this.pictureBox_getPic1.TabStop = false;
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(693, 51);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(200, 22);
            this.textBox_id.TabIndex = 23;
            this.textBox_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_id_KeyDown);
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Font = new System.Drawing.Font("Snap ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_price.Location = new System.Drawing.Point(687, 172);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(87, 31);
            this.label_price.TabIndex = 24;
            this.label_price.Text = "Tiền ";
            // 
            // outGateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1068, 761);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.button_removeTransport);
            this.Controls.Add(this.label_pic2);
            this.Controls.Add(this.label_pic);
            this.Controls.Add(this.pictureBox_getPic2);
            this.Controls.Add(this.pictureBox_getPic1);
            this.Name = "outGateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cổng Ra";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_getPic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_getPic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button button_removeTransport;
        public System.Windows.Forms.Label label_pic2;
        public System.Windows.Forms.Label label_pic;
        private System.Windows.Forms.PictureBox pictureBox_getPic2;
        private System.Windows.Forms.PictureBox pictureBox_getPic1;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label_price;
    }
}