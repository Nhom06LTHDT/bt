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
    public partial class WebDatHang : Form
    {
        int j = 1;
        int i = 0;

        DataTable dsMon;
        
        public WebDatHang()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            mn.Show();
        }

        private void WebDatHang_Load(object sender, EventArgs e)
        {
            dsMon = XuLyDuLieu.docBang("Select *from MonBo");
            dgvdsMonAn3.DataSource = dsMon;
        }

        private void chon_Click(object sender, EventArgs e)
        {
            if (dgvdsMonAn3.SelectedRows.Count == 1)
            {
                ListViewItem m = new ListViewItem();
                int k;
                for (k = 0; k < i; k++)
                {
                    m = lvdsMonAn3.Items[k];
                    if (dgvdsMonAn3.SelectedRows[0].Cells["TenMonAn"].Value.ToString() == m.Text)
                    {
                        j++;
                        lvdsMonAn3.Items[k].SubItems[1].Text = j.ToString();
                        int cost = int.Parse(dgvdsMonAn3.SelectedRows[0].Cells["GiaTien"].Value.ToString()) * j;
                        lvdsMonAn3.Items[k].SubItems[2].Text = cost.ToString();
                        break;
                    }
                }
                if (k == i)
                {
                    AddItem();
                }
                tongTien();
            }
        }
        private void AddItem()
        {
            
            lvdsMonAn3.Items.Add(dgvdsMonAn3.SelectedRows[0].Cells["TenMonAn"].Value.ToString());
            lvdsMonAn3.Items[i].SubItems.Add("1");
            lvdsMonAn3.Items[i].SubItems.Add(dgvdsMonAn3.SelectedRows[0].Cells["GiaTien"].Value.ToString());
            i++;

        }

        private void tongTien()
        {
            
            int t = 0;
            for (int n = 0; n < i; n++)
            {
                t = t + int.Parse(lvdsMonAn3.Items[n].SubItems[2].Text);
                textBox1.Text = (t).ToString();
            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            while (lvdsMonAn3.SelectedItems.Count > 0)
            {
                lvdsMonAn3.Items.Remove(lvdsMonAn3.SelectedItems[0]);
                i--;
            }
            tongTien();
        }
    }
}
