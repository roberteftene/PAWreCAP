using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallShop
{
    public partial class AddProductForm : Form
    {
        public List<Product> products = new List<Product>();
        public Product p;
        public category category;
        public List<category> categories;
        public AddProductForm(Product product, List<category> categories)
        {
            this.p = product;
            this.categories = categories;
            InitializeComponent();
        }

        public void addProduct()
        {
            

            p.Name = inputProductName.Text;
            p.Units = Convert.ToInt32(inputUnits.Text);
            p.Price = Convert.ToDouble(inputPrice.Text);
            var selectedCategory = (category)inputCategory.SelectedItem;
            p.CategoryId = selectedCategory.Id;

            // p = new Product(productName, units, price, categoryName);

        }


        private void AddProductForm_Load(object sender, EventArgs e)
        {
            inputCategory.DataSource = categories;

            inputProductName.Text = p.Name;
            inputUnits.Text = p.Units.ToString();
            inputPrice.Text = p.Price.ToString();

            if(p.CategoryId != 0)
            {
                var category = categories.FirstOrDefault(x => x.Id == p.CategoryId);
                inputCategory.SelectedItem = category;
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                addProduct();
                MessageBox.Show("Product has been added");
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                inputProductName.Clear();
                inputUnits.Clear();
                inputPrice.Clear();
            }
        }
    }
}
