using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankSystem.BL.Models;

namespace BankSystem.BL.Service
{
    public class RegistrationService : IUserService
    {
        public UserModel LoginUser(UserModel user)
        {
            throw new NotImplementedException();
        }

        public bool RegisterUser(UserModel userModel)
        {
            return true;
        }
    }
}
