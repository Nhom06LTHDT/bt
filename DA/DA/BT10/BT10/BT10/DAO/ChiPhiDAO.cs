using BT10.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT10.DAO
{
    public class ChiPhiDAO
    {
        private static ChiPhiDAO instance;

        public static ChiPhiDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChiPhiDAO();
                return ChiPhiDAO.instance;
            }

            private set
            {
                ChiPhiDAO.instance = value;
            }
        }
        private ChiPhiDAO() { }

        public bool NhapChiPhi(int money, int mode, string note)
        {
            string query = string.Format("INSERT dbo.ChiPhi ( money, note, mode ) VALUES  ( {0},  N'{1}', {2} )", money, note, mode);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public List<ChiPhi> LayBangChiPhi(int mode)
        {
            
            List<ChiPhi> listchiphi = new List<ChiPhi>();
            string query = "SELECT Date, money, note FROM dbo.ChiPhi WHERE mode =  " + mode;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                ChiPhi chiphi = new ChiPhi(item);
                listchiphi.Add(chiphi);
            }
            return listchiphi;
        }
    }
}
