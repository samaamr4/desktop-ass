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
    /// Interaction logic for searchpage.xaml
    /// </summary>
    public partial class searchpage : Page
    {
        Entities1 db =new Entities1();
        public searchpage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            userlog user = new userlog();
            string ages = user.Age;
            dgrid.ItemsSource = db.userlogs.Where(x => x.City == textsearch.Text).ToList();
            this.DataContext = user;
            //dgrid.ItemsSource=db.userlogs.Where(x=> x.City == textsearch.Text).ToList();
        }
    }
}
