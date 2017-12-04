using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kiet
{
    public partial class QuanLyDatHang : Form
    {
        DataTable dsDonHang;
        DataView dsDonHangView;
        DataTable dsMonAn;
        DataView dsMonAnView;
        DataTable dsChiNhanh;
        //DataView dsChiNhanhView;
        DataTable dsKhach;
        DataView dsKhachView;
        DataTable dsMonChon;
        public QuanLyDatHang()
        {
            InitializeComponent();
        }

        private void QuanLyDatHang_Load(object sender, EventArgs e)
        {
            lbdsMaHD.DataSource = XuLyDuLieu.docBang("Select * from HoaDon");
            //lbdsMaHD.DataSource = dsChiNhanh;
            lbdsMaHD.DisplayMember = "HD_MaMDC";
            lbdsMaHD.ValueMember = "HD_MaHD";

            lbDHC.DataSource = XuLyDuLieu.docBang("Select *from dsDonHangCho");
            lbDHC.DisplayMember = "DHC_Ma";
            lbDHC.ValueMember = "DHC_MaTD";
            /*dsDonHang = XuLyDuLieu.docBang("Select * from ThongTinHoaDon");
            dsDonHangView = new DataView(dsDonHang);
            dgvdsDSHonHang.DataSource = dsDonHangView;*/
            //dsMonAn = XuLyDuLieu.docBang("Select * from dsMon");
            //dsMonAnView = new DataView(dsMonAn);
            //dgvdsMonAn.DataSource = dsMonAnView;
            //dsChiNhanh = XuLyDuLieu.docBang("Select * from CHINHANH");
            //dsChiNhanhView = new DataView(dsChiNhanh);
            //dgvdsChiNhanh.DataSource = dsChiNhanhView;
            dsKhach = XuLyDuLieu.docBang("Select * from ThongTinKhach");
            dsKhachView = new DataView(dsKhach);
            dgvdsKhachHang.DataSource = dsKhachView;
            dgvdsKhach2.DataSource = dsKhach;

            Bingding();

            

            dsMonAn = XuLyDuLieu.docBang("Select * from dsMon");
            dsMonAnView = new DataView(dsMonAn);
            dgvThucDon.DataSource = dsMonAnView;

            dsMonChon = XuLyDuLieu.docBang("Select *from MonDaChon");
            dgvCacMonChon.DataSource = dsMonChon;

            dsDonHang = XuLyDuLieu.docBang("Select *from HoaDon");
            dgvdsDonHang2.DataSource = dsDonHang;
            dgvdsDonHang3.DataSource = dsDonHang;
            dgvdsDonHang5.DataSource = dsDonHang;


            dsDonHang = XuLyDuLieu.docBang("Select HD_MaHD,HD_MaCN,HD_DiaCHi from HoaDon");
            dgvdsDonHang4.DataSource = dsDonHang;

            dsChiNhanh = XuLyDuLieu.docBang("Select *from dsChiNhanh");
            dgvdsChiNhanh2.DataSource = dsChiNhanh;


            BindingDHC();

            int sum = 0;
            for (int i = 0; i < dgvCacMonChon.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dgvCacMonChon.Rows[i].Cells[4].Value);
            }
            textBox1.Text = sum.ToString();
        }
        /*private void btThemDH_Click(object sender, EventArgs e)
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
            if (dgvdsDSHonHang.SelectedRows.Count > 0)
            {
                DataRow dh = ((DataRowView)dgvdsDSHonHang.SelectedRows[0].DataBoundItem).Row;
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
            if (dgvdsDSHonHang.SelectedRows.Count > 0)
            {
                DataRow dh = ((DataRowView)dgvdsDSHonHang.SelectedRows[0].DataBoundItem).Row;
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
                String str = String.Format("CN_MA like '%{0}%'", tbTimCN.Text);
                dsChiNhanhView.RowFilter = str;
            }
        }*/

        private void btThemDH_Click_1(object sender, EventArgs e)
        {

        }

        private void btTimDH_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void tbTimSDT_TextChanged(object sender, EventArgs e)
        {
            if (tbTimSDT.Text == "")
            {
                dsKhachView.RowFilter = "";
            }
            else
            {
                String str = String.Format("SDT like '%{0}%'", tbTimSDT.Text);
                dsKhachView.RowFilter = str;
            }
        }
        private void Bingding()
        {
            tbTenKhach.DataBindings.Clear();
            tbTenKhach.DataBindings.Add("text", dgvdsKhachHang.DataSource, "HoTenKhach");
            tbDiaChi.DataBindings.Clear();
            tbDiaChi.DataBindings.Add("text", dgvdsKhachHang.DataSource, "DiaChi");
            tbSDT.DataBindings.Clear();
            tbSDT.DataBindings.Add("text", dgvdsKhachHang.DataSource, "SDT");


        }
        private void BindingDHC()
        {
            DHC_tbTen.DataBindings.Clear();
            DHC_tbTen.DataBindings.Add("text", lbDHC.DataSource, "DHC_TenKhach");
            DHC_tbDiaChi.DataBindings.Clear();
            DHC_tbDiaChi.DataBindings.Add("text", lbDHC.DataSource, "DHC_DiaChi");
            DHC_tbSDT.DataBindings.Clear();
            DHC_tbSDT.DataBindings.Add("text", lbDHC.DataSource, "DHC_SDT");

            CDH_Ma.DataBindings.Clear();
            CDH_Ma.DataBindings.Add("text", dgvdsDonHang3.DataSource, "HD_MaHD");
            CDH_DiaChi.DataBindings.Clear();
            CDH_DiaChi.DataBindings.Add("text", dgvdsDonHang3.DataSource, "HD_DiaCHi");
            CDH_CN.DataBindings.Clear();
            CDH_CN.DataBindings.Add("text", dgvdsChiNhanh2.DataSource, "CN_MaCN");
            CDH_Ten.DataBindings.Clear();
            CDH_Ten.DataBindings.Add("text", dgvdsDonHang3.DataSource, "HD_TenKhach");
            CDH_SDT.DataBindings.Clear();
            CDH_SDT.DataBindings.Add("text", dgvdsDonHang3.DataSource, "HD_SDT");
            CDH_MaMDC.DataBindings.Clear();
            CDH_MaMDC.DataBindings.Add("text", dgvdsDonHang3.DataSource, "HD_MaMDC");
        }

        private void tbTimThucDon_TextChanged(object sender, EventArgs e)
        {
            if (tbTimThucDon.Text == "")
            {
                dsMonAnView.RowFilter = "";
            }
            else
            {
                String str = String.Format("TenMonAn like '%{0}%'", tbTimThucDon.Text);
                dsMonAnView.RowFilter = str;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            /* if (dgvThucDon.SelectedRows.Count > 0)
             {
                 for (int i = 0; i < dgvThucDon.SelectedRows.Count; i++)
                 {
                     DataRow ma = dsMonAn.Rows[dgvThucDon.SelectedRows[i].Index];
                     int chiso = TimMATrongDSDHMA((int)ma["TenMonAn"]);
                     if (chiso == -1)
                     {
                         DataRow dhma = dsMonChon.NewRow();
                         dhma["CMDC_Loai"] = ma["Loai"];
                         dhma["CMDC_TenMon"] = ma["TenMonAn"];
                         dhma["CMDC_SoLuong"] = 1;
                         dhma["CMDC_Gia"] = ma["GiaTien"];
                         dsMonChon.Rows.Add(dhma);
                     }
                     else
                     {
                         dsMonChon.Rows[chiso]["CMDC_SoLuong"] = (int)dsMonChon.Rows[chiso]["CMDC_SoLuong"] + 1;
                     }
                 }
             }
             else
             {
                 MessageBox.Show("Anh/chi chua chon mon an", "Thong bao");
             }
         }
         int TimMATrongDSDHMA(int mma)
         {
             int kq = -1;
             for (int i = 0; i < dsMonAn.Rows.Count; i++)
             {
                 if ((int)dsMonAn.Rows[i]["TenMonAn"] == mma)
                 {
                     kq = i;
                     break;
                 }
             }
             return kq;
         }*/
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        int TongTien()
        {
            int kq = 0;
            foreach (DataRow dhma in dsMonChon.Rows)
            {
                kq = kq + (int)dhma["MDC_SoLuong"] * (int)dhma["MDC_Gia"];
            }
            return kq;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbdsMaHD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbdsMaHD_Click(object sender, EventArgs e)
        {
            string HD_MaHD = lbdsMaHD.SelectedValue.ToString();
            dgvdsDSHonHang.DataSource = XuLyDuLieu.docBang("Select * from HoaDon where (HD_MaHD='"+HD_MaHD+"')");
            dgvdsMonAn.DataSource = XuLyDuLieu.docBang("Select MDC_Loai,MDC_TenMon,MDC_SoLuong,MDC_Gia from HoaDon,MonDaChon where (HD_MaMDC=MDC_Ma and HD_MaHD='" + HD_MaHD + "')");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lbDHC_Click(object sender, EventArgs e)
        {
            string DHC_MaTD = lbDHC.SelectedValue.ToString();
            dgvdsTD2.DataSource = XuLyDuLieu.docBang("Select * from MonDaChon,dsDonHangCho where (MDC_Ma='" + DHC_MaTD + "')");
        }

        private void btThemDHC_Click(object sender, EventArgs e)
        {
            DataRow dh = dsDonHang.NewRow();
            dh["HD_MaHD"] = DHC_Ma.Text;
            dh["HD_TenKhach"] = DHC_tbTen.Text;
            dh["HD_DiaCHi"] =  DHC_tbDiaChi.Text;
            dh["HD_SDT"] = DHC_tbSDT.Text;
            dh["HD_MaMDC"] = DHC_MaTD.Text;

            dsDonHang.Rows.Add(dh);

            XuLyDuLieu.ghiBang("HoaDon", dsDonHang);
        }

        private void CDH_btSua_Click(object sender, EventArgs e)
        {
            if (dgvdsDonHang3.SelectedRows.Count > 0)
            {
                DataRow dh = ((DataRowView)dgvdsDonHang3.SelectedRows[0].DataBoundItem).Row;
                dh["HD_MaHD"] = CDH_Ma.Text;
                dh["HD_DiaCHi"] = CDH_DiaChi.Text;
                dh["HD_MaCN"] = CDH_CN.Text;
                dh["HD_TenKhach"] = CDH_Ten.Text;
                dh["HD_SDT"] = CDH_SDT.Text;
                dh["HD_MaMDC"] = CDH_MaMDC.Text;
                XuLyDuLieu.ghiBang("HoaDon", dsDonHang);
            }
            else
            {
                MessageBox.Show("Chua Chon Don Hang", "Thong Bao", MessageBoxButtons.OK);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
    }
}
