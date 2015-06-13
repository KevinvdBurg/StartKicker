using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace Kickstarter_web
{
    public class Category
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public Category(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
