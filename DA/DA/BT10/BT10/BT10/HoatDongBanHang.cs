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

            LoadCategory();

            cbMode.SelectedIndex = 0;
        }

        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "name";
            
        }

        void LoadFoodListByCategoryID(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
            cbFoodbyCategory.DataSource = listFood;
            cbFoodbyCategory.DisplayMember = "name";
        }

        void LoadTable()
        {
            flipBan.Controls.Clear();
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
            ltvDonHang.Tag = (sender as Button).Tag;
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
            Table table = ltvDonHang.Tag as Table;
            int idBill = BillDAO.Instance.GetBillTableID(table.ID);
            if(idBill != -1)
            {
                if (MessageBox.Show("Bạn có chắc thanh toán hóa đơn cho bàn!!" + table.Name, "Thông Báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill);
                    ShowBill(table.ID);
                    LoadTable();
                }
                     
            }
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            Category selected = cb.SelectedItem as Category;
            id = selected.ID;
            LoadFoodListByCategoryID(id);
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            
            Table table = ltvDonHang.Tag as Table;

            int idBill = BillDAO.Instance.GetBillTableID(table.ID);
            int foodID = (cbFoodbyCategory.SelectedItem as Food).ID;
            int count = (int)nmFoodCount.Value;
            if(idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.ID);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodID, count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, count);
            }
            ShowBill(table.ID);
            LoadTable();
        }

        private void nmFoodCount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnChiPhi_Click(object sender, EventArgs e)
        {
            int mode = 0;
            int money = (int)nmMoneyCP.Value;
            string note = txbNoteCP.Text;
            if (cbMode.SelectedIndex == 1)
                mode = 1;
            if (ChiPhiDAO.Instance.NhapChiPhi(money, mode, note))
            {
                MessageBox.Show("Thanh Cong");
                LoadChiPhi(cbMode.SelectedIndex);
            }

           
        }

        public void LoadChiPhi(int mode)
        {
            ltvChiPhi.Items.Clear();
            List<ChiPhi> listchiphi = ChiPhiDAO.Instance.LayBangChiPhi(mode);
            foreach(ChiPhi item in listchiphi)
            {
                ListViewItem lsvItem = new ListViewItem(item.Date.ToString());
                lsvItem.SubItems.Add(item.Money.ToString());
                lsvItem.SubItems.Add(item.Note.ToString());
                ltvChiPhi.Items.Add(lsvItem);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMode.SelectedIndex == 0)
                LoadChiPhi(0);
            else
                LoadChiPhi(1);
        }
    }
}
