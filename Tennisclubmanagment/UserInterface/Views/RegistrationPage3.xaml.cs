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
    /// Interaktionslogik für RegistrationPage3.xaml
    /// </summary>
    public partial class RegistrationPage3 : Page
    {
        public RegistrationPage3()
        {
            InitializeComponent();

            (this.DataContext as RegistrationViewModel).NavigateToIndex += OnNavigateToIndex;
        }

        public void OnNavigateToIndex(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new IndexPage());
        }
    }
}
