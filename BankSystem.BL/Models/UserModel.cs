using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.BL.Models
{
    public class UserModel
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string ID { get; set; }
        public string Password { get; set; }
        public int AccountID { get; set; }

    }
}
