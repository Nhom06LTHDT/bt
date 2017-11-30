using BT10.DAO;
using BT10.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
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

            LoadTable();
        }

        void LoadTable()
        {
            List<Table> tableList = TableDAO.Instance.LoadTableList();

            foreach (Table item in tableList)
            {
                Button btn = new Button()
                {
                    Width = TableDAO.TableWidth,
                    Height = TableDAO.TableHeight
                };

                btn.Text = item.Name + Environment.NewLine + item.Status;

                btn.Click += Btn_Click;
                btn.Tag = item;

                if (item.Status == "Trong")
                    btn.BackColor = Color.LightGreen;
                else
                    btn.BackColor = Color.LightPink;

                flipBan.Controls.Add(btn);
            }

        }

        void ShowBill(int id)
        {
            ltvDonHang.Items.Clear();
            List<DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuTable(id);
            float totalprice = 0;
            foreach(DTO.Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalprice += item.TotalPrice;
                ltvDonHang.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            txbTotalPrice.Text = totalprice.ToString("c",culture);
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            int TableID = ((sender as Button).Tag as Table).ID;
            ShowBill(TableID);
        }

        void LoadAccountList()
        {
            //string query = "EXEC dbo.Usp_GetAccountByUsername @userName";
            //dgvDonHang.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { "staff" });

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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txbTotalPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
