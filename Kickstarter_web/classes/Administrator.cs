using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace Kickstarter_web
{
    public class Administrator
    {
        private DBLogin dblogin = new DBLogin();
        public Account Login(string email, string password)
        {
            Account getAccount = this.dblogin.Login(email, password);
            return getAccount;
        }
    }
}
