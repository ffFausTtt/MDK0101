using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDK0101Program
{
    public partial class User
    {
        public string gender;
        public string Genders
        {
            get { return gender; }
            set { gender = value; }

        }

        public string role;
        public string Roles
        {
            get { return role; }
            set { role = value; }

        }
    }
    public class Users
    {
        public List<User> usr;
        public Users()
        {
            usr = newuser();
        }

        public List<User> newuser()
        {
            List<User> users = new List<User>();
            User buff;
            List<User> bdusers = Base.dataBase.User.ToList();

            foreach (User user in bdusers)
            {
                buff = new User();
                buff.ID_User = user.ID_User;
                buff.SurName = user.SurName;
                buff.Name = user.Name;
                buff.Patronymic = user.Patronymic;
                buff.Login = user.Login;
                buff.Password = user.Password;
                buff.ID_Gender = user.ID_Gender;
                buff.Date_Of_Birth = user.Date_Of_Birth;
                buff.ID_Role = user.ID_Role;

                Role role = Base.dataBase.Role.FirstOrDefault(x => x.ID_Role == buff.ID_Role);
                buff.role = user.role;
                users.Add(buff);
            }
            return users;
        }
    }
}
