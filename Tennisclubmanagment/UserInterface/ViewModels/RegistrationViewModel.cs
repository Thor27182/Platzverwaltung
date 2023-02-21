using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using UserInterface.Commands;

namespace UserInterface.ViewModels
{
    public class RegistrationViewModel: ViewModelBase
    {
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private DateTime _dateOfBirth;
        private string _iban;
        private string _country;
        private string _street;
        private int _streetnumber;
        private int _postalCode;
        private string _city;
        private string _username;
        private SecureString _password;
        private string _role;
        private string _errorMessage;

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
            }
        }
        public string MiddleName
        {
            get { return _middleName; }
            set
            {
                _middleName = value;
            }
        }
        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
            }
        }
        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set
            {
                _dateOfBirth = value;
            }
        }
        public string IBAN
        {
            get { return _iban; }
            set
            {
                _iban = value;
            }
        }
        public string Country
        {
            get { return _country; }
            set
            {
                _country = value;
            }
        }
        public string Street
        {
            get { return _street; }
            set
            {
                _street = value;
            }
        }
        public int StreetNumber
        {
            get { return _streetnumber; }
            set
            {
                _streetnumber = value;
            }
        }
        public int PostalCode
        {
            get { return _postalCode; }
            set
            {
                _postalCode = value;
            }
        }
        public string City
        {
            get { return _city; }
            set
            {
                _city = value;
            }
        }
        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
            }
        }
        public SecureString Password
        {
            get { return _password; }
            set
            {
                _password = value;
            }
        }
        public string Role
        {
            get { return _role; }
            set
            {
                _role = value;
            }
        }
        public string ErrorMessage
        {
            get { return _errorMessage; }
            set
            {
                _errorMessage = value;
            }
        }

        public event RoutedEventHandler NavigateToForm2;
        public event RoutedEventHandler NavigateToForm3;
        public event RoutedEventHandler NavigateToIndex;

        public ICommand NavigateToForm2Command { get; }
        public ICommand NavigateToForm3Command { get; }
        public ICommand NavigateToIndexCommand { get; }

        public RegistrationViewModel()
        {
            NavigateToForm2Command = new ViewModelCommand(ExecuteContinueToForm2);
            NavigateToForm3Command = new ViewModelCommand(ExecuteContinueToForm3);
            NavigateToIndexCommand = new ViewModelCommand(ExecuteRegister);
        }
        private void ExecuteContinueToForm2(object commandParameter)
        {
            // Nach oben reichen, dass zu Uebersicht gewechselt werden soll
            // TODO: Einbau des Navigationswechsels
            //MessageBox.Show("Overview");
            NavigateToForm2?.Invoke(this, new RoutedEventArgs());
        }

        private void ExecuteContinueToForm3(object commandParameter)
        {
            // Nach oben reichen, dass zu Uebersicht gewechselt werden soll
            // TODO: Einbau des Navigationswechsels
            //MessageBox.Show("Overview");
            NavigateToForm3?.Invoke(this, new RoutedEventArgs());
        }

        private void ExecuteRegister(object commandParameter)
        {
            // Nach oben reichen, dass zu Uebersicht gewechselt werden soll
            // TODO: Einbau des Navigationswechsels
            MessageBox.Show("Erfolgreich Registriert!");
            NavigateToIndex?.Invoke(this, new RoutedEventArgs());
        }
    }
}
