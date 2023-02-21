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
using UserInterface.Commands;
using UserInterface.ViewModels;

namespace UserInterface.Views
{
    /// <summary>
    /// Interaktionslogik für IndexPage.xaml
    /// </summary>
    public partial class IndexPage : Page
    {
        //ICommand NavigationCommand { get; set; }
        /*
        public ICommand NavigateToOverviewCommand { get; }
        public ICommand NavigateToLoginCommand { get; }
        public ICommand NavigateToRegistrationCommand { get; }
        */


        public IndexPage()
        {
            InitializeComponent();

            //NavigationService.Navigate(new Uri((string)e.Parameter, UriKind.Relative));

            (this.DataContext as IndexViewModel).NavigateToOverview += OnNavigateToOverview;
            (this.DataContext as IndexViewModel).NavigateToLogin += OnNavigateToLogin;
            (this.DataContext as IndexViewModel).NavigateToRegistration += OnNavigateToRegistration;

        }


        public void OnNavigateToOverview(object sender, RoutedEventArgs e)
        {
            // TODO: zur (Gäste-)Übersichtsseite anpassen
            this.NavigationService.Navigate(new LoginPage());
        }

        public void OnNavigateToLogin(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new LoginPage());
        }

        public void OnNavigateToRegistration(object sender, RoutedEventArgs e)
        {
            // TODO: zur Registrierungsseite anpassen
            this.NavigationService.Navigate(new RegistrationPage1());
        }

        private void Index_OnButtonClicked(object sender, RoutedEventArgs e)
        {
            switch ((sender as Button).Name)
            {
                case "uebersichtBtn":
                    OnNavigateToOverview(new HomePage(), e);
                    break;
                case "loginBtn":
                    OnNavigateToLogin(new LoginPage(), e);
                    break;
                case "regisrierenBtn":
                    OnNavigateToRegistration(new RegistrationPage(), e);
                    break;
                default:
                    break;
            }
        }


        //Ansatz nach: 
        //https://social.msdn.microsoft.com/Forums/vstudio/en-US/51d8e3ba-6bf9-4304-bb15-64a96e28159b/wpf-how-to-navigate-from-page-to-page-for-frame-in-code-behind?forum=wpf
    }
}
