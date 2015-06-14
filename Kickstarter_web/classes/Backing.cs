// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Backing.cs" company="">
//   
// </copyright>
// <summary>
//   The backing.
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
        /// The pledge amount.
        /// </param>
        /// <param name="betaald">
        /// The betaald.
        /// </param>
        /// <param name="projectId">
        /// The project id.
        /// </param>
        /// <param name="accountId">
        /// The account id.
        /// </param>
        public Backing(int pledgeAmount, bool betaald, Project projectId, int accountId)
        {
            PledgeAmount = pledgeAmount;
            Betaald = betaald;
            ProjectID = projectId;
            AccountID = accountId;  
        }

    }
}
