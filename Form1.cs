using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dropbox05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<Product> allProduct = new List<Product>();

        private void Form1_Load(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("product.txt"))
            {
                string sku;
                while((sku = sr.ReadLine()) != null)
                {
                    string name = sr.ReadLine();
                    int quantityOnHand = int.Parse(sr.ReadLine());
                    Product p = new Product(sku, name, quantityOnHand);
                    allProduct.Add(p);
                    skuComboBox.Items.Add(p.SKU);
                }
            }
        }

        private void skuComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = skuComboBox.SelectedIndex;
            productDetailsListBox.Items.Clear();
            string[] multipleLines = allProduct[selectedIndex].ToString().Split(',');
            foreach(string s in multipleLines)
            {
                productDetailsListBox.Items.Add(s);
            }
        }
    }
}
