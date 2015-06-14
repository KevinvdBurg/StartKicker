﻿using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace Kickstarter_web
{
    using System.Collections.Generic;
    using System.Web.Hosting;

    using Oracle.DataAccess.Client;

    public class DBReward : Database
    {
        public void Delete()
        {
            throw new System.NotImplementedException();
        }

        public bool Insert(Rewards reward, int projectID)
        {
            string sql = "";
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

        public void Update()
        {
            throw new System.NotImplementedException();
        }

        public Rewards GetReward(int rewardID)
        {
            //string sql = "SELECT p.TITLE, p.SHORTBLURB, p.CATEGORY_ID, c.KICKNAME, p.SUBCATEGORY_ID, p.PROJECT_LOCATION, p.FUNDING_DURATION, p.FUNDING_GOAL, p.PROJECTVIDEO, p.PROJECTDESCRIPTION, p.RISKSANDCHALLENGES, p.PROJECT_ID FROM KICKSTARTER_PROJECT p INNER JOIN KICKSTARTER_CATEGORY c ON c.CATEGORY_ID = p.CATEGORY_ID WHERE p.PROJECT_ID = :projectID";
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
