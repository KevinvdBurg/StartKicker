namespace Kickstarter_web
{
    using System;

    public class Account
    {
        public int AccountID { get; set; }
        public string Email { get; set; }

        public string Phone
        {
            get;
            set;
        }

        public string Password
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public string Picture
        {
            get;
            set;
        }

        public string Biography
        {
            get;
            set;
        }

        public string Location
        {
            get;
            set;
        }

        public DateTime TimeZone
        {
            get;
            set;
        }

        public string Vanity_URL
        {
            get;
            set;
        }

        public Account(int accountId, string email, string phone, string password, string name, string picture, string biography, string location, DateTime timeZone, string vanityUrl)
        {
            AccountID = accountId;
            Email = email;
            Phone = phone;
            Password = password;
            Name = name;
            Picture = picture;
            Biography = biography;
            Location = location;
            TimeZone = timeZone;
            Vanity_URL = vanityUrl;
        }

        public Account(int accountId)
        {
            AccountID = accountId;
        }


    }
}
