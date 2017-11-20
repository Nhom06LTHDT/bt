using BT10.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT10
{
    public partial class HoatDongBanHang : Form
    {

        public HoatDongBanHang()
        {
            InitializeComponent();

            LoadAccountList();
        }

        void LoadAccountList()
        {
            string query = "SELECT * FROM dbo.Account";
            DataProvider provider = new DataProvider();
            dgvTaoDonHang.DataSource = provider.ExecuteQuery(query);

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgvTaoDonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }
}
