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
    public partial class CustomersForm : Form
    {
        private ProdContext _context;
        private CategoryForm backScreen;

        public CustomersForm(CategoryForm categoryForm)
        {
            this.backScreen = categoryForm;
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this._context = new ProdContext();
            _context.Customers.Load();

            this.customerBindingSource.DataSource =
                _context.Customers.Local.ToBindingList();

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void customerBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this._context.SaveChanges();
            this.customerDataGridView.Refresh();
        }
    }
}
