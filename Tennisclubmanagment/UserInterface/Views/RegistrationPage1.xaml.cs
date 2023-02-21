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
using UserInterface.ViewModels;

namespace UserInterface.Views
{
    /// <summary>
    /// Interaktionslogik für RegistrationPage1.xaml
    /// </summary>
    public partial class RegistrationPage1 : Page
    {
        public RegistrationPage1()
        {
            InitializeComponent();

            (this.DataContext as RegistrationViewModel).NavigateToForm2 += OnNavigateToForm2;
        }

        public void OnNavigateToForm2(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new RegistrationPage2());
        }
    }
}
