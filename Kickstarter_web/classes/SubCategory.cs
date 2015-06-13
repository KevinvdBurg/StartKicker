using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace Kickstarter_web
{
    public class SubCategory
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public Category Category { get; set; }

        public SubCategory(int id, string name, Category category)
        {
            ID = id;
            Name = name;
            Category = category;
        }
    }
}
