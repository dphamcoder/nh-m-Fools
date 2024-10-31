namespace HW2
{
    partial class KetThuc
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
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonChoiLai = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelChucMung = new System.Windows.Forms.Label();
            this.labelTienCuaBan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTenNguoiChoi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonThoat
            // 
            this.buttonThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonThoat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonThoat.Location = new System.Drawing.Point(22, 369);
            this.buttonThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Padding = new System.Windows.Forms.Padding(6);
            this.buttonThoat.Size = new System.Drawing.Size(125, 55);
            this.buttonThoat.TabIndex = 13;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = false;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // buttonChoiLai
            // 
            this.buttonChoiLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonChoiLai.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChoiLai.Location = new System.Drawing.Point(650, 369);
            this.buttonChoiLai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonChoiLai.Name = "buttonChoiLai";
            this.buttonChoiLai.Padding = new System.Windows.Forms.Padding(6);
            this.buttonChoiLai.Size = new System.Drawing.Size(125, 55);
            this.buttonChoiLai.TabIndex = 12;
            this.buttonChoiLai.Text = "Chơi lại";
            this.buttonChoiLai.UseVisualStyleBackColor = false;
            this.buttonChoiLai.Click += new System.EventHandler(this.buttonChoiLai_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(272, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cảm ơn đã tham gia chương trình";
            // 
            // labelChucMung
            // 
            this.labelChucMung.AutoSize = true;
            this.labelChucMung.BackColor = System.Drawing.Color.Transparent;
            this.labelChucMung.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelChucMung.ForeColor = System.Drawing.Color.White;
            this.labelChucMung.Location = new System.Drawing.Point(203, 317);
            this.labelChucMung.Name = "labelChucMung";
            this.labelChucMung.Size = new System.Drawing.Size(133, 23);
            this.labelChucMung.TabIndex = 10;
            this.labelChucMung.Text = "Đã nhận được:";
            // 
            // labelTienCuaBan
            // 
            this.labelTienCuaBan.AutoSize = true;
            this.labelTienCuaBan.BackColor = System.Drawing.Color.Transparent;
            this.labelTienCuaBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTienCuaBan.ForeColor = System.Drawing.Color.White;
            this.labelTienCuaBan.Location = new System.Drawing.Point(491, 317);
            this.labelTienCuaBan.Name = "labelTienCuaBan";
            this.labelTienCuaBan.Size = new System.Drawing.Size(105, 23);
            this.labelTienCuaBan.TabIndex = 9;
            this.labelTienCuaBan.Text = "giải thưởng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(203, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Người chơi:";
            // 
            // labelTenNguoiChoi
            // 
            this.labelTenNguoiChoi.AutoSize = true;
            this.labelTenNguoiChoi.BackColor = System.Drawing.Color.Transparent;
            this.labelTenNguoiChoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTenNguoiChoi.ForeColor = System.Drawing.Color.White;
            this.labelTenNguoiChoi.Location = new System.Drawing.Point(491, 275);
            this.labelTenNguoiChoi.Name = "labelTenNguoiChoi";
            this.labelTenNguoiChoi.Size = new System.Drawing.Size(55, 23);
            this.labelTenNguoiChoi.TabIndex = 7;
            this.labelTenNguoiChoi.Text = "name";
            // 
            // KetThuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HW2.Properties.Resources.z5975897777305_9d7681260f5e32ae1190d4e06ba9e449;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonChoiLai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelChucMung);
            this.Controls.Add(this.labelTienCuaBan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTenNguoiChoi);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "KetThuc";
            this.Text = "KetThuc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonChoiLai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelChucMung;
        private System.Windows.Forms.Label labelTienCuaBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTenNguoiChoi;
    }
}