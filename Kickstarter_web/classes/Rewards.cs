// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Rewards.cs" company="StartKicker">
//   
// </copyright>
// <summary>
//   All Data from a Reward
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
    /// The reward object where all the data is stored.
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
        /// If all the information is Known
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
            this.Name = name;
            this.Price = price;
            this.Description = description;
            this.Delivery = delivery;
            this.PrevReward = prevReward;
            this.ThisReward = thisReward;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rewards"/> class.
        /// If its own ID is not known
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
            this.Name = name;
            this.Price = price;
            this.Description = description;
            this.Delivery = delivery;
            this.PrevReward = prevReward;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rewards"/> class.
        /// If its own ID is not known or its prev reward
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
            this.Name = name;
            this.Price = price;
            this.Description = description;
            this.Delivery = delivery;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rewards"/> class.
        /// </summary>
        public Rewards()
        {
        }
    }
}