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
    /// Interaction logic for Deletepage.xaml
    /// </summary>
    public partial class Deletepage : Page
    {
        Entities1 db=new Entities1();
        public Deletepage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            userlog log=new userlog();
            log = db.userlogs.FirstOrDefault(x => x.Phone_number == textdel.Text);
            if (log != null )
            {
                db.userlogs.Remove(log);
                db.SaveChanges();
                MessageBox.Show("User Delete Sucessfully");
            }
        }
    }
}
