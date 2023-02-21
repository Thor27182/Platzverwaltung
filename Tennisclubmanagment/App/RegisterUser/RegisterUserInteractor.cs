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
            RegisterUserRequestmodel requestmodel = new RegisterUserRequestmodel(username, password, firstName, middelNames, lastName, street, houseNo, postCode, city, iban);
        }

        public void RegisterUser()
        {
            throw new NotImplementedException();
        }
    }
}
