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
    /// Interaction logic for profile.xaml
    /// </summary>
    public partial class profile : Page
    {
        Entities1 db=new Entities1();
        public profile(userlog name)
        {
            InitializeComponent();
            lab_show.Content ="Welcome"+ name.Username;
            usernametxt.Text = name.Username;
            passtxt.Password = name.Passwords;
            agetxt.Text = name.Age;
            gendertxt.Text = name.Gender;
            phonetxt.Text = name.Phone_number;
            citytxt.Text = name.City;
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            signin page = new signin();
            this.NavigationService.Navigate(page);
        }
    }
}
