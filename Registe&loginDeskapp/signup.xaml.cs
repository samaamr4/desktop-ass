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
    /// Interaction logic for signup.xaml
    /// </summary>
    public partial class signup : Page
    {
        Entities1 db=new Entities1();
        string gender;
        public signup()
        {
            InitializeComponent();
        }
        bool isvalid(string pass)
        {
            bool upper, lowe, sp, num;
            upper = lowe = sp = num = false;
            string sps = "!@#$%^&*_";
            foreach(char c in pass)
            {
                if(c>='A'&& c <= 'Z')
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int ages = int.Parse(agetxt.Text);
            string num=phonetxt.Text;
            if (isvalid(passtxt.Text))
            {
                if (ages >= 18 && ages <= 60)
                {
                    if (num.Length == 11)
                    {
                        userlog user = new userlog();
                        user.Username = usernametxt.Text;
                        user.Passwords = passtxt.Text;
                        user.Age = agetxt.Text;
                        user.Gender = gender;
                        user.City=comb.Text;
                        user.Phone_number = phonetxt.Text;
                        db.userlogs.Add(user);
                        db.SaveChanges();
                        MessageBox.Show("Sign Sucessfully");
                        signin page = new signin();
                        this.NavigationService.Navigate(page);
                    }
                    else
                    {
                        MessageBox.Show("Ensure The Number Length Please");
                    }

                }
                else
                {
                    MessageBox.Show("Ensure The Age Please");
                }
            }
            else if(!isvalid(passtxt.Text))
            {
                MessageBox.Show("Password Must Be strong");
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            gender = "Male";
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            gender = "Female";
        }
    }
}
