using BankSystem.BL.Models;
using BankSystem.BL.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BankSystem.BL.Repositorys
{
    public class UserServiceXmlRepository : IUserService
    {
        String path = "Users.xml";
        HashSet<UserModel> users;

        public UserServiceXmlRepository()
        {
            users = new HashSet<UserModel>(new UserModelComparer());
            if (File.Exists(path))
            {
                var document = XDocument.Load(path);
                var data = document
                         .Element("Users")
                         ?.Elements("User")
                         .Select(u => new UserModel
                         {
                             FirstName = u.Attribute("FirstName").Value,
                             LastName = u.Attribute("LastName").Value,
                             Email = u.Attribute("Email").Value,
                             Password = u.Attribute("Password").Value
                         });
                users.UnionWith(data);
            }
        }

        public bool RegisterUser(UserModel user)
        {
            var registred = users.Add(user);
            XDocument xDocument = new XDocument(
                new XElement("Users",
                    users.Select(u =>
                        new XElement("User",
                            new XAttribute("FirstName", u.FirstName),
                            new XAttribute("LastName", u.LastName),
                            new XAttribute("Email", u.Email),
                            new XAttribute("Password", u.Password)))));
            xDocument.Save(path);
            return registred;
        }

        public UserModel LoginUser(UserModel user)
        {
            return users.FirstOrDefault(e =>
                e.Email.Equals(user.Email, StringComparison.OrdinalIgnoreCase)
                && e.Password == user.Password);
        }
    }

    internal class UserModelComparer : IEqualityComparer<UserModel>
    {
        public bool Equals(UserModel x, UserModel y)
        {
            return x.Email == y.Email;
        }

        public int GetHashCode(UserModel obj)
        {
            return obj.Email.Length;
        }
    }
}
