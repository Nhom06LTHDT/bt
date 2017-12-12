using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace kiet
{
    public partial class dsMonan : Form
    {
        DataTable ds;
        DataTable MonBo;
        DataTable MonChay;
        DataTable DoanhthuCN;
        DataTable SLDH;
        //------
        DataTable dsKhach;
        DataView dsKhachView;

        public dsMonan()
        {
            InitializeComponent();
        }

        private void dsMonan_Load(object sender, EventArgs e)
        {
            ds = DocDSLOP();
            dataGridView1.DataSource = ds;
            MonBo = Docmon();
            MonChay = DocMonchay();
            DoanhthuCN = Doanhthucn();
            SLDH = Donhang();
            //-----
            dsKhach = XuLyDuLieu.docBang("select * from thongtinkhach");
            dsKhachView = new DataView(dsKhach);
            dgvdsKhachHang.DataSource = dsKhachView;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        public DataTable DocDSLOP()
        {
            OleDbConnection oleConnection = new OleDbConnection();
            oleConnection.ConnectionString = "Provider=SQLNCLI11;Data Source=DESKTOP-I9JAO4N;Integrated Security=SSPI;Initial Catalog=QuanLyQuanAn";
            OleDbCommand oleSeclectCommand = new OleDbCommand();
            oleSeclectCommand.Connection = oleConnection;
            oleSeclectCommand.CommandText = "Select * From DoanhThu";
            OleDbDataAdapter oleDataAdapter = new OleDbDataAdapter();
            oleDataAdapter.SelectCommand = oleSeclectCommand;
            DataTable dt = new DataTable();
            oleDataAdapter.Fill(dt);
            return dt;
        }

        public DataTable Docmon()
        {
            OleDbConnection oleConnection = new OleDbConnection();
            oleConnection.ConnectionString = "Provider=SQLNCLI11;Data Source=DESKTOP-I9JAO4N;Integrated Security=SSPI;Initial Catalog=QuanLyQuanAn";
            OleDbCommand oleSeclectCommand = new OleDbCommand();
            oleSeclectCommand.Connection = oleConnection;
            oleSeclectCommand.CommandText = "Select * From MonAn";
            OleDbDataAdapter oleDataAdapter = new OleDbDataAdapter();
            oleDataAdapter.SelectCommand = oleSeclectCommand;
            DataTable dt = new DataTable();
            oleDataAdapter.Fill(dt);
            return dt;
        }

        public DataTable DocMonchay()
        {
            OleDbConnection oleConnection = new OleDbConnection();
            oleConnection.ConnectionString = "Provider=SQLNCLI11;Data Source=DESKTOP-I9JAO4N;Integrated Security=SSPI;Initial Catalog=QuanLyQuanAn";
            OleDbCommand oleSeclectCommand = new OleDbCommand();
            oleSeclectCommand.Connection = oleConnection;
            oleSeclectCommand.CommandText = "Select * From MonChay";
            OleDbDataAdapter oleDataAdapter = new OleDbDataAdapter();
            oleDataAdapter.SelectCommand = oleSeclectCommand;
            DataTable dt = new DataTable();
            oleDataAdapter.Fill(dt);
            return dt;
        }

        public DataTable Doanhthucn()
        {
            OleDbConnection oleConnection = new OleDbConnection();
            oleConnection.ConnectionString = "Provider=SQLNCLI11;Data Source=DESKTOP-I9JAO4N;Integrated Security=SSPI;Initial Catalog=QuanLyQuanAn";
            OleDbCommand oleSeclectCommand = new OleDbCommand();
            oleSeclectCommand.Connection = oleConnection;
            oleSeclectCommand.CommandText = "Select * From DoanhThuCN";
            OleDbDataAdapter oleDataAdapter = new OleDbDataAdapter();
            oleDataAdapter.SelectCommand = oleSeclectCommand;
            DataTable dt = new DataTable();
            oleDataAdapter.Fill(dt);
            return dt;
        }

        public DataTable Donhang()
        {
            OleDbConnection oleConnection = new OleDbConnection();
            oleConnection.ConnectionString = "Provider=SQLNCLI11;Data Source=DESKTOP-I9JAO4N;Integrated Security=SSPI;Initial Catalog=QuanLyQuanAn";
            OleDbCommand oleSeclectCommand = new OleDbCommand();
            oleSeclectCommand.Connection = oleConnection;
            oleSeclectCommand.CommandText = "Select * From SLDH";
            OleDbDataAdapter oleDataAdapter = new OleDbDataAdapter();
            oleDataAdapter.SelectCommand = oleSeclectCommand;
            DataTable dt = new DataTable();
            oleDataAdapter.Fill(dt);
            return dt;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_TextChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = MonChay;
            MonChay.DefaultView.RowFilter = string.Format("ChiNhanh LIKE '%{0}%'", comboBox6.Text);
        }

        private void BT1_Click(object sender, EventArgs e)
        {
            DataRow dh = MonBo.NewRow();
            dh["Loai"] = loai.Text;
            dh["TenMonAn"] = tenmon.Text;
            dh["DonVi"] = donvi.Text;
            dh["GiaTien"] = giatien.Text;

            MonBo.Rows.Add(dh);

            XuLyDuLieu2.ghiBang("MonAn", MonBo);
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (dataGridView3.SelectedRows.Count > 0)
            {
                dataGridView3.Rows.RemoveAt(dataGridView3.SelectedRows[0].Index);
                
            }
            XuLyDuLieu2.ghiBang("MonAn",MonBo);
        }

        private void toolStripComboBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView3.DataSource = MonBo;
            MonBo.DefaultView.RowFilter = string.Format("Loai LIKE '%{0}%'", toolStripComboBox1.Text);
            
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DTCN_TextChanged(object sender, EventArgs e)
        {
            dataGridView4.DataSource = DoanhthuCN;
            DoanhthuCN.DefaultView.RowFilter = string.Format("CHINHANH LIKE '%{0}%'", DTCN.Text);
        }

        private void comboBox4_TextChanged(object sender, EventArgs e)
        {
            dataGridView5.DataSource = SLDH;
            SLDH.DefaultView.RowFilter = string.Format("CHINHANH LIKE '%{0}%'", comboBox4.Text);
        }

        private void tbTimSDT_TextChanged(object sender, EventArgs e)
        {
            if (tbTimTen.Text == "")
            {
                dsKhachView.RowFilter = "";
            }
            else
            {
                String str = String.Format("HoTenKhach like '%{0}%'", tbTimTen.Text);
                dsKhachView.RowFilter = str;
            }
        }

        private void bt_themThongtin_Click(object sender, EventArgs e)
        {
            DataRow dh = dsKhach.NewRow();
            dh["HoTenKhach"] = tbTenKhach.Text;
            dh["DiaCHi"] = tbDiaChi.Text;
            dh["SDT"] = tbSDT.Text;
            dh["SoLanDat"] = TT_SoLan.Text;

            dsKhach.Rows.Add(dh);

            XuLyDuLieu.ghiBang("ThongTinKhach", dsKhach);
        }

        private void bt_xoaThongtin_Click(object sender, EventArgs e)
        {
            if (dgvdsKhachHang.SelectedRows.Count > 0)
            {
                DataRow dh = ((DataRowView)dgvdsKhachHang.SelectedRows[0].DataBoundItem).Row;
                dh.Delete();
                XuLyDuLieu.ghiBang("ThongTinKhach", dsKhach);
            }
        }

        private void dgvdsKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void donvi_TextChanged(object sender, EventArgs e)
        {

        }

        private void themABC_Click_1(object sender, EventArgs e)
        {
            DataRow dh = ds.NewRow();
            dh["TIME"] = time.Text;
            dh["TongDoanhThu"] = doanhthu.Text;
            dh["ChiNhanhCaoNhat"] = caonhat.Text;
            dh["DoanhThuChiNhanh"] = CN.Text;

            ds.Rows.Add(dh);

            XuLyDuLieu2.ghiBang("DoanhThu", ds);
        }

        private void XoaABC_Click(object sender, EventArgs e)
        {
            while (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

            }
            XuLyDuLieu2.ghiBang("DoanhThu", ds);
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void ThemChay_Click(object sender, EventArgs e)
        {
            DataRow dh = MonChay.NewRow();
            dh["ChiNhanh"] = CN1.Text;
            dh["TIME"] = time1.Text;
            dh["TenMonAn"] = TenMA1.Text;
            dh["DonVi"] = DonVi1.Text;
            dh["SoLuong"] = SoLg.Text;

            MonChay.Rows.Add(dh);

            XuLyDuLieu2.ghiBang("MonChay", MonChay);
        }

        private void XoaChay_Click(object sender, EventArgs e)
        {
            while (dataGridView2.SelectedRows.Count > 0)
            {
                dataGridView2.Rows.RemoveAt(dataGridView2.SelectedRows[0].Index);

            }
            XuLyDuLieu2.ghiBang("MonChay", MonChay);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataRow dh = DoanhthuCN.NewRow();
            dh["ChiNhanh"] = CN2.Text;
            dh["TIME"] = time2.Text;
            dh["TienBan"] = tienban.Text;
            dh["PhiPhatSinh"] = phatsinh.Text;

            DoanhthuCN.Rows.Add(dh);

            XuLyDuLieu2.ghiBang("DoanhThuCN", DoanhthuCN);
        }

        private void xoa_bt3_Click(object sender, EventArgs e)
        {
            while (dataGridView4.SelectedRows.Count > 0)
            {
                dataGridView4.Rows.RemoveAt(dataGridView4.SelectedRows[0].Index);

            }
            XuLyDuLieu2.ghiBang("DoanhThuCN", DoanhthuCN);
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DTCN_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }
    }
}
