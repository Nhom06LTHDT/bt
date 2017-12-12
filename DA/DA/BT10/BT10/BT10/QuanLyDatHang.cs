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
        DataTable dsDonHangChoDuyet;
        DataView dsDonHangView;
        DataTable dsMonAn;
        DataView dsMonAnView;
        DataTable dsChiNhanh;
        //DataView dsChiNhanhView;
        DataTable dsKhach;
        DataView dsKhachView;
        DataTable dsMonChon;

        int j = 1;
        int i = 0;
        public QuanLyDatHang()
        {
            InitializeComponent();
        }

        private void QuanLyDatHang_Load(object sender, EventArgs e)
        {
            lbdsMaHD.DataSource = XuLyDuLieu.docBang("Select * from HoaDon");
            //lbdsMaHD.DataSource = dsChiNhanh;
            lbdsMaHD.DisplayMember = "HD_MaHD";
            lbdsMaHD.ValueMember = "HD_MaHD";

            lbDHC.DataSource = XuLyDuLieu.docBang("Select *from dsDonHangCho");
            lbDHC.DisplayMember = "DHC_Ma";
            lbDHC.ValueMember = "DHC_Ma";
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
            dgvdsKhach2.DataSource = dsKhachView;

            Bingding();

            

            /*dsMonAn = XuLyDuLieu.docBang("Select * from dsMon");
            dsMonAnView = new DataView(dsMonAn);
            dgvThucDon.DataSource = dsMonAnView;*/

            dsMonAn = XuLyDuLieu.docBang("Select * from MonBo");
            dsMonAnView = new DataView(dsMonAn);
            dgvThucDon.DataSource = dsMonAnView;

            //dsMonChon = XuLyDuLieu.docBang("Select *from MonDaChon");
            //dgvCacMonChon.DataSource = dsMonChon;

            

            //dsDonHang = XuLyDuLieu.docBang("Select * from HoaDon");
            //dsDonHangView = new DataView(dsDonHang);
            //dgvdsDonHang3.DataSource = dsDonHangView;

            dsDonHang = XuLyDuLieu.docBang("Select *from HoaDon");
            dgvdsDonHang2.DataSource = dsDonHang;
            dgvdsDonHang5.DataSource = dsDonHang;
            dsDonHangView = new DataView(dsDonHang);
            dgvdsDonHang3.DataSource = dsDonHangView;
            dgvdsDSHonHang.DataSource = dsDonHang;




            dsDonHangChoDuyet = XuLyDuLieu.docBang("Select HD_MaHD,HD_MaCN,HD_DiaCHi from HoaDon");
            dgvdsDonHang4.DataSource = dsDonHangChoDuyet;

            dsChiNhanh = XuLyDuLieu.docBang("Select *from dsChiNhanh");
            dgvdsChiNhanh2.DataSource = dsChiNhanh;


            BindingDHC();

            /*if (int.Parse(tbSoLanDat.Text) >= 2)
            {
                tbGiam.Text = "5";
            }*/

            /*int sum = 0;
            for (int i = 0; i < lvCMDC.Rows.Count; i++)
           {
                sum += Convert.ToInt32(lvCMDC.Rows[i].Cells[3].Value);
            }
            textBox1.Text = sum.ToString();*/
        }
        private void tongTien()
        {
            int t = 0;
            for(int n =0; n<i;n++)
            {
                t = t + int.Parse(lvCMDC.Items[n].SubItems[2].Text);
                tbTien.Text = (t).ToString();
            }
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
            tbSoLanDat.DataBindings.Clear();
            tbSoLanDat.DataBindings.Add("text", dgvdsKhachHang.DataSource, "SoLanDat");


        }
        private void BindingDHC()
        {
            DHC_tbTen.DataBindings.Clear();
            DHC_tbTen.DataBindings.Add("text", lbDHC.DataSource, "DHC_TenKhach");
            DHC_tbDiaChi.DataBindings.Clear();
            DHC_tbDiaChi.DataBindings.Add("text", lbDHC.DataSource, "DHC_DiaChi");
            DHC_tbSDT.DataBindings.Clear();
            DHC_tbSDT.DataBindings.Add("text", lbDHC.DataSource, "DHC_SDT");
            DHC_Gia.DataBindings.Clear();
            DHC_Gia.DataBindings.Add("text", lbDHC.DataSource, "DHC_Gia");


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
            CDH_Gia.DataBindings.Clear();
            CDH_Gia.DataBindings.Add("text", dgvdsDonHang3.DataSource, "HD_Gia");

            TD_MaDH.DataBindings.Clear();
            TD_MaDH.DataBindings.Add("text", dgvdsDonHang5.DataSource, "HD_MaHD");
            TD_DiaChi.DataBindings.Clear();
            TD_DiaChi.DataBindings.Add("text", dgvdsDonHang5.DataSource, "HD_DiaCHi");
            TD_MaCN.DataBindings.Clear();
            TD_MaCN.DataBindings.Add("text", dgvdsDonHang5.DataSource, "HD_MaCN");
            TD_Ten.DataBindings.Clear();
            TD_Ten.DataBindings.Add("text", dgvdsDonHang5.DataSource, "HD_TenKhach");
            TD_SDT.DataBindings.Clear();
            TD_SDT.DataBindings.Add("text", dgvdsDonHang5.DataSource, "HD_SDT");
            TD_Gia.DataBindings.Clear();
            TD_Gia.DataBindings.Add("text", dgvdsDonHang5.DataSource, "HD_Gia");

            



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
            /*if(int.Parse(tbTien.Text) >= 5 )
            {
                tbUuDai.Text = "10";
            }
            else
            {
                tbUuDai.Text = "0";
            }*/
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
            //dgvdsMonAn.DataSource = XuLyDuLieu.docBang("Select MDC_Loai,MDC_TenMon,MDC_SoLuong,MDC_Gia from HoaDon,MonDaChon where (HD_MaHD=MDC_Ma and HD_MaHD='" + HD_MaHD + "')");

            tbDHMaDH.DataBindings.Clear();
            tbDHMaDH.DataBindings.Add("text", lbdsMaHD.DataSource, "HD_MaHD");
            tbDHDiaChi.DataBindings.Clear();
            tbDHDiaChi.DataBindings.Add("text", lbdsMaHD.DataSource, "HD_DiaCHi");
            tbDHMaCN.DataBindings.Clear();
            tbDHMaCN.DataBindings.Add("text", lbdsMaHD.DataSource, "HD_MaCN");
            tbDHTen.DataBindings.Clear();
            tbDHTen.DataBindings.Add("text", lbdsMaHD.DataSource, "HD_TenKhach");
            tbDHSDT.DataBindings.Clear();
            tbDHSDT.DataBindings.Add("text", lbdsMaHD.DataSource, "HD_SDT");
            tbDHTien.DataBindings.Clear();
            tbDHTien.DataBindings.Add("text", lbdsMaHD.DataSource, "HD_Gia");
            tbDHTinhTrang.DataBindings.Clear();
            tbDHTinhTrang.DataBindings.Add("text", lbdsMaHD.DataSource, "HD_TinhTrang");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow dh = dsDonHang.NewRow();
            dh["HD_MaHD"] = tbMa.Text;
            dh["HD_DiaCHi"] = tbDiaChi.Text;
            dh["HD_TenKhach"] = tbTenKhach.Text;
            dh["HD_SDT"] = tbSDT.Text;
            dh["HD_Gia"] = tbTongTien.Text;


            dsDonHang.Rows.Add(dh);

            XuLyDuLieu.ghiBang("HoaDon", dsDonHang);

            MessageBox.Show("Bạn Đã Tạo Đơn Hàng Thành Công!!", "Thong Bao", MessageBoxButtons.OK);
        }

        private void lbDHC_Click(object sender, EventArgs e)
        {
            string DHC_Ma = lbDHC.SelectedValue.ToString();
            dgvdsTD2.DataSource = XuLyDuLieu.docBang("Select MDC_Loai,MDC_TenMon,MDC_SoLuong,MDC_Gia from MonDaChon,dsDonHangCho where (DHC_Ma=MDC_Ma and MDC_Ma='" + DHC_Ma + "')");
            //dgvdsMonAn.DataSource = XuLyDuLieu.docBang("Select MDC_Loai,MDC_TenMon,MDC_SoLuong,MDC_Gia from HoaDon,MonDaChon where (HD_MaHD=MDC_Ma and HD_MaHD='" + HD_MaHD + "')");
        }

        /*private void btThemDHC_Click(object sender, EventArgs e)
        {
            DataRow dh = dsDonHang.NewRow();
            dh["HD_MaHD"] = DHC_Ma.Text;
            dh["HD_TenKhach"] = DHC_tbTen.Text;
            dh["HD_DiaCHi"] =  DHC_tbDiaChi.Text;
            dh["HD_SDT"] = DHC_tbSDT.Text;
            dh["HD_MaMDC"] = DHC_MaTD.Text;
            dh["HD_TinhTrang"] = DHC_TinhTrang.Text;

            dsDonHang.Rows.Add(dh);

            XuLyDuLieu.ghiBang("HoaDon", dsDonHang);
        }*/

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
                dh["HD_Gia"] = CDH_Gia.Text;
                dh["HD_TinhTrang"] = CDH_TinhTrang.Text;
                XuLyDuLieu.ghiBang("HoaDon", dsDonHang);
            }
            else
            {
                MessageBox.Show("Chua Chon Don Hang", "Thong Bao", MessageBoxButtons.OK);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvdsDonHang5.SelectedRows.Count > 0)
            {
                DataRow dh = ((DataRowView)dgvdsDonHang5.SelectedRows[0].DataBoundItem).Row;
                dh["HD_MaHD"] = TD_MaDH.Text;
                dh["HD_DiaCHi"] = TD_DiaChi.Text;
                dh["HD_MaCN"] = TD_MaCN.Text;
                dh["HD_TenKhach"] = TD_Ten.Text;
                dh["HD_SDT"] = TD_SDT.Text;
                dh["HD_Gia"] = TD_Gia.Text;
                dh["HD_TinhTrang"] = TD_TinhTrang.Text;
                XuLyDuLieu.ghiBang("HoaDon", dsDonHang);

                MessageBox.Show("Đã thay đổi tình trạng đơn hàng", "Thong Bao", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Chua Chon Don Hang", "Thong Bao", MessageBoxButtons.OK);
            }
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void lvCMDC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(dgvThucDon.SelectedRows.Count ==1)
            {
                ListViewItem m = new ListViewItem();
                int k;
                for(k=0;k<i;k++)
                {
                    m = lvCMDC.Items[k];
                    if(dgvThucDon.SelectedRows[0].Cells["TenMonAn"].Value.ToString() == m.Text)
                    {
                        j++;
                        lvCMDC.Items[k].SubItems[1].Text = j.ToString();
                        int cost = int.Parse(dgvThucDon.SelectedRows[0].Cells["GiaTien"].Value.ToString()) * j;
                        lvCMDC.Items[k].SubItems[2].Text = cost.ToString();
                        break;
                    }
                }
                if(k==i)
                {
                    AddItem();
                }
                tongTien();
            }
            
        }
        private void AddItem()
        {
                j = 1;
                lvCMDC.Items.Add(dgvThucDon.SelectedRows[0].Cells["TenMonAn"].Value.ToString());
                lvCMDC.Items[i].SubItems.Add("1");
                lvCMDC.Items[i].SubItems.Add(dgvThucDon.SelectedRows[0].Cells["GiaTien"].Value.ToString());
                i++;
            
        }

        private void XoaMDC_Click(object sender, EventArgs e)
        {

            while (lvCMDC.SelectedItems.Count > 0)
            {
                lvCMDC.Items.Remove(lvCMDC.SelectedItems[0]);
                i--;
            }
            tongTien();
        }

        private void GiamMDC_Click(object sender, EventArgs e)
        {
            if (lvCMDC.SelectedItems.Count == 1)
            {
                int soluong = int.Parse((lvCMDC.SelectedItems[0].SubItems[1].Text));

                if (soluong > 1)
                {
                    ListViewItem t;
                    t = lvCMDC.SelectedItems[0];
                    int dongia = 1;
                    for (int i = 0; i < dgvThucDon.Rows.Count; i++)
                    {
                        if (t.Text == dgvThucDon.Rows[i].Cells["TenMonAn"].Value.ToString())
                        {
                            dongia = Convert.ToInt32(dgvThucDon.Rows[i].Cells["GiaTien"].Value.ToString());
                            break;
                        }
                    }

                    lvCMDC.SelectedItems[0].SubItems[1].Text = (--soluong).ToString();
                    lvCMDC.SelectedItems[0].SubItems[2].Text = (dongia * soluong).ToString();
                }
                else
                    while (lvCMDC.SelectedItems.Count > 0)
                    {
                        lvCMDC.Items.Remove(lvCMDC.SelectedItems[0]);
                        i--;
                    }
                tongTien();
            }
            else
            {
                if (lvCMDC.Items.Count == 0)
                    MessageBox.Show("B?n c?n ch?n bên b?ng món an");
            }
        }

        private void label54_Click(object sender, EventArgs e)
        {

        }

        private void bt_themThongtin_Click(object sender, EventArgs e)
        {
            DataRow dh = dsKhach.NewRow();
            dh["HoTenKhach"] = TT_Ten.Text;
            dh["DiaCHi"] = TT_DiaChi.Text;
            dh["SDT"] = TT_SDT.Text;
            dh["SoLanDat"] = TT_SoLan.Text;

            dsKhach.Rows.Add(dh);

            XuLyDuLieu.ghiBang("ThongTinKhach", dsKhach);
        }

        private void bt_suaThongTin_Click(object sender, EventArgs e)
        {
            if (dgvdsKhach2.SelectedRows.Count > 0)
            {
                DataRow dh = ((DataRowView)dgvdsKhach2.SelectedRows[0].DataBoundItem).Row;
                dh["HoTenKhach"] = TT_Ten.Text;
                dh["DiaCHi"] = TT_DiaChi.Text;
                dh["SDT"] = TT_SDT.Text;
                dh["SoLanDat"] = TT_SoLan.Text;
                XuLyDuLieu.ghiBang("ThongTinKhach", dsKhach);
            }
            else
            {
                MessageBox.Show("Chua Chon Don Hang", "Thong Bao", MessageBoxButtons.OK);
            }
        }

        private void bt_xoaThongtin_Click(object sender, EventArgs e)
        {
            if (dgvdsKhach2.SelectedRows.Count > 0)
            {
                DataRow dh = ((DataRowView)dgvdsKhach2.SelectedRows[0].DataBoundItem).Row;
                dh.Delete();
                XuLyDuLieu.ghiBang("ThongTinKhach", dsKhach);
            }
        }

        private void tb_timThongtin_TextChanged(object sender, EventArgs e)
        {
            if (tb_timThongtin.Text == "")
            {
                dsKhachView.RowFilter = "";
            }
            else
            {
                String str = String.Format("SDT like '%{0}%'", tb_timThongtin.Text);
                dsKhachView.RowFilter = str;
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void bt_DuyetDH_Click(object sender, EventArgs e)
        {
            DataRow dh = dsDonHang.NewRow();
            dh["HD_MaHD"] = DHC_Ma.Text;
            dh["HD_TenKhach"] = DHC_tbTen.Text;
            dh["HD_DiaCHi"] = DHC_tbDiaChi.Text;
            dh["HD_SDT"] = DHC_tbSDT.Text;
            dh["HD_Gia"] = DHC_Gia.Text;
            dh["HD_TinhTrang"] = DHC_TinhTrang.Text;

            dsDonHang.Rows.Add(dh);

            XuLyDuLieu.ghiBang("HoaDon", dsDonHang);
        }

        

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void label56_Click(object sender, EventArgs e)
        {

        }

        private void lbDHC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            int sum = int.Parse(tbTien.Text) - (int.Parse(tbTien.Text) * (int.Parse(tbGiam.Text)+ int.Parse(tbUuDai.Text)) / 100) ;
            tbTongTien.Text = sum.ToString();

        }

        private void btSuaDH_Click(object sender, EventArgs e)
        {
            if (dgvdsDSHonHang.SelectedRows.Count > 0)
            {
                DataRow dh = ((DataRowView)dgvdsDSHonHang.SelectedRows[0].DataBoundItem).Row;
                dh["HD_MaHD"] = tbDHMaDH.Text;
                dh["HD_DiaCHi"] = tbDHDiaChi.Text;
                dh["HD_MaCN"] = tbDHMaCN.Text;
                dh["HD_TenKhach"] = tbDHTen.Text;
                dh["HD_SDT"] = tbDHSDT.Text;
                dh["HD_Gia"] = tbDHTien.Text;
                dh["HD_TinhTrang"] = tbDHTinhTrang.Text;
                XuLyDuLieu.ghiBang("HoaDon", dsDonHang);
            }
            else
            {
                MessageBox.Show("Chua Chon Don Hang", "Thong Bao", MessageBoxButtons.OK);
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                dsDonHangView.RowFilter = "";
            }
            else
            {
                String str = String.Format("HD_SDT like '%{0}%'", textBox4.Text);
                dsDonHangView.RowFilter = str;
            }
        }

        private void tbSoLanDat_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(tbSoLanDat.Text) < 5)
            {
                tbGiam.Text = "0";
            }
            else if (int.Parse(tbSoLanDat.Text) >= 5 && int.Parse(tbSoLanDat.Text) < 10)
            {
                tbGiam.Text = "5";
            }
            else  
            {
                tbGiam.Text = "10";
            }
        }
        private void tbTien_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(tbTien.Text) < 500000)
            {
                tbUuDai.Text = "0";
            }
            
            else
            {
                tbUuDai.Text = "10";
            }
        }
    }
}
