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
            (content.Content as Index).OnButtonClicked += FrameContent_OnClicked;
        }

        private void CustomFooter_OnButtonClicked(object sender, EventArgs e)
        {
            switch ((sender as Button).Name) {
                case "agbBtn":
                    // TODO: Anpassen zur Anzeige der AGBs
                    //ChangeFrameContent("/CustomControls/CustomLoginForm.xaml");
                    ChangeContent(new AGBPage());
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

        private void FrameContent_OnClicked(object sender, EventArgs e) 
        {
            switch ((sender as Button).Name)
            {
                case "uebersichtBtn":
                    // TODO: anpassen 
                    ChangeContent(new AGBPage());
                    break;
                case "loginBtn":
                    ChangeContent(new LoginPage());
                    break;
                case "regisrierenBtn":
                    // TODO: anpassen
                    ChangeContent(new ImpressumPage());
                    break;
                default:
                    break;
            }
        }



        private void ChangeContent(Page page) { 
            content.Navigate(page);
        }

        /*
        private void ChangeFrameContent(string source) {
            content.Source = new Uri(source, UriKind.Relative);
        }*/
    }
}
