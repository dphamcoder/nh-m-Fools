using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HW2.Platform;

namespace HW2
{
    public partial class To_Tu_Van_Tai_Cho : Form
    {
        private Question currentQuestion;
        private List<Bitmap> IMGX = new List<Bitmap>();
        private Random random = new Random();
        private List<string> distractanswer = new List<string>(); 
        public To_Tu_Van_Tai_Cho(Question question)
        {
            InitializeComponent();
            currentQuestion = question;
            UpdatePeople();
        }
        private void UpdatePeople()
        {
            string imagesFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");
            List<string> imageFiles = new List<string>(Directory.GetFiles(imagesFolderPath, "*.*")
                                             .Where(file => file.EndsWith(".jpg") ||
                                                            file.EndsWith(".png") ||
                                                            file.EndsWith(".bmp")));
            List<string> randomimagespath = new List<string>();
            for(int i = 0; i < 3 ; i++)
            {
                int index  = random.Next(imageFiles.Count);
                randomimagespath.Add(imageFiles[index]);
                Bitmap samplebitmap = new Bitmap(imageFiles[index]);
                IMGX.Add(samplebitmap);
                imageFiles.RemoveAt(index);
            }
            List<int> ints = new List<int> { 0,1, 2, 3};
            for (int i = 0; i < 3 ; i++) { 
                int index  = random.Next(ints.Count);
                distractanswer.Add(currentQuestion.Answers[index]);
                ints.RemoveAt(index);
            }
            label1P1.Text = "theo kinh nghiệm của tôi câu trả lời đúng là câu " + distractanswer[0];
            pictureBoxP1.BackgroundImage = IMGX[0];
            label2P2.Text = "theo kinh nghiệm của tôi câu trả lời đúng là câu " + distractanswer[1];
            pictureBox2P2.BackgroundImage = IMGX[1];
            label3P3.Text = "theo kinh nghiệm của tôi câu trả lời đúng là câu " + distractanswer[2];
            pictureBox3P3.BackgroundImage = IMGX[2];
        }
}
}
