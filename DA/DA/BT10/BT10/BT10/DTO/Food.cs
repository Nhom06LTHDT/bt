using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT10.DTO
{
    public class Food
    {
        public Food(int id, int iDCategory, string name, float price)
        {
            this.ID = id;
            this.IDCategory = iDCategory;
            this.Name = name;
            this.PriceFood = price;

        }

        
        public Food(DataRow row)
        {
            this.ID = (int)row["id"];
            this.IDCategory = (int)row["idCategory"];
            this.Name = row["name"].ToString();
            this.PriceFood = (float)Convert.ToDouble(row["PriceFood"].ToString());
        }
        private float priceFood;
        private string name;
        private int iDCategory;
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

        public int IDCategory
        {
            get
            {
                return iDCategory;
            }

            set
            {
                iDCategory = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public float PriceFood
        {
            get
            {
                return priceFood;
            }

            set
            {
                priceFood = value;
            }
        }
    }
}
