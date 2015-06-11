using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace Kickstarter_web
{
    public class Admin : Account
    {
        public string WorkEmail
        {
            get;
            set;
        }

        public double Salary
        {
            get;
            set;
        }

        public string Department
        {
            get;
            set;
        }

        public Admin(int accountId, string email, string phone, string name, string picture, string biography, string location, string timeZone, string vanityUrl, string workEmail, double salary, string department)
            : base(accountId, email, phone, name, picture, biography, location, timeZone, vanityUrl)
        {
            WorkEmail = workEmail;
            Salary = salary;
            Department = department;    
        }


        public Admin(int accountId)
            : base(accountId)
        {
            
        }
    }
}
