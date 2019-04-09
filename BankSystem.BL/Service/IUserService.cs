using BankSystem.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.BL.Service
{
    public interface IUserService
    {
        UserModel RegisterUser(UserModel userModel);
    }
}
