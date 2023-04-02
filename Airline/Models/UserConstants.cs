using Airline.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airline.Models
{
    public class UserConstants
    {
        public static List<Users> Users = new List<Users>()
        {
            new Users() { Username = "4458_admin", EmailAddress = "admin@email.com", Password = "Yasar123!", GivenName = "4458", Surname = "Admin", Role = "Administrator" },
            new Users() { Username = "jason_admin", EmailAddress = "jason.admin@email.com", Password = "MyPass_w0rd", GivenName = "Jason", Surname = "Bryant", Role = "Administrator" },
            new Users() { Username = "elyse_seller", EmailAddress = "elyse.seller@email.com", Password = "MyPass_w0rd", GivenName = "Elyse", Surname = "Lambert", Role = "Seller" },
        };
    }
}