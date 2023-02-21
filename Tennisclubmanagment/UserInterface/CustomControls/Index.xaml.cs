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
using UserInterface.Views;

namespace UserInterface.CustomControls
{
    /// <summary>
    /// Interaktionslogik für Index.xaml
    /// </summary>
    public partial class Index : UserControl
    {
        public event EventHandler OnButtonClicked;

        public Index()
        {
            InitializeComponent();
        }

        private void Uebersicht_Button_Click(object sender, RoutedEventArgs e)
        {
            OnButtonClicked?.Invoke(sender, e);
        }

        private void Login_Button_Click(object sender, RoutedEventArgs e)
        {
            OnButtonClicked?.Invoke(sender, e);
        }

        private void Registrierung_Button_Click(object sender, RoutedEventArgs e)
        {
            OnButtonClicked?.Invoke(sender, e);
        }
    }
}
