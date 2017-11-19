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
    public partial class Menu : Form
    {
        DataTable ds;
        public Menu()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        public DataTable DSMonan()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "Data Source=DESKTOP-9F0HO6E;Initial Catalog=quanly;Integrated Security=True";
            SqlCommand sqlSeclectCommand = new SqlCommand();
            sqlSeclectCommand.Connection = sqlConnection;
            sqlSeclectCommand.CommandText = "Select * From quanly";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlSeclectCommand;
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            return dt;
        }

        private void btMenu_Click_1(object sender, EventArgs e)
        {
            Quanlydonhang qldh = new Quanlydonhang();
            this.Hide();
            qldh.ShowDialog();
            this.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            ds = DSMonan();
            dgvMenu.DataSource = ds;
        }
    }
}
