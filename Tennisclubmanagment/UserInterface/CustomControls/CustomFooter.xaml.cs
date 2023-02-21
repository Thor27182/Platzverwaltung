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
        // Eventhandler zum verbinden mit Uebergeordnetem Element
        public event EventHandler OnButtonClicked;


        public CustomFooter()
        {
            InitializeComponent();
        }

        // Mehrere Methoden in derzeitiger Fassung unnoetig, da alle das gleiche tun
        // TODO: Anpassen, wenn keine weiteren Aenderungen
        // Besser als Command in MainViewModel mit hier im XAML MainViewModel als DataContext

        /// <summary>
        /// Methode zum Auslösen des Ereignisses zum Einleiten der Navigation
        /// </summary>
        /// <param name="sender">Auslöserelement</param>
        /// <param name="e">Ereignisdaten</param>
        private void AGB_Button_Click(object sender, RoutedEventArgs e)
        {
            OnButtonClicked?.Invoke(sender, e);
        }

        /// <summary>
        /// Methode zum Auslösen des Ereignisses zum Einleiten der Navigation
        /// </summary>
        /// <param name="sender">Auslöserelement</param>
        /// <param name="e">Ereignisdaten</param>
        private void Datenschutz_Button_Click(object sender, RoutedEventArgs e)
        {
            OnButtonClicked?.Invoke(sender, e);
        }

        /// <summary>
        /// Methode zum Auslösen des Ereignisses zum Einleiten der Navigation
        /// </summary>
        /// <param name="sender">Auslöserelement</param>
        /// <param name="e">Ereignisdaten</param>
        private void Impressum_Button_Click(object sender, RoutedEventArgs e)
        {
            OnButtonClicked?.Invoke(sender, e);
        }
    }
}
