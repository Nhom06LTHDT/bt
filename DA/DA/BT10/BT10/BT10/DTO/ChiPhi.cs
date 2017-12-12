using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT10.DTO
{
    public class ChiPhi
    {

        public ChiPhi(int id, int mode, int money, string note, DateTime? date)
        {
            this.ID = id;
            this.Mode = mode;
            this.Money = money;
            this.Note = note;
            this.Date = date;
        }

        public ChiPhi(DataRow row)
        {
            this.Money = (int)row["money"];
            this.Note = row["note"].ToString();
            this.Date = (DateTime?)row["Date"];
        }


        private DateTime? date;
        private string note;
        private int money;
        private int mode;
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

        public int Mode
        {
            get
            {
                return mode;
            }

            set
            {
                mode = value;
            }
        }

        public int Money
        {
            get
            {
                return money;
            }

            set
            {
                money = value;
            }
        }

        public string Note
        {
            get
            {
                return note;
            }

            set
            {
                note = value;
            }
        }

        public DateTime? Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }
    }
}
