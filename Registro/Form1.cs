using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Registro.Model;

namespace Registro
{
    public partial class Form1 : Form
    {
        List<Product> products;
        public Form1()
        {
            InitializeComponent();
            products=new List<Product>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Name = TbProduct.Text;
            product.Price = double.Parse(TbPrice.Text);
            product.Add(product);
            ShowProduct();
        }
        private void ShowProduct()
        {
            DGBProducts.DataSource = null;
            DGBProducts.DataSource = products;
        }
    }
}
