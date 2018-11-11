using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDemo
{
    public partial class CategoryForm : Form
    {
        ProdContext _context;
        public CategoryForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _context = new ProdContext();
            _context.Categories.Load();

            this.categoryBindingSource.DataSource =
                _context.Categories.Local.ToBindingList();

            this.label3.Text = (from c in _context.Categories
                                select c)
                                    .ToList()
                                    .Count()
                                    .ToString();
            this.label5.Text = (from p in _context.Products select p)
                                .ToList()
                                .Count()
                                .ToString();
            this.label7.Text = (from c in _context.Customers select c)
                                .ToList()
                                .Count()
                                .ToString();
        }

        private void categoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this._context.SaveChanges();
            this.categoryDataGridView.Refresh();
            this.productsDataGridView.Refresh();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this._context.Dispose();
        }

        private void categoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedCategory = (Category)this.categoryDataGridView.CurrentRow.DataBoundItem;
            var productsToThisCategoryMS = _context.Products.Where(p => p.CategoryId == selectedCategory.CategoryId)
                .Select(p => p).ToList<Product>();
            var productsToThisCategoryL2E = (from p in _context.Products
                                            where p.CategoryId == selectedCategory.CategoryId
                                            select p).ToList<Product>();
            var bindingList = new BindingList<Product>(productsToThisCategoryL2E);
            this.productsDataGridView.DataSource = new BindingSource(bindingList, null);
            this.productsDataGridView.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewProductForm newForm = new NewProductForm();
            newForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var context = new ProdContext())
            {
                this.label3.Text = (from c in context.Categories
                                    select c)
                                    .ToList()
                                    .Count()
                                    .ToString();
                this.label5.Text = (from p in context.Products select p)
                                    .ToList()
                                    .Count()
                                    .ToString();
                this.label7.Text = (from c in context.Customers select c)
                                    .ToList()
                                    .Count()
                                    .ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CustomersForm newForm = new CustomersForm(this);
            newForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NewOrderForm newForm = new NewOrderForm();
            newForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ClientInfoForm newForm = new ClientInfoForm();
            newForm.Show();
        }
    }
}
