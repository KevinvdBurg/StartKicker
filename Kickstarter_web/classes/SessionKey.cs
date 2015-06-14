// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SessionKey.cs" company="">
//   
// </copyright>
// <summary>
//   The my keys.
// </summary>
// --------------------------------------------------------------------------------------------------------------------



using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kickstarter_web.classes
{
    /// <summary>
    /// The my keys.
    /// </summary>
    public sealed class myKeys
    {
        /// <summary>
        /// Prevents a default instance of the <see cref="myKeys"/> class from being created.
        /// </summary>
        private myKeys()
        {
            
        }

        /// <summary>
        /// The key_account id.
        /// </summary>
        public static readonly string key_accountID = "accountID";

        /// <summary>
        /// The key_rights.
        /// </summary>
        public static readonly string key_rights = "rights";
    }
    
}