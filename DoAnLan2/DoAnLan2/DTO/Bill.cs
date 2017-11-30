using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT10.DTO
{
    public class Bill
    {
        public Bill(int id, DateTime? dataCheckOut, DateTime? dataCheckIn, int status)
        {
            this.ID = id;
            this.DataCheckIn = dataCheckIn;
            this.DataCheckOut = dataCheckOut;
            this.Status = status;
        }

        public Bill(DataRow row)
        {
            this.ID = (int)row["id"];
            this.DataCheckIn = (DateTime?)row["DateCheckIn"];
            var dateCheckOutTemp = row["DateCheckOut"];
            if(dateCheckOutTemp.ToString() !="")
                this.DataCheckOut = (DateTime?)dateCheckOutTemp;
            this.Status = (int)row["status"];
        }

        private int status;

        private DateTime? dataCheckOut;

        private DateTime? dataCheckIn;

        private int iD;

        public DateTime? DataCheckIn
        {
            get
            {
                return dataCheckIn;
            }

            set
            {
                dataCheckIn = value;
            }
        }

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

        public DateTime? DataCheckOut
        {
            get
            {
                return dataCheckOut;
            }

            set
            {
                dataCheckOut = value;
            }
        }

        public int Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }
    }
}
