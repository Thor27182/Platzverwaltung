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
using System.Windows.Shapes;
using UserInterface.CustomControls;

namespace UserInterface.Views
{
    /// <summary>
    /// Interaktionslogik für MainView.xaml
    /// </summary>
    public partial class MainView : Window
    {

        public MainView()
        {
            InitializeComponent();

        }

        #region Navigation
        // Die Methoden hier werden fuer den Footer noch benoetigt!

        /// <summary>
        /// Methode zum Aendern des Contents im Hauptbereich des Fensters - erstmal verworfen
        /// </summary>
        /// <param name="page">Inhaltsseite fuer den Frame</param>
        private void ChangeContent(Page page)
        {
            content.Navigate(page);
        }

        /// <summary>
        /// Methode zur Navigation zum
        /// </summary>
        private void NavigateToOverview() 
        {
            // TODO: Anpassen zu einer OverviewPage
            ChangeContent(new LoginPage());
        }

        private void NavigateToLogin()
        {
            ChangeContent(new LoginPage());
        }

        private void NavigateToRegistration()
        {
            // TODO: Anpassen zu einer RegistrationPage
            ChangeContent(new LoginPage());
        }

        private void NavigateToAGB()
        {
            // TODO: Anpassen zu einer AGBPage
            ChangeContent(new LoginPage());
        }

        private void NavigateToDatenschutz()
        {
            // TODO: Anpassen zu einer DatenschutzPage
            ChangeContent(new LoginPage());
        }

        private void NavigateToImpressum()
        {
            // TODO: Anpassen zu einer ImpressumPage
            ChangeContent(new LoginPage());
        }

        // TODO: Beachtung des Rechte-/Rollenkonzepts bezüglich was angezeigt wird/ welche Seiten durch Navigation erreichbar


        private void CustomFooter_OnButtonClicked(object sender, EventArgs e)
        {
            switch ((sender as Button).Name)
            {
                case "agbBtn":
                    // TODO: Anpassen zur Anzeige der AGBs
                    ChangeContent(new LoginPage());
                    //ChangeContent(new AGBPage());
                    break;
                case "datenschutzBtn":
                    ChangeContent(new DatenschutzPage());
                    break;
                case "impressumBtn":
                    ChangeContent(new ImpressumPage());
                    break;
                default:
                    break;
            }
        }

        #endregion
    }
}
