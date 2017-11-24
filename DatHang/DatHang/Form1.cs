using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatHang
{
    public partial class Form1 : Form
    {
        DataTable dsDonHang;
        DataView dsDonHangView; 
        DataTable dsMonAn;
        DataView dsMonAnView;
        DataTable dsChiNhanh;
        DataView dsChiNhanhView;
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dsDonHang = XuLyDuLieu.docBang("Select * from ThongTinHoaDon");
            dsDonHangView = new DataView(dsDonHang);
            dgvdsDonHang.DataSource = dsDonHangView;
            dsMonAn = XuLyDuLieu.docBang("Select * from dsMon");
            dsMonAnView = new DataView(dsMonAn);
            dgvdsMonAn.DataSource = dsMonAnView;
            dsChiNhanh = XuLyDuLieu.docBang("Select * from dsChiNhanh");
            dsChiNhanhView = new DataView(dsChiNhanh);
            dgvdsChiNhanh.DataSource = dsChiNhanhView;
        }

        private void btThemDH_Click(object sender, EventArgs e)
        {
            DataRow dh = dsDonHang.NewRow();
            dh["MA_CN"] = tbMaCN.Text;
            dh["Ma_HD"] = tbMaDH.Text;
            dh["GIATIEN"] = tbGia.Text;
            

            dsDonHang.Rows.Add(dh);

            XuLyDuLieu.ghiBang("ThongTinHoaDon", dsDonHang);
        }

        private void btSuaDH_Click(object sender, EventArgs e)
        {
            if (dgvdsDonHang.SelectedRows.Count > 0)
            {
                DataRow dh = ((DataRowView)dgvdsDonHang.SelectedRows[0].DataBoundItem).Row;
                dh["MA_CN"] = tbMaCN.Text;
                dh["Ma_HD"] = tbMaDH.Text;
                dh["GIATIEN"] = tbGia.Text;
                XuLyDuLieu.ghiBang("ThongTinHoaDon", dsDonHang);
            }
            else
            {
                MessageBox.Show("Chua Chon Don Hang", "Thong Bao", MessageBoxButtons.OK);
            }
        }

        private void btXoaDH_Click(object sender, EventArgs e)
        {
            if (dgvdsDonHang.SelectedRows.Count > 0)
            {
                DataRow dh = ((DataRowView)dgvdsDonHang.SelectedRows[0].DataBoundItem).Row;
                dh.Delete();
                XuLyDuLieu.ghiBang("ThongTinHoaDon", dsDonHang);
            }
        }

        private void btTimDH_TextChanged(object sender, EventArgs e)
        {
            if (btTimDH.Text == "")
            {
                dsDonHangView.RowFilter = "";
            }
            else
            {
                String str = String.Format("MA_HD like '%{0}%'", btTimDH.Text);
                dsDonHangView.RowFilter = str;
            }
        }

        private void tbTimMon_TextChanged(object sender, EventArgs e)
        {
            if (tbTimMon.Text == "")
            {
                dsMonAnView.RowFilter = "";
            }
            else
            {
                String str = String.Format("MA_MA like '%{0}%'", tbTimMon.Text);
                dsMonAnView.RowFilter = str;
            }
        }

        private void tbTimCN_TextChanged(object sender, EventArgs e)
        {
            if (tbTimCN.Text == "")
            {
                dsChiNhanhView.RowFilter = "";
            }
            else
            {
                String str = String.Format("MA_CN like '%{0}%'", tbTimCN.Text);
                dsChiNhanhView.RowFilter = str;
            }
        }
    }
}
