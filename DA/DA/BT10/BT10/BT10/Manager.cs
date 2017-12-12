using kiet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT10
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dsMonan bpql = new dsMonan();
            this.Hide();
            bpql.ShowDialog();
            this.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            HoatDongBanHang hdbh = new HoatDongBanHang();
            this.Hide();
            hdbh.ShowDialog();
            this.Show();
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinTaiKhoan tttk = new ThongTinTaiKhoan();
            this.Hide();
            tttk.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QuanLyDatHang qldh = new QuanLyDatHang();
            this.Hide();
            qldh.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WebDatHang wdh = new WebDatHang();
            this.Hide();
            wdh.ShowDialog();
            this.Show();
        }
    }
}
