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

        // um aus MainWindow vom Event mitzubekommen
        public event EventHandler NavigateBackHandler;

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

            // Password hashen
            //string hashedPassword = Hashing.DoHash(this.password.Text);

            //Login(username.Text, hashedPassword);
        }
        public void Click_Back(object sender, RoutedEventArgs e)
        {
            // Event ausloesen
            NavigateBackHandler?.Invoke(this, EventArgs.Empty);
        }

        public void Login(string username, string password)
        {
            // TODO: Login
        }
    }
}
