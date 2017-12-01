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
        DataView dsMonBo;
        DataTable MonChay;

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
            oleConnection.ConnectionString = "Provider=SQLNCLI11;Data Source=DESKTOP-I9JAO4N;Integrated Security=SSPI;Initial Catalog=TongDoanhThu";
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
            oleConnection.ConnectionString = "Provider=SQLNCLI11;Data Source=DESKTOP-I9JAO4N;Integrated Security=SSPI;Initial Catalog=TongDoanhThu";
            OleDbCommand oleSeclectCommand = new OleDbCommand();
            oleSeclectCommand.Connection = oleConnection;
            oleSeclectCommand.CommandText = "Select * From MonBo";
            OleDbDataAdapter oleDataAdapter = new OleDbDataAdapter();
            oleDataAdapter.SelectCommand = oleSeclectCommand;
            DataTable dt = new DataTable();
            oleDataAdapter.Fill(dt);
            return dt;
        }

        public DataTable DocMonchay()
        {
            OleDbConnection oleConnection = new OleDbConnection();
            oleConnection.ConnectionString = "Provider=SQLNCLI11;Data Source=DESKTOP-I9JAO4N;Integrated Security=SSPI;Initial Catalog=TongDoanhThu";
            OleDbCommand oleSeclectCommand = new OleDbCommand();
            oleSeclectCommand.Connection = oleConnection;
            oleSeclectCommand.CommandText = "Select * From MonChay";
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
            DataRow them = MonBo.NewRow();
            them["Loai"] = loai.Text;
            them["Tên món ăn"] = tenmon.Text;
            them["Đơn vị"] = donvi.Text;
            them["Giá tiền"] = giatien.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripComboBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView3.DataSource = MonBo;
            MonBo.DefaultView.RowFilter = string.Format("Loai LIKE '%{0}%'", toolStripComboBox1.Text);
            
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
