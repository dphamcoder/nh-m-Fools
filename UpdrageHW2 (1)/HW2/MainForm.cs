using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace HW2
{
    
    public partial class Platform : Form
    {
        private bool isReadyForNextQuestion = false;
        private string playerName;
        private List<int> listofindex = new List<int>();
        private List<int> listofcurrindex = new List<int>();
        private int i;
        private int currindex = 0;
        private List<Question> list;
        private int correctindex = 0;
        private List<Button> answerButtons;
        private List<int> numbers = new List<int>
            {
                150000, 85000, 60000, 40000, 30000, 22000,
                14000, 10000, 6000, 3000, 2000, 1000,
                600, 400, 200 , 0
            };
        private int sum = 0;
        private List<string> advisedlist = new List<string>();

        void createadvise()
        {
            string[] lines = File.ReadAllLines("Advised.txt");
            for (int i = 0; i < lines.Length ; i++)
            {
                advisedlist.Add(lines[i]);
            }
        }


        public Platform(string name)
        {
            InitializeComponent();
            numbers.Reverse();
            createadvise();
            playerName = name;
            answerButtons = new List<Button> { ansbt1, ansbt2, ansbt3, ansbt4 };
            list = ReadQuestion();
            createlist();
            randomindex();
            resetquestion(i, list);
            timer1.Enabled = !timer1.Enabled;
            playerLabel.Text = "Người chơi: " + playerName;

            button5.Enabled = false;
        }
        
        // Tạo chỉ số câu hỏi ngẫu nhiên từ danh sách hiện tại
        void randomindex()
        {
            if (listofcurrindex.Count > 0)
            {
                Random random = new Random();
                int randomIndex = random.Next(listofcurrindex.Count);
                i = listofcurrindex[randomIndex];
                listofcurrindex.RemoveAt(randomIndex);
            }
        }

        // Tạo danh sách các chỉ số câu hỏi ban đầu
        void createlist()
        {
            for (int index = 0; index < 17 && listofindex.Count > 0; index++)
            {
                Random random = new Random();
                int randomIndex = random.Next(listofindex.Count);
                listofcurrindex.Add(listofindex[randomIndex]);
                listofindex.RemoveAt(randomIndex);
            }
        }

        // Thiết lập lại câu hỏi với chỉ số đã cho
        public void resetquestion(int i, List<Question> list)
        {
            if (listofcurrindex.Count == 1)
            {
                MessageBox.Show("bạn đã kết thúc cuộc chơi kết quả của bạn là :" + correctindex.ToString() + " câu đúng ");
                Application.Exit();
            }
            if (i >= 0 && i < list.Count)
            {
                // Reset màu và hiển thị tất cả các button
                foreach (var button in answerButtons)
                {
                    button.Visible = true;
                    button.BackColor = SystemColors.ControlLight; // Màu mặc định
                }

                ansbt1.Text = list[i].Answers[0];
                ansbt2.Text = list[i].Answers[1];
                ansbt3.Text = list[i].Answers[2];
                ansbt4.Text = list[i].Answers[3];
                QuestionLB.Text = list[i].Name;
                currindex++;
                label1.Text = "Câu Hỏi Số : " + currindex.ToString();
                sum += numbers[correctindex];
                ValueLB.Text = "Số tiền hiện tại bạn có: " + sum.ToString();
            }
        }
        

        private void HandleAnswerClick(Button clickedButton)
        {
            if (isReadyForNextQuestion) return; // Prevent multiple answers

            string chosenAnswer = clickedButton.Text;

            // Tìm button chứa đáp án đúng
            Button correctButton = answerButtons.Find(btn => btn.Text == list[i].Solution);

            if (list[i].IsCorrectAnswer(chosenAnswer))
            {
                clickedButton.BackColor = Color.Cyan; // Câu đúng màu xanh
                correctindex++;
                // Enable nút chuyển câu hỏi
                button5.Enabled = true;
                isReadyForNextQuestion = true;

                // Disable tất cả các button trả lời
                foreach (var button in answerButtons)
                {
                    button.Enabled = false;
                }
            }
            else
            {
                DialogResult result = MessageBox.Show(advisedlist[i], "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {

                    KetThuc form = new KetThuc(playerName, sum);
                    this.Close();
                    form.ShowDialog();
                }
            }
        }
        // Đọc danh sách câu hỏi từ file "QuestionBank.txt"
        public List<Question> ReadQuestion()
        {
            List<Question> lsq = new List<Question>();
            string[] lines = File.ReadAllLines("QuestionBank.txt");

            for (int index = 0; index < lines.Length; index += 4)
            {
                string Qname = lines[index];
                List<string> Qanslist = new List<string>(lines[index + 1].Split(';'));
                string Qsol = lines[index + 2];

                lsq.Add(new Question(Qname, Qanslist, Qsol));
                listofindex.Add(lsq.Count - 1);
            }
            return lsq;
        }

        // Định nghĩa lớp Question
        public class Question
        {
            public string Name { get; set; }
            public List<string> Answers { get; set; }
            public string Solution { get; set; }

            public Question(string name, List<string> answers, string solution)
            {
                Name = name;
                Answers = answers;
                Solution = solution;
            }

            public bool IsCorrectAnswer(string ans)
            {
                return ans == Solution;
            }
        }

        // Xử lý sự kiện khi nhấn button ansbt1
        private void ansbt1_Click(object sender, EventArgs e)
        {
            HandleAnswerClick(ansbt1);
        }

        // Xử lý sự kiện khi nhấn button ansbt2
        private void ansbt2_Click(object sender, EventArgs e)
        {
            HandleAnswerClick(ansbt2);
        }

        // Xử lý sự kiện khi nhấn button ansbt3
        private void ansbt3_Click(object sender, EventArgs e)
        {
            HandleAnswerClick(ansbt3);
        }

        // Xử lý sự kiện khi nhấn button ansbt4
        private void ansbt4_Click(object sender, EventArgs e)
        {
            HandleAnswerClick(ansbt4);
        }

        // Kiểm tra đáp án người dùng đã chọn
        private void CheckAnswer(string chosenAnswer)
        {
            if (list[i].IsCorrectAnswer(chosenAnswer))  correctindex++;
            
        }

        // Xử lý sự kiện khi nhấn button trợ giúp (giấu đáp án sai)
        private void button1_Click(object sender, EventArgs e)
        {
            List<Button> wrongButtons = new List<Button>();
            foreach (var button in answerButtons)
            {
                if (!list[i].IsCorrectAnswer(button.Text))
                {
                    wrongButtons.Add(button);
                }
            }

            Random random = new Random();
            for (int j = 0; j < 2 && wrongButtons.Count > 0; j++)
            {
                int index = random.Next(wrongButtons.Count);
                wrongButtons[index].Enabled = false; // Disable thay vì ẩn
                wrongButtons.RemoveAt(index);
            }
            button1.Enabled = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Goi_Nguoi_Than helpForm = new Goi_Nguoi_Than(list[i]);
            helpForm.ShowDialog();

            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            To_Tu_Van_Tai_Cho tuVan = new To_Tu_Van_Tai_Cho(list[i]);
            tuVan.ShowDialog();

            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KetThuc form = new KetThuc(playerName, sum);
            this.Close();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!isReadyForNextQuestion) return;

            // Enable lại các button trả lời
            foreach (var button in answerButtons)
            {
                button.Enabled = true;
                button.BackColor = SystemColors.ControlLight;
            }

            // Chuyển sang câu hỏi mới
            randomindex();
            resetquestion(i, list);

            // Reset trạng thái
            isReadyForNextQuestion = false;
            button5.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void advisedt_Click(object sender, EventArgs e)
        {
            MessageBox.Show(advisedlist[i]);
            advisedt.Enabled = false;
        }

        private void Platform_Load(object sender, EventArgs e)
        {

        }
    }
}
