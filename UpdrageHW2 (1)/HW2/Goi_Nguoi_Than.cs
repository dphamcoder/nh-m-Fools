using System;
using System.Drawing;
using System.Windows.Forms;
using static HW2.Platform;

namespace HW2
{
    public partial class Goi_Nguoi_Than : Form
    {
        private Question currentQuestion;
        public Goi_Nguoi_Than(Question question)
        {
            InitializeComponent();
            currentQuestion = question;
            questionContent.Text = $"Câu hỏi là: {currentQuestion.Name}";
            questionAnswer.Text = $"Cái gì!!!\n Câu này mà mày cũng hỏi tao à.\n" +
                $"Đáp án là: {currentQuestion.Solution} nha em";

            okButton.Click += OkButton_Click;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Text = $"Đại ca ơi!!!! Giúp em câu này với: ";
            Font = new Font("Arial", 12, FontStyle.Regular);
            ForeColor = Color.Aqua;
            AutoSize = true;
        }
    }
}
