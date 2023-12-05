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
    /// Interaction logic for signin.xaml
    /// </summary>
    public partial class signin : Page
    {
        Entities1 db=new Entities1();
        public signin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
                userlog user = new userlog();
                user=db.userlogs.FirstOrDefault(x=>x.Username==usernametxt.Text&&x.Passwords == passtxt.Text);
                if (user!=null)
                {
                    MessageBox.Show("Login Sucessfully");
                    profile page=new profile(user);
                    this.NavigationService.Navigate(page);
                }
            else
            {
                MessageBox.Show("Ensure The Data Please");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            signup page = new signup();
            this.NavigationService.Navigate(page);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            forget page = new forget();
            this.NavigationService.Navigate(page);
        }
    }
}
