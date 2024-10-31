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
    public partial class KetThuc : Form
    {
        public KetThuc(string playerName,int sumindex )
        {
            InitializeComponent();
            labelTenNguoiChoi.Text = playerName;
            labelTienCuaBan.Text = sumindex.ToString();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonChoiLai_Click(object sender, EventArgs e)
        {
            Bat_Dau form = new Bat_Dau();
            this.Close();
            form.ShowDialog();
        }
    }
}
