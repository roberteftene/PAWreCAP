using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallShop
{
    public partial class Chart : Form
    {

        private List<Product> products;
        private List<category> categories;
        public Chart(List<Product> products, List<category> categories)
        {
            this.products = products;
            this.categories = categories;
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);


            List<int> prodCOunt = new List<int>();
            
            //foreach(var categ in categories)
            foreach (var prod in products)
            {
                //var count = products.Count(x => x.categoryId == categ.Id)
                var count = prod.Units;
                MessageBox.Show(count.ToString());
                //prodCOunt.Add(count);
                prodCOunt.Add((int)count);
            }

            var barWidth = e.ClipRectangle.Width / prodCOunt.Count;
            var maxValue = prodCOunt.Max();
            var scale = e.ClipRectangle.Height / maxValue;


            for (int i = 0; i < prodCOunt.Count; i++)
            {
                var barHeight = prodCOunt[i] * scale;

                e.Graphics.FillRectangle(
                    Brushes.Blue,
                    i * barWidth,
                    e.ClipRectangle.Height - barHeight,
                    barWidth,
                    barHeight);
            }
        }

        private void Chart_Load(object sender, EventArgs e)
        {

        }
    }
}
