using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDemo
{
    public partial class NewProductForm : Form
    {
        public NewProductForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            using (var context = new ProdContext())
            {
                var categories = from c in context.Categories
                                 select c.Name;
                foreach(var cat in categories)
                {
                    comboBox1.Items.Add(cat);
                }
            }
        }

        // Save and close
        private void button1_Click(object sender, EventArgs e)
        {
            int belongsToCategory = 0;
            using (var context = new ProdContext())
            {
                belongsToCategory = context.Categories
                    .Where(c => c.Name == (string)comboBox1.SelectedItem)
                    .Select(c => c.CategoryId)
                    .FirstOrDefault<int>();
            }
            if (belongsToCategory == 0)
            {
                MessageBox.Show("Please select a category");
                return;
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please provide a name");
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Please provide the unit price");
                return;
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("Please provide the number of units in stock");
                return;
            }
            var newProduct = new Product
            {
                CategoryId = belongsToCategory,
                Name = textBox1.Text
            };
            try
            {
                newProduct.UnitPrice = Decimal.Parse(textBox2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Unit price must be a decimal value");
                return;
            }
            try
            {
                newProduct.UnitsInStock = Int32.Parse(textBox3.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("The number of units in stock must be an integer");
                return;
            }
            using(var context = new ProdContext())
            {
                context.Products.Add(newProduct);
                context.SaveChanges();
            }
            Hide();
            DestroyHandle();
        }

        // Cancel
        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            DestroyHandle();
        }
    }
}
