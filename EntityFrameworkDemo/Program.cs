using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDemo
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            using (var db = new ProdContext())
            {

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new CategoryForm());
                
            }
        }
    }
}
