using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using UserInterface.Commands;
using UserInterface.Views;

namespace UserInterface.ViewModels
{
    public class IndexViewModel : ViewModelBase
    {
        public event RoutedEventHandler NavigateToOverview;
        public event RoutedEventHandler NavigateToLogin;
        public event RoutedEventHandler NavigateToRegistration;

        public ICommand NavigateToOverviewCommand { get; }
        public ICommand NavigateToLoginCommand { get; }
        public ICommand NavigateToRegistrationCommand { get; }

        public IndexViewModel() {
            NavigateToOverviewCommand = new ViewModelCommand(ExecuteNavigateToOverviewCommand);
            NavigateToLoginCommand = new ViewModelCommand(ExecuteNavigateToLoginCommand);
            NavigateToRegistrationCommand = new ViewModelCommand(ExecuteNavigateToRegistrationCommand);
        }

        public void ExecuteNavigateToOverviewCommand(object obj) 
        {
            // Nach oben reichen, dass zu Uebersicht gewechselt werden soll
            // TODO: Einbau des Navigationswechsels
            //MessageBox.Show("Overview");
            NavigateToOverview?.Invoke(this, new RoutedEventArgs());
        }

        public void ExecuteNavigateToLoginCommand(object obj)
        {
            // Nach oben reichen, dass zu Uebersicht gewechselt werden soll
            // TODO: Einbau des Navigationswechsels
            //MessageBox.Show("Login");
            NavigateToLogin?.Invoke(this, new RoutedEventArgs());
        }

        public void ExecuteNavigateToRegistrationCommand(object obj)
        {
            // Nach oben reichen, dass zu Uebersicht gewechselt werden soll
            // TODO: Einbau des Navigationswechsels
            //MessageBox.Show("Registration");
            NavigateToRegistration?.Invoke(this, new RoutedEventArgs());
        }
    }
}
