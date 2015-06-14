// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SubCategory.cs" company="StartKicker">
//   
// </copyright>
// <summary>
//   All the data from the Subcategory will be stored in this class
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
    /// All SubCategory data 
    /// </summary>
    public class SubCategory
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
        /// Gets or sets the category.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubCategory"/> class.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="category">
        /// The category.
        /// </param>
        public SubCategory(int id, string name, Category category)
        {
            this.ID = id;
            this.Name = name;
            this.Category = category;
        }
    }
}
