// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Account.cs" company="StartKicker">
//   
// </copyright>
// <summary>
//   Here are all details for an account
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Kickstarter_web
{
    using System;

    /// <summary>
    /// The account.
    /// </summary>
    public class Account
    {
        /// <summary>
        /// Gets or sets the account id.
        /// </summary>
        public int AccountID { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the phone.
        /// </summary>
        public string Phone
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the picture.
        /// </summary>
        public string Picture
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the biography.
        /// </summary>
        public string Biography
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the location.
        /// </summary>
        public string Location
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the time zone.
        /// </summary>
        public string TimeZone
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the vanity_ url.
        /// </summary>
        public string Vanity_URL
        {
            get;
            set;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Account"/> class.
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
        public Account(int accountId, string email, string phone, string name, string picture, string biography, string location, string timeZone, string vanityUrl)
        {
            AccountID = accountId;
            Email = email;
            Phone = phone;
            Name = name;
            Picture = picture;
            Biography = biography;
            Location = location;
            TimeZone = timeZone;
            Vanity_URL = vanityUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Account"/> class.
        /// </summary>
        /// <param name="accountId">
        /// The account id.
        /// </param>
        public Account(int accountId)
        {
            AccountID = accountId;
        }


    }
}
