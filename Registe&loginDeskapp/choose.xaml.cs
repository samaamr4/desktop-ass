using System;
using System.Collections.Generic;
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
    /// Interaction logic for choose.xaml
    /// </summary>
    public partial class choose : Page
    {
        public choose()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(comb.Text== "Signin")
            {
                signin page=new signin();
                this.NavigationService.Navigate(page);
            }
            else if (comb.Text == "Signup")
            {
                signup page=new signup();
                this.NavigationService.Navigate(page);
            }
            else if (comb.Text == "Forget Password")
            {
                forget page=new forget();
                this.NavigationService.Navigate(page);
            }
            else if (comb.Text == "Admin Search")
            {
                searchpage page = new searchpage();
                this.NavigationService.Navigate(page);
            }
            else if (comb.Text == "Admin Delete")
            {
                Deletepage page = new Deletepage();
                this.NavigationService.Navigate(page);
            }
            else
            {
                MessageBox.Show("Choose Please");
            }
        }
    }
}
