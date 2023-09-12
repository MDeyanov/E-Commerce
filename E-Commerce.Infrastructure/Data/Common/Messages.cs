using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Infrastructure.Data.Common
{
    public class Messages
    {
        public class UserMessages
        {
            public const string EmailAlreadyExists = "This email address is already registered.";
            public const string NamesLenght = "The {0} must be at least {2} and at max {1} characters long.";


        }
        public class AddressMessages
        {

            public const string StreetMessage = "Street is required.";
            public const string CityMessage = "City is required.";
            public const string PostalCodeMessage = "PostalCode is required.";
            public const string CountryMessage = "Country is required.";


        }

    }
}
