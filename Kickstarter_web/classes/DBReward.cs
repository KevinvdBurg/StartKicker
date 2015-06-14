// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DBReward.cs" company="StartKicker">
//   
// </copyright>
// <summary>
//   Here will be all the DB Connection from a reward
// </summary>
// --------------------------------------------------------------------------------------------------------------------



using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace Kickstarter_web
{
    using System.Collections.Generic;
    using System.Web.Hosting;

    using Oracle.DataAccess.Client;

    /// <summary>
    /// All methods for a Reward
    /// </summary>
    public class DBReward : Database
    {
        /// <summary>
        /// Insert a reward to an account
        /// </summary>
        /// <param name="reward">
        /// A reward Object where all the data is stored for that reward
        /// </param>
        /// <param name="projectID">
        /// The project id from the project the reward it needs to add
        /// </param>
        /// <returns>
        /// If its is succesfull is will return True, Else False
        /// </returns>
        public bool Insert(Rewards reward, int projectID)
        {
            string sql = string.Empty;
            if (reward.PrevReward == 0)
            {
                sql = "INSERT INTO KICKSTARTER_REWARDS (PROJECT_ID, KICKNAME, PRICE, DESCRIPTION, ESTIMATEDDELIVERY, SHIPPINGDETAILS) VALUES(:projectID, :kickname, :price ,:description, :esti,:shipdetails)";
            }
            else
            {
                sql = "INSERT INTO KICKSTARTER_REWARDS (PROJECT_ID, KICKNAME, PRICE, DESCRIPTION, ESTIMATEDDELIVERY, SHIPPINGDETAILS, PREVREWARD_ID) VALUES(:projectID, :kickname, :price ,:description, :esti,:shipdetails, :prevrewardID)";
            }
            
            bool resultaat = false;
            try
            {
                this.Connect();
                OracleCommand cmd = new OracleCommand(sql, this.connection);
                cmd.Parameters.Add(new OracleParameter("projectID", projectID));
                cmd.Parameters.Add(new OracleParameter("kickname", reward.Name));
                cmd.Parameters.Add(new OracleParameter("price", reward.Price));
                cmd.Parameters.Add(new OracleParameter("description", reward.Description));
                cmd.Parameters.Add(new OracleParameter("esti", reward.Delivery));
                cmd.Parameters.Add(new OracleParameter("shipdetails", reward.Delivery));
                if (reward.PrevReward != 0)
                {
                    cmd.Parameters.Add(new OracleParameter("prevrewardID", reward.PrevReward));
                }

                cmd.ExecuteNonQuery();
                resultaat = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                this.connection.Close();
            }

            return resultaat;

        }

        /// <summary>
        /// Gets a Specific Reward.
        /// </summary>
        /// <param name="rewardID">
        /// The reward id for that reward
        /// </param>
        /// <returns>
        /// A Reward Object that contans all the data from a Reward
        /// </returns>
        public Rewards GetReward(int rewardID)
        {
            // string sql = "SELECT p.TITLE, p.SHORTBLURB, p.CATEGORY_ID, c.KICKNAME, p.SUBCATEGORY_ID, p.PROJECT_LOCATION, p.FUNDING_DURATION, p.FUNDING_GOAL, p.PROJECTVIDEO, p.PROJECTDESCRIPTION, p.RISKSANDCHALLENGES, p.PROJECT_ID FROM KICKSTARTER_PROJECT p INNER JOIN KICKSTARTER_CATEGORY c ON c.CATEGORY_ID = p.CATEGORY_ID WHERE p.PROJECT_ID = :projectID";
            string sql = "SELECT REWARD_ID, PROJECT_ID, KICKNAME, PRICE, DESCRIPTION, ESTIMATEDDELIVERY,SHIPPINGDETAILS, PREVREWARD_ID FROM KICKSTARTER_REWARDS WHERE REWARD_ID = :rewardID";

            Rewards thisRewards = new Rewards();
            try
            {
                this.Connect();
                OracleCommand cmd = new OracleCommand(sql, this.connection);
                cmd.Parameters.Add(new OracleParameter("rewardID", rewardID));
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    Rewards tempReward = new Rewards(
                        Convert.ToString(reader["KICKNAME"]), 
                        Convert.ToInt32(reader["PRICE"]), 
                        Convert.ToString(reader["DESCRIPTION"]), 
                        Convert.ToString(reader["ESTIMATEDDELIVERY"]), 
                        Convert.ToInt32(reader["PREVREWARD_ID"]), 
                        Convert.ToInt32(reader["REWARD_ID"]));
                      
                    thisRewards = tempReward;
                }
            }
            catch (OracleException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                this.connection.Close();
            }

            return thisRewards;
        }

        /// <summary>
        /// Gets all the Rewards form a given Project
        /// </summary>
        /// <param name="projectID">
        /// The project id.
        /// </param>
        /// <returns>
        /// A List of Rewards
        /// </returns>
        public List<Rewards> GetAllRewardsPerProject(int projectID)
        {
            string sql = "SELECT REWARD_ID, PROJECT_ID, KICKNAME, PRICE, DESCRIPTION, ESTIMATEDDELIVERY,SHIPPINGDETAILS, PREVREWARD_ID FROM KICKSTARTER_REWARDS WHERE PROJECT_ID = :projectID";
            List<Rewards> allRewards = new List<Rewards>();
            try
            {
                this.Connect();
                OracleCommand cmd = new OracleCommand(sql, this.connection);
                cmd.Parameters.Add(new OracleParameter("projectID", projectID));
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Rewards tempReward = new Rewards(
                            Convert.ToString(reader["KICKNAME"]), 
                            Convert.ToInt32(reader["PRICE"]), 
                            Convert.ToString(reader["DESCRIPTION"]), 
                            Convert.ToString(reader["ESTIMATEDDELIVERY"]), 
                            Convert.ToInt32(reader["PREVREWARD_ID"]), 
                            Convert.ToInt32(reader["REWARD_ID"]));
                        allRewards.Add(tempReward);
                    }
                       
                }
            }
            catch (OracleException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                this.connection.Close();
            }

            return allRewards; 
        }
    }
}
