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
            BoPhanQL bpql = new BoPhanQL();
            this.Hide();
            bpql.ShowDialog();
            this.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HoatDongDatHang hddh = new HoatDongDatHang();
            this.Hide();
            hddh.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HoatDongBanHang hdbh = new HoatDongBanHang();
            this.Hide();
            hdbh.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Web w = new Web();
            this.Hide();
            w.ShowDialog();
            this.Show();
        }
    }
}
