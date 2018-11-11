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
    public partial class NewOrderForm : Form
    {
        private List<Product> products;
        private ProdContext _context;
        public NewOrderForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this._context = new ProdContext();
            this.products = _context.Products.Include("InOrders").Select(p => p).ToList<Product>();
            foreach (var prod in products)
            {
                this.checkedListBox1.Items.Add(prod.Name + "-" + prod.ProductId);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string found = _context.Customers
                .Where(c => c.CompanyName.Equals(this.textBox4.Text))
                .Select(c => c.CompanyName)
                .FirstOrDefault<string>();
            if (found == null)
            {
                MessageBox.Show("No such customer exits");
                return;
            }

            if (this.checkedListBox1.CheckedItems.Count < 1)
            {
                MessageBox.Show("Please add some products to the order");
                return;
            }

            List<int> selectedProductsIds = new List<int>();
            foreach(var selected in this.checkedListBox1.CheckedItems)
            {
                String[] tokens = selected.ToString().Split('-');
                selectedProductsIds.Add(Int32.Parse(tokens[1]));
            }

            Order newOrder = new Order
            {
                Notes = this.richTextBox1.Text,
                OrderedDateTime = DateTime.Now,
                CustomerId = found,
            };
            _context.Orders.Add(newOrder);
            foreach(var prod in this.products.Where(p => selectedProductsIds.Contains(p.ProductId)))
            {
                prod.InOrders.Add(newOrder);
            }
            _context.SaveChanges();

            _context.Dispose();
            Hide();
            DestroyHandle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _context.Dispose();
            Hide();
            DestroyHandle();
        }
    }
}
