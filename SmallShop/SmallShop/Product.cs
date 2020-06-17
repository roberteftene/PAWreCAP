using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallShop
{
    public class Product: IComparable<Product>
    {
        private int id;
        private string name;
        private double units;
        private double price;
        private int categoryId;

        public Product():base()
        {
        }

        public Product(int id, string name, double units,double price, int categoryId)
        {
            this.id = id;
            this.name = name;
            this.units = units;
            this.price = price;
            this.categoryId = categoryId;

        }

        public static explicit operator double(Product p )
        {
            return p.Units * p.Price;
        }


        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Units { get => units; set => units = value; }
        public int CategoryId { get => categoryId; set => categoryId = value; }
        public double Price { get => price; set => price = value; }
            
        public override string ToString()
        {
            return string.Format("ProductId: {0}, ProductName: {1}, Units: {2}, Pirce: {3}" + base.ToString(),
                Id,Name,Units,Price,CategoryId);
        }

        public int CompareTo(Product other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}
