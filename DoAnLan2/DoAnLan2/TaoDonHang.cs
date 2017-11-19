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

namespace DoAnLan2
{
    public partial class TaoDonHang : Form
    {
       
        public TaoDonHang()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void TaoDonHang_Load(object sender, EventArgs e)
        {
            DataTable TaoDH = DocBang();
            /*listView1.Columns.Add("MADH");
            listView1.Columns.Add("SOBAN");
            listView1.Columns.Add("NGAYTHANG");
            listView1.Columns.Add("GIA");
            for (int i = 0; i < TaoDH.Rows.Count; i++)
            {
                listView1.Items.Add(TaoDH.Rows[i]["MADH"].ToString());
                listView1.Items[i].SubItems.Add(TaoDH.Rows[i]["SOBAN"].ToString());
                listView1.Items[i].SubItems.Add(TaoDH.Rows[i]["NGAYTHANG"].ToString());
                listView1.Items[i].SubItems.Add(TaoDH.Rows[i]["GIA"].ToString());
            }*/
            dataGridView1.DataSource = TaoDH;
        }
        public DataTable DocBang()
        {
            OleDbConnection oleConnection = new OleDbConnection();//loai, vi tri (server-csdl, file), bao mat (user, pass)
            oleConnection.ConnectionString = "Provider=SQLNCLI11;Data Source=DESKTOP-I9JAO4N;Integrated Security=SSPI;Initial Catalog=QUANLYDATHANG";
            OleDbCommand oleSelectCommand = new OleDbCommand();//Access, MySql, Oracel, Postpre, ...
            oleSelectCommand.Connection = oleConnection;
            oleSelectCommand.CommandText = "Select * From THONGTINHOADON";
            OleDbDataAdapter oleDataAdapter = new OleDbDataAdapter();
            oleDataAdapter.SelectCommand = oleSelectCommand;
            //oleDataAdapter.InsertCommand;
            //oleDataAdapter.UpdateCommandch
            //oleDataAdapter.DeleteCommand;
            DataTable dt = new DataTable();
            oleDataAdapter.Fill(dt);
            return dt;
            //Data Source = DESKTOP - I9JAO4N; Initial Catalog = QUANLYDATHANG; Integrated Security = True
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
