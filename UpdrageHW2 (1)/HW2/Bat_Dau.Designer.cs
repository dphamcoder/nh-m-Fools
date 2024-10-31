namespace HW2
{
    partial class Bat_Dau
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
            this.label2 = new System.Windows.Forms.Label();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonHuongDan = new System.Windows.Forms.Button();
            this.textBoxTenNguoiChoi = new System.Windows.Forms.TextBox();
            this.buttonVaoChoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(415, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nhập tên của bạn:";
            // 
            // buttonThoat
            // 
            this.buttonThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonThoat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonThoat.ForeColor = System.Drawing.Color.Black;
            this.buttonThoat.Location = new System.Drawing.Point(26, 453);
            this.buttonThoat.Margin = new System.Windows.Forms.Padding(4);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Padding = new System.Windows.Forms.Padding(6);
            this.buttonThoat.Size = new System.Drawing.Size(125, 55);
            this.buttonThoat.TabIndex = 9;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = false;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // buttonHuongDan
            // 
            this.buttonHuongDan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHuongDan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonHuongDan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHuongDan.ForeColor = System.Drawing.Color.Black;
            this.buttonHuongDan.Location = new System.Drawing.Point(804, 453);
            this.buttonHuongDan.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHuongDan.Name = "buttonHuongDan";
            this.buttonHuongDan.Padding = new System.Windows.Forms.Padding(6);
            this.buttonHuongDan.Size = new System.Drawing.Size(125, 55);
            this.buttonHuongDan.TabIndex = 8;
            this.buttonHuongDan.Text = "Hướng dẫn";
            this.buttonHuongDan.UseVisualStyleBackColor = false;
            this.buttonHuongDan.Click += new System.EventHandler(this.buttonHuongDan_Click);
            // 
            // textBoxTenNguoiChoi
            // 
            this.textBoxTenNguoiChoi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTenNguoiChoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTenNguoiChoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenNguoiChoi.Location = new System.Drawing.Point(304, 306);
            this.textBoxTenNguoiChoi.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTenNguoiChoi.Multiline = true;
            this.textBoxTenNguoiChoi.Name = "textBoxTenNguoiChoi";
            this.textBoxTenNguoiChoi.Size = new System.Drawing.Size(347, 36);
            this.textBoxTenNguoiChoi.TabIndex = 7;
            // 
            // buttonVaoChoi
            // 
            this.buttonVaoChoi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonVaoChoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonVaoChoi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonVaoChoi.ForeColor = System.Drawing.Color.Black;
            this.buttonVaoChoi.Location = new System.Drawing.Point(401, 350);
            this.buttonVaoChoi.Margin = new System.Windows.Forms.Padding(4);
            this.buttonVaoChoi.Name = "buttonVaoChoi";
            this.buttonVaoChoi.Padding = new System.Windows.Forms.Padding(6);
            this.buttonVaoChoi.Size = new System.Drawing.Size(161, 55);
            this.buttonVaoChoi.TabIndex = 6;
            this.buttonVaoChoi.Text = "Vào chơi";
            this.buttonVaoChoi.UseVisualStyleBackColor = false;
            this.buttonVaoChoi.Click += new System.EventHandler(this.buttonVaoChoi_Click);
            // 
            // Bat_Dau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HW2.Properties.Resources.z5975897777451_b436cb163d203831601012e3b18a7057;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(954, 532);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonHuongDan);
            this.Controls.Add(this.textBoxTenNguoiChoi);
            this.Controls.Add(this.buttonVaoChoi);
            this.Name = "Bat_Dau";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonHuongDan;
        private System.Windows.Forms.TextBox textBoxTenNguoiChoi;
        private System.Windows.Forms.Button buttonVaoChoi;
    }
}