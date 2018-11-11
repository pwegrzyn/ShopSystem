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
    public partial class ClientInfoForm : Form
    {
        private ProdContext _context;
        public ClientInfoForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this._context = new ProdContext();
            this.labelFirstOrderDate.Text = "";
            this.labelTotalMoney.Text = "";
            this.labelTotalOrders.Text = "";
            this.labelTotalProducts.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var companyName = this.textBox1.Text;
            if (companyName.Equals(""))
            {
                MessageBox.Show("Please provide a company name");
                return;
            }
            var foundCustomer = _context.Customers
                .Include("Orders.Products")
                .Where(c => c.CompanyName.Equals(companyName))
                .Select(c => c)
                .FirstOrDefault<Customer>();
            if (foundCustomer == null)
            {
                MessageBox.Show("No such customer exits in the database");
                return;
            }

            this.labelTotalOrders.Text = foundCustomer.Orders.Count().ToString();
            if (foundCustomer.Orders.Count() == 0)
            {
                this.labelTotalProducts.Text = "0";
                this.labelTotalMoney.Text = "0,00 PLN";
                this.labelFirstOrderDate.Text = "no orders";
                return;
            }

            var totalProducts = 0;
            decimal totalMoney = 0.0M;
            DateTime earlierOrderDateTime = foundCustomer.Orders.First<Order>().OrderedDateTime;
            foreach(var ord in foundCustomer.Orders)
            {
                if (ord.OrderedDateTime < earlierOrderDateTime)
                {
                    earlierOrderDateTime = ord.OrderedDateTime;
                }
                foreach (var prod in ord.Products)
                {
                    totalProducts++;
                    totalMoney += prod.UnitPrice;
                }
            }
            this.labelTotalProducts.Text = totalProducts.ToString();
            this.labelTotalMoney.Text = totalMoney.ToString() + " PLN";
            this.labelFirstOrderDate.Text = earlierOrderDateTime.ToString();
            return;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this._context.Dispose();
            Hide();
            DestroyHandle();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this._context.Dispose();
        }

    }
}
