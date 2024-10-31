using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HW2.Platform;

namespace HW2
{
    public partial class Bat_Dau : Form
    {
        public Bat_Dau()
        {
            InitializeComponent();
        }

        private void buttonVaoChoi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTenNguoiChoi.Text))
            {
                MessageBox.Show("Vui lòng nhập tên người chơi!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Xử lý khi TextBox có dữ liệu
                MessageBox.Show("Chào mừng người chơi " + textBoxTenNguoiChoi.Text +
                    " đã đến với Ai Là Triệu Phú", "Ai Là Triệu Phú Online");
                Platform gameForm = new Platform(textBoxTenNguoiChoi.Text);
                gameForm.Show();
                this.Hide();
            }
        }

        private void buttonHuongDan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hướng dẫn chơi Ai là triệu phú:\n" +
                "1. Nhập tên người chơi\n" +
                "2. Trả lời các câu hỏi trong thời gian quy định\n" +
                "3. Có thể sử dụng các quyền trợ giúp\n" +
                "4. Trả lời đúng để đạt điểm cao",
                "Ai là triệu phú lore");
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có muốn thoát?", "Thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (d == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
