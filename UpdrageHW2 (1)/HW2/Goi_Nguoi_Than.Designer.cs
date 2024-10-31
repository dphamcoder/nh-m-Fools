namespace HW2
{
    partial class Goi_Nguoi_Than
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Goi_Nguoi_Than));
            this.okButton = new System.Windows.Forms.Button();
            this.questionContent = new System.Windows.Forms.Label();
            this.questionAnswer = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okButton
            // 
            resources.ApplyResources(this.okButton, "okButton");
            this.okButton.BackColor = System.Drawing.Color.IndianRed;
            this.okButton.Name = "okButton";
            this.okButton.UseVisualStyleBackColor = false;
            // 
            // questionContent
            // 
            this.questionContent.BackColor = System.Drawing.Color.RosyBrown;
            resources.ApplyResources(this.questionContent, "questionContent");
            this.questionContent.Name = "questionContent";
            // 
            // questionAnswer
            // 
            this.questionAnswer.BackColor = System.Drawing.Color.RosyBrown;
            resources.ApplyResources(this.questionAnswer, "questionAnswer");
            this.questionAnswer.Name = "questionAnswer";
            // 
            // questionLabel
            // 
            this.questionLabel.BackColor = System.Drawing.Color.RosyBrown;
            resources.ApplyResources(this.questionLabel, "questionLabel");
            this.questionLabel.Name = "questionLabel";
            // 
            // Goi_Nguoi_Than
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::HW2.Properties.Resources._1_person_playing_Who_Wants_to_Be_a_Millionaire__1_person_calling_from_home_to_help__2_people_on_opposite_sides_of_the_picture__aspect_ratio_16_9;
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.questionAnswer);
            this.Controls.Add(this.questionContent);
            this.Controls.Add(this.okButton);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Goi_Nguoi_Than";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label questionContent;
        private System.Windows.Forms.Label questionAnswer;
        private System.Windows.Forms.Label questionLabel;
    }
}