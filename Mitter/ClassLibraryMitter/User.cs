using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMitter
{
    public class User
    {
        private int id;
        private string userName, userLastname, password, email;
        private List<User> friends;

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string UserLastname
        {
            get
            {
                return userLastname;
            }

            set
            {
                userLastname = value;
            }
        }

        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        internal List<User> Friends
        {
            get
            {
                return friends;
            }

            set
            {
                friends = value;
            }
        }

        public User()
        {
            friends = new List<User>();
        }

        public User(string _userName, string _userLastName, string _password, string _email)
        {
            UserName = _userName;
            UserLastname = _userLastName;
            Password = _password;
            Email = _email;
        }

       /* public string registerUser(string _userName, string _userLastName, string _password, string _email)
        {
            try
            {
                UserName = _userName;
                UserLastname = _userLastName;
                Password = _password;
                Email = _email;
                return "ok";
            }
            catch (Exception ex)
            {
                throw;
            }
         
        }*/


    }
}
