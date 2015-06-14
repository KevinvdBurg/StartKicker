// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Admin.cs" company="StartKicker">
//   
// </copyright>
// <summary>
//   If an account is an Admin he will get extra info
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
    /// The admin.
    /// </summary>
    public class Admin : Account
    {
        /// <summary>
        /// Gets or sets the work email.
        /// </summary>
        public string WorkEmail
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the salary.
        /// </summary>
        public double Salary
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the department.
        /// </summary>
        public string Department
        {
            get;
            set;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Admin"/> class.
        /// </summary>
        /// <param name="accountId">
        /// The account id.
        /// </param>
        /// <param name="email">
        /// The email.
        /// </param>
        /// <param name="phone">
        /// The phone.
        /// </param>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="picture">
        /// The picture.
        /// </param>
        /// <param name="biography">
        /// The biography.
        /// </param>
        /// <param name="location">
        /// The location.
        /// </param>
        /// <param name="timeZone">
        /// The time zone.
        /// </param>
        /// <param name="vanityUrl">
        /// The vanity url.
        /// </param>
        /// <param name="workEmail">
        /// The work email.
        /// </param>
        /// <param name="salary">
        /// The salary.
        /// </param>
        /// <param name="department">
        /// The department.
        /// </param>
        public Admin(int accountId, string email, string phone, string name, string picture, string biography, string location, string timeZone, string vanityUrl, string workEmail, double salary, string department)
            : base(accountId, email, phone, name, picture, biography, location, timeZone, vanityUrl)
        {
            this.WorkEmail = workEmail;
            this.Salary = salary;
            this.Department = department;    
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Admin"/> class.
        /// </summary>
        /// <param name="accountId">
        /// The account id.
        /// </param>
        public Admin(int accountId)
            : base(accountId)
        {
            
        }
    }
}
