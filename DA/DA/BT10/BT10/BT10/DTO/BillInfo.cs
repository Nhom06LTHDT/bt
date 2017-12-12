using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT10.DTO
{
    public class BillInfo
    {

        public BillInfo(int id, int idfood, int idbill, int Count)
        {
            this.ID = id;
            this.IDFood = idfood;
            this.IDBill = idbill;
            this.count = Count;
        }

        public BillInfo(DataRow row)
        {
            this.ID = (int)row["id"];
            this.IDFood = (int)row["idFood"];
            this.IDBill = (int)row["idBill"];
            this.count = (int)row["COUNT"];
        }

        private int count;
        private int iDFood;
        private int iDBill;
        private int iD;

        public int ID
        {
            get
            {
                return iD;
            }

            set
            {
                iD = value;
            }
        }

        public int IDBill
        {
            get
            {
                return iDBill;
            }

            set
            {
                iDBill = value;
            }
        }

        public int IDFood
        {
            get
            {
                return iDFood;
            }

            set
            {
                iDFood = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }

            set
            {
                count = value;
            }
        }
    }
}
