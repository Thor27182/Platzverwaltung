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

namespace UserInterface.CustomControls
{
    /// <summary>
    /// Interaktionslogik für CustomFooter.xaml
    /// </summary>
    public partial class CustomFooter : UserControl
    {
        public event EventHandler OnButtonClicked;


        public CustomFooter()
        {
            InitializeComponent();
        }

        private void AGB_Button_Click(object sender, RoutedEventArgs e)
        {
            OnButtonClicked?.Invoke(sender, e);
        }

        private void Datenschutz_Button_Click(object sender, RoutedEventArgs e)
        {
            OnButtonClicked?.Invoke(sender, e);
        }

        private void Impressum_Button_Click(object sender, RoutedEventArgs e)
        {
            OnButtonClicked?.Invoke(sender, e);
        }
    }
}
