using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Registe_loginDeskapp
{
    /// <summary>
    /// Interaction logic for forget.xaml
    /// </summary>
    public partial class forget : Page
    {
        Entities1 db=new Entities1();
        bool isvalid(string pass)
        {
            bool upper, lowe, sp, num;
            upper = lowe = sp = num = false;
            string sps = "!@#$%^&*_";
            foreach (char c in pass)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    upper = true;
                }
                else if (c >= 'a' && c <= 'z')
                {
                    lowe = true;
                }
                else if (c >= '1' && c <= '9')
                {
                    num = true;
                }
                else if (sps.Contains(c))
                {
                    sp = true;
                }
            }
            return num && lowe && sp && upper;
        }
        public forget()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
                userlog userlog = new userlog();
                userlog=db.userlogs.FirstOrDefault(x=>x.Phone_number==phonetxt.Text);
                if (userlog!=null)
                {
                if (isvalid(passtxt.Text) && passtxt.Text == conpasstxt.Text)
                {
                    userlog.Passwords = passtxt.Text;
                    db.userlogs.AddOrUpdate(userlog);
                    db.SaveChanges();
                    signin page = new signin();
                    this.NavigationService.Navigate(page);
                }
                else
                {
                    MessageBox.Show("Ensure The Password Please");
                }
                }
            
        }
    }
}
