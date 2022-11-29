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

namespace UserInterface
{
    /// <summary>
    /// Interaktionslogik für LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        public void Click_Login(object sender, RoutedEventArgs e)
        {
            // TODO: Methode aus Login-Bibliothek verwenden
            /*
            if (true) {
                return true;
            }
            

            return false;*/

            Login(username.Text, password.Text);
        }

        public void Login(string username, string password)
        {
            // TODO: Login
        }

    }
}
