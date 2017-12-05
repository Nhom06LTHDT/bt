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
    public partial class Menu : Form
    {
        DataTable MonBo;

        public Menu()
        {
            InitializeComponent();
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

        private void toolStripComboBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView3.DataSource = MonBo;
            MonBo.DefaultView.RowFilter = string.Format("Loai LIKE '%{0}%'", toolStripComboBox1.Text);
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            MonBo = Docmon();
        }
    }
}
