using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace Kickstarter_web
{
    public class Backing
    {
        public int PledgeAmount { get; set; }

        public bool Betaald { get; set; }

        public Project ProjectID { get; set; }

        public int AccountID { get; set; }

        public Backing(int pledgeAmount, bool betaald, Project projectId, int accountId)
        {
            PledgeAmount = pledgeAmount;
            Betaald = betaald;
            ProjectID = projectId;
            AccountID = accountId;  
        }

    }
}
