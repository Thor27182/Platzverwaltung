using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.RegisterUser
{
    internal class RegisterUserInteractor : IRegisterUserRequestInterface
    {
        RegisterUserRequestmodel _requestmodel;
        RegisterUserResponsmodel _responsmodel;

        public void RegisterUser(
            string username,
            string password,
            string firstName,
            string middelNames,
            string lastName,
            string street,
            int houseNo,
            string postCode,
            string city,
            string iban)
        {
            RegisterUserRequestmodel = new RegisterUserRequestmodel(string username,
            string password,
            string firstName,
            string middelNames,
            string lastName,
            string street,
            int houseNo,
            string postCode,
            string city,
            string iban);
        }
    }
}
