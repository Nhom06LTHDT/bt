using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnLan2
{
    public partial class TongDai : Form
    {
        public TongDai()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TaoDonHang tao = new TaoDonHang();
            this.Hide();
            tao.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChuyenDonHang cdh = new ChuyenDonHang();
            this.Hide();
            cdh.ShowDialog();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TinhTrangDonHang ttdh = new TinhTrangDonHang();
            this.Hide();
            ttdh.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Quanlydonhang qldh = new Quanlydonhang();
            this.Close();
        }

    }
}
