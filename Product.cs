using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dropbox05
{
    class Product
    {
        private string sku;
        private string name;
        private int quantityOnHand;
        public string SKU
        {
            get { return sku; }
            set { sku = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int QuantityOnHand
        {
            get { return quantityOnHand; }
            set { quantityOnHand = value; }
        }
        public Product(string sku, string name, int quantityOnHand)
        {
            this.sku = sku;
            this.name = name;
            this.quantityOnHand = quantityOnHand;
        }
        public override string ToString()
        {
            string str;
            str = string.Format($"SKU: {sku},") + string.Format($"Name: {name},") + string.Format($"Quantity on hand: {quantityOnHand}");
            return str;
        }
    }
}
