// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Category.cs" company="StartKicker">
//   
// </copyright>
// <summary>
//   The Category for a Project. Here will be stored the ID and the Name of that category.
//   It is used for example the Dropdownlists
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
    /// The Category for a project
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Category"/> class.
        /// </summary>
        /// <param name="id">
        /// The id from the Category
        /// </param>
        /// <param name="name">
        /// The name from the Category
        /// </param>
        public Category(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
    }
}
