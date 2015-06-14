using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace Kickstarter_web
{
    public class Rewards
    {

        public string Name { get; set; }

        public int Price { get; set; }
        public string Description { get; set; }

        public string Delivery { get; set; }

        public int PrevReward { get; set; }

        public Rewards(string name, int price, string description, string delivery, int prevReward)
        {
            Name = name;
            Price = price;
            Description = description;
            Delivery = delivery;
            PrevReward = prevReward;    
        }

        public Rewards(string name, int price, string description, string delivery)
        {
            Name = name;
            Price = price;
            Description = description;
            Delivery = delivery;
        }

        public Rewards()
        {
            
        }

    }
}
