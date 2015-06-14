// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Rewards.cs" company="">
//   
// </copyright>
// <summary>
//   The rewards.
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
    /// The rewards.
    /// </summary>
    public class Rewards
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the delivery.
        /// </summary>
        public string Delivery { get; set; }

        /// <summary>
        /// Gets or sets the prev reward.
        /// </summary>
        public int PrevReward { get; set; }

        /// <summary>
        /// Gets or sets the this reward.
        /// </summary>
        public int ThisReward { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rewards"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="price">
        /// The price.
        /// </param>
        /// <param name="description">
        /// The description.
        /// </param>
        /// <param name="delivery">
        /// The delivery.
        /// </param>
        /// <param name="prevReward">
        /// The prev reward.
        /// </param>
        /// <param name="thisReward">
        /// The this reward.
        /// </param>
        public Rewards(string name, int price, string description, string delivery, int prevReward, int thisReward)
        {
            Name = name;
            Price = price;
            Description = description;
            Delivery = delivery;
            PrevReward = prevReward;
            ThisReward = thisReward;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rewards"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="price">
        /// The price.
        /// </param>
        /// <param name="description">
        /// The description.
        /// </param>
        /// <param name="delivery">
        /// The delivery.
        /// </param>
        /// <param name="prevReward">
        /// The prev reward.
        /// </param>
        public Rewards(string name, int price, string description, string delivery, int prevReward)
        {
            Name = name;
            Price = price;
            Description = description;
            Delivery = delivery;
            PrevReward = prevReward;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rewards"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="price">
        /// The price.
        /// </param>
        /// <param name="description">
        /// The description.
        /// </param>
        /// <param name="delivery">
        /// The delivery.
        /// </param>
        public Rewards(string name, int price, string description, string delivery)
        {
            Name = name;
            Price = price;
            Description = description;
            Delivery = delivery;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rewards"/> class.
        /// </summary>
        public Rewards()
        {
            
        }

    }
}
