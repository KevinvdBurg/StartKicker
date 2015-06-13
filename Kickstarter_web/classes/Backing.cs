using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace Kickstarter_web
{
    public class Backing
    {
        public double PledgeAmount { get; set; }

        public bool Betaald { get; set; }

        public  int ProjectID { get; set; }

        public int AccountID { get; set; }

    }
}
