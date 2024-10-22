using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Pet_Shop.model
{
    public class User
    {
        private string userId;
        private string fullName;
        private string password;
        private string email;
        private string phoneNumber;
        private string address;

        public User(string userId, string fullName, string password, string email, string phoneNumber, string address)
        {   
            this.userId = userId;
            this.fullName = fullName;
            this.password = password;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.address = address;
        }

        public string UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

    }

}