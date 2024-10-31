using System.Drawing;

namespace HW2
{
    partial class Platform
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Platform));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.ansbt3 = new System.Windows.Forms.Button();
            this.ansbt2 = new System.Windows.Forms.Button();
            this.ansbt4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.playerLabel = new System.Windows.Forms.Label();
            this.ansbt1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.QuestionLB = new System.Windows.Forms.Label();
            this.ValueLB = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.advisedt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-88, 336);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 28;
            // 
            // ansbt3
            // 
            this.ansbt3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ansbt3.BackColor = System.Drawing.SystemColors.Control;
            this.ansbt3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ansbt3.ForeColor = System.Drawing.Color.MediumBlue;
            this.ansbt3.Location = new System.Drawing.Point(349, 462);
            this.ansbt3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ansbt3.Name = "ansbt3";
            this.ansbt3.Size = new System.Drawing.Size(501, 121);
            this.ansbt3.TabIndex = 31;
            this.ansbt3.Text = "Answer 3";
            this.ansbt3.UseVisualStyleBackColor = false;
            this.ansbt3.Click += new System.EventHandler(this.ansbt3_Click);
            // 
            // ansbt2
            // 
            this.ansbt2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ansbt2.BackColor = System.Drawing.SystemColors.Control;
            this.ansbt2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ansbt2.ForeColor = System.Drawing.Color.MediumBlue;
            this.ansbt2.Location = new System.Drawing.Point(941, 281);
            this.ansbt2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ansbt2.Name = "ansbt2";
            this.ansbt2.Size = new System.Drawing.Size(501, 121);
            this.ansbt2.TabIndex = 32;
            this.ansbt2.Text = "Answer 2";
            this.ansbt2.UseVisualStyleBackColor = false;
            this.ansbt2.Click += new System.EventHandler(this.ansbt2_Click);
            // 
            // ansbt4
            // 
            this.ansbt4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ansbt4.BackColor = System.Drawing.SystemColors.Control;
            this.ansbt4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ansbt4.ForeColor = System.Drawing.Color.MediumBlue;
            this.ansbt4.Location = new System.Drawing.Point(941, 460);
            this.ansbt4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ansbt4.Name = "ansbt4";
            this.ansbt4.Size = new System.Drawing.Size(501, 126);
            this.ansbt4.TabIndex = 33;
            this.ansbt4.Text = "Answer 4";
            this.ansbt4.UseVisualStyleBackColor = false;
            this.ansbt4.Click += new System.EventHandler(this.ansbt4_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(343, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(609, 39);
            this.label1.TabIndex = 35;
            this.label1.Text = " Câu Hỏi Số 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.playerLabel.ForeColor = System.Drawing.Color.White;
            this.playerLabel.Location = new System.Drawing.Point(21, 529);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(105, 19);
            this.playerLabel.TabIndex = 36;
            this.playerLabel.Text = "Người Chơi: ";
            // 
            // ansbt1
            // 
            this.ansbt1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ansbt1.BackColor = System.Drawing.SystemColors.Control;
            this.ansbt1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ansbt1.ForeColor = System.Drawing.Color.MediumBlue;
            this.ansbt1.Location = new System.Drawing.Point(349, 281);
            this.ansbt1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ansbt1.Name = "ansbt1";
            this.ansbt1.Size = new System.Drawing.Size(501, 121);
            this.ansbt1.TabIndex = 30;
            this.ansbt1.Text = "Answer 1";
            this.ansbt1.UseVisualStyleBackColor = false;
            this.ansbt1.Click += new System.EventHandler(this.ansbt1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button4.Location = new System.Drawing.Point(13, 610);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(171, 60);
            this.button4.TabIndex = 37;
            this.button4.Text = "Dừng cuộc chơi";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // QuestionLB
            // 
            this.QuestionLB.BackColor = System.Drawing.Color.Transparent;
            this.QuestionLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuestionLB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuestionLB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.QuestionLB.ForeColor = System.Drawing.Color.White;
            this.QuestionLB.Location = new System.Drawing.Point(349, 128);
            this.QuestionLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuestionLB.Name = "QuestionLB";
            this.QuestionLB.Size = new System.Drawing.Size(1095, 116);
            this.QuestionLB.TabIndex = 38;
            this.QuestionLB.Text = "Câu Hỏi";
            // 
            // ValueLB
            // 
            this.ValueLB.AutoSize = true;
            this.ValueLB.BackColor = System.Drawing.Color.Transparent;
            this.ValueLB.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ValueLB.ForeColor = System.Drawing.Color.White;
            this.ValueLB.Location = new System.Drawing.Point(21, 566);
            this.ValueLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ValueLB.Name = "ValueLB";
            this.ValueLB.Size = new System.Drawing.Size(129, 19);
            this.ValueLB.TabIndex = 39;
            this.ValueLB.Text = "Số tiền của bạn: ";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Lime;
            this.button3.Image = global::HW2.Properties.Resources.Y_Kien_K_Gia;
            this.button3.Location = new System.Drawing.Point(213, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 50);
            this.button3.TabIndex = 20;
            this.button3.Text = "Tư vấn";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Image = global::HW2.Properties.Resources.Goi_Nguoi_Than;
            this.button2.Location = new System.Drawing.Point(107, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 50);
            this.button2.TabIndex = 19;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 507);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(283, 185);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Image = global::HW2.Properties.Resources._50_50;
            this.button1.Location = new System.Drawing.Point(-1, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 50);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::HW2.Properties.Resources.Moc_Tro_Choi;
            this.pictureBox1.Image = global::HW2.Properties.Resources.Moc_Tro_Choi;
            this.pictureBox1.Location = new System.Drawing.Point(3, 50);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 455);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button5.Location = new System.Drawing.Point(1329, 610);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(171, 60);
            this.button5.TabIndex = 40;
            this.button5.Text = "Tiếp Tục";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // advisedt
            // 
            this.advisedt.Location = new System.Drawing.Point(289, 619);
            this.advisedt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.advisedt.Name = "advisedt";
            this.advisedt.Size = new System.Drawing.Size(100, 46);
            this.advisedt.TabIndex = 41;
            this.advisedt.Text = "Lời Khuyên ";
            this.advisedt.UseVisualStyleBackColor = true;
            this.advisedt.Click += new System.EventHandler(this.advisedt_Click);
            // 
            // Platform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::HW2.Properties.Resources.z5976608481621_b67ea525937a4f2a9ae2bcf98ccbe36a;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1511, 683);
            this.Controls.Add(this.advisedt);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.ValueLB);
            this.Controls.Add(this.QuestionLB);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ansbt4);
            this.Controls.Add(this.ansbt2);
            this.Controls.Add(this.ansbt3);
            this.Controls.Add(this.ansbt1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Platform";
            this.Text = "Millionaire";
            this.Load += new System.EventHandler(this.Platform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ansbt1;
        private System.Windows.Forms.Button ansbt3;
        private System.Windows.Forms.Button ansbt2;
        private System.Windows.Forms.Button ansbt4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label QuestionLB;
        private System.Windows.Forms.Label ValueLB;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button advisedt;
    }
}

