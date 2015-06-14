// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Backing.cs" company="StartKicker">
//   
// </copyright>
// <summary>
//   This object will stored all the inforamtion from a backing
// </summary>
// --------------------------------------------------------------------------------------------------------------------



using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace Kickstarter_web
{
    /// <summary>
    /// The backing.
    /// </summary>
    public class Backing
    {
        /// <summary>
        /// Gets or sets the pledge amount.
        /// </summary>
        public int PledgeAmount { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether betaald.
        /// </summary>
        public bool Betaald { get; set; }

        /// <summary>
        /// Gets or sets the project id.
        /// </summary>
        public Project ProjectID { get; set; }

        /// <summary>
        /// Gets or sets the account id.
        /// </summary>
        public int AccountID { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Backing"/> class.
        /// </summary>
        /// <param name="pledgeAmount">
        /// The pledge amount of the backing
        /// </param>
        /// <param name="betaald">
        /// A bool that set if the backing is payed
        /// </param>
        /// <param name="projectId">
        /// The Project object for where the backing is made for
        /// </param>
        /// <param name="accountId">
        /// The AccountID from the account who is making the Backing
        /// </param>
        public Backing(int pledgeAmount, bool betaald, Project projectId, int accountId)
        {
            this.PledgeAmount = pledgeAmount;
            this.Betaald = betaald;
            this.ProjectID = projectId;
            this.AccountID = accountId;  
        }

    }
}
