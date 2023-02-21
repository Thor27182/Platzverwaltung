using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using UserInterface.Commands;
//using App.Utility.Hasher;

namespace UserInterface.ViewModels
{
    //public class LoginViewModel : ViewModelBase
    public class LoginViewModel
    {
        // Benutzername
        private string _username;
        // Passwort
        private SecureString _password;
        // Fehlermeldung
        private string _errorMessage;

        
        //private IUserRepository userRepository;

        public string Username
        {
            get { return _username; }
            set { 
                _username = value;
                //OnPropertyChanged(nameof(Username));
            }
        }
        public SecureString Password {
            get { return _password; }
            set
            {
                _password = value;
                //OnPropertyChanged(nameof(Password));
                //_passwort = Hasher.Hash(value);
            }
        }
        public string ErrorMessage {
            get { return _errorMessage; }
            set
            {
                _errorMessage = value;
                //OnPropertyChanged(nameof(ErrorMessage));
            }
        }

        public ICommand LoginCommand { get; }

        public LoginViewModel()
        {
            //userRepository = new UserRepository();
            // LoginCommand Aktion mit Validierung
            LoginCommand = new ViewModelCommand(ExecuteLoginCommand, CanExecuteLoginCommand);
        }

        /// <summary>
        /// Methode zum Validieren der Login-Daten entsprechend Mindestlaengen
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        private bool CanExecuteLoginCommand(object obj)
        {
            bool validData;
            if (string.IsNullOrWhiteSpace(Username) || Username.Length < 5 ||
                Password == null || Password.Length < 5)
            {

                validData = false;
            }
            else
            {
                validData = true;
            }
            return validData;
        }

        /// <summary>
        /// Methode zum Durchfuehren des Logins
        /// </summary>
        /// <param name="obj"></param>
        private void ExecuteLoginCommand(object obj)
        {
            //var isValidUser = userRepository.AuthenticateUser(new NetworkCredential(Username, Password));
            // wieder rausnehmen, sobald die obere Zeile funktioniert:
            var isValidUser = true;

            if (isValidUser)
            {
                Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(Username), null);
            }
            else
            {
                ErrorMessage = "* ungültiger Username oder ungültiges Passwort";
            }

        }
    }
}
