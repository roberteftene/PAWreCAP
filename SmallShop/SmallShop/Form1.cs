using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallShop
{
    public partial class Form1 : Form
    {
        public List<Product> products;
        private List<category> categories;
        private string connectionString = "Data Source=database.db";

        public Form1()
        {
            categories = new List<category>();
            products = new List<Product>();
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadProductsFromDB();
            DisplayProducts();
        }

        private void LoadCategories()
        {
                string[] lines = System.IO.File.ReadAllLines("Categories.txt");
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] values = lines[i].Split(' ');
                    int id = Convert.ToInt32(values[0]);
                    string name = values[1];
                    categories.Add(new category(id, name));
                }
        }

        private void LoadProductsFromDB()
        {
            var query = "SELECT * FROM Products";

            using(var connection = new SQLiteConnection(connectionString))
            {
                var command = new SQLiteCommand(query, connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["Id"]);
                        string name = (string)reader["Name"];
                        int units = Convert.ToInt32(reader["Units"]);
                        double price = (double)reader["Price"];
                        int categoryId = Convert.ToInt32(reader["CategoryId"]);

                        var product = new Product(id, name, units, price, categoryId);
                        products.Add(product);
                    }

                }
            }
        }

        private void DisplayProducts()
        {
            dgvProducts.Rows.Clear();

            products.Sort();

            foreach(var p in products)
            {
                var category = categories.First(x => x.Id == p.CategoryId);

                var rowIndex = dgvProducts.Rows.Add(new object[] {
                    p.Name,
                    p.Units,
                    p.Price,
                    category.Name
                });

                dgvProducts.Rows[rowIndex].Tag = p;
            }
        }

        private void AddProduct(Product p)
        {
            var query = "INSERT INTO Products(Name, Units, Price, CategoryId) " +
                "VALUES (@name, @units, @price, @categoryId);" +
                "SELECT last_insert_rowid();";

            using (var connection = new SQLiteConnection(connectionString))
            {
                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@name", p.Name);
                command.Parameters.AddWithValue("@units", p.Units);
                command.Parameters.AddWithValue("@price", p.Price);
                command.Parameters.AddWithValue("@categoryId", p.CategoryId);

                connection.Open();

                p.Id = Convert.ToInt32(command.ExecuteScalar());

                products.Add(p);

            }
        }

        private void DeleteProductFromDB(Product p)
        {
            var query = "DELETE FROM Products WHERE Id = @id";

            using(var connection = new SQLiteConnection(connectionString))
            {
                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@id", p.Id);

                connection.Open();
                command.ExecuteNonQuery();

                products.Remove(p);
            }
        }

        private void UpdateProductFromDB(Product p)
        {
            var query = "UPDATE Products SET Name = @name, Units = @units," +
                " Price = @price, CategoryId = @categoryId " +
                " WHERE Id = @id";

            using(var connection = new SQLiteConnection(connectionString))
            {

                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@name", p.Name);
                command.Parameters.AddWithValue("@units", p.Units);
                command.Parameters.AddWithValue("@price", p.Price);
                command.Parameters.AddWithValue("@categoryId", p.CategoryId);
                command.Parameters.AddWithValue("@id", p.Id);

                connection.Open();

                command.ExecuteNonQuery();


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            AddProductForm add = new AddProductForm(product,categories);
            if(add.ShowDialog() == DialogResult.OK)
            {
                //products.Add(product);
                AddProduct(product);
                DisplayProducts();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dgvProducts.SelectedRows.Count == 1)
            {
                var selectedRow = dgvProducts.SelectedRows[0];
                var product = (Product)selectedRow.Tag;
                // products.Remove(product);

                //FOR DB
                DeleteProductFromDB(product);
                DisplayProducts();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 1)
            {
                var selectedRow = dgvProducts.SelectedRows[0];
                var product = (Product)selectedRow.Tag;

                AddProductForm edit = new AddProductForm(product, categories);
                if(edit.ShowDialog() == DialogResult.OK)
                {
                    UpdateProductFromDB(product);
                    DisplayProducts();
                } 

            }
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            double sum = 0;
            foreach(Product p in products)
            {
                sum += (double)p;
            }

            MessageBox.Show("Total: " + sum);
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            Chart chartForm = new Chart(products, categories);
            chartForm.ShowDialog();
        }
    }
}
