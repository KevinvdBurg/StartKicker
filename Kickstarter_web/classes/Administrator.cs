// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Administrator.cs" company="StartKicker">
//   
// </copyright>
// <summary>
//   All the functions for the website. You My not call the DB* classes directly. In state class this class
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
    using System.Drawing;

    /// <summary>
    /// The administrator.
    /// </summary>
    public class Administrator
    {
        /// <summary>
        /// The dblogin.
        /// </summary>
        private DBLogin dblogin = new DBLogin();

        /// <summary>
        /// The db account.
        /// </summary>
        private DBAccount dbAccount = new DBAccount();

        /// <summary>
        /// The db project.
        /// </summary>
        private DBProject dbProject = new DBProject();

        /// <summary>
        /// The db reward.
        /// </summary>
        private DBReward dbReward = new DBReward();

        /// <summary>
        /// Login method to get access to your dashboard
        /// </summary>
        /// <param name="email">
        /// An email
        /// </param>
        /// <param name="password">
        /// A password
        /// </param>
        /// <returns>
        /// The <see cref="Account"/>.
        /// </returns>
        public Account Login(string email, string password)
        {
            Account getAccount = this.dblogin.Login(email, password);
            return getAccount;
        }

        /// <summary>
        /// The gets account details Like Name, Location, Etc...
        /// </summary>
        /// <param name="account_id">
        /// An Account ID
        /// </param>
        /// <param name="rights">
        /// The rights of that account
        /// </param>
        /// <returns>
        /// The <see cref="Account"/>.
        /// </returns>
        public Account getAccountDetails(int account_id, string rights)
        {
            Account getAccountDetails = this.dblogin.GetAccount(account_id, rights);

            return getAccountDetails;
        }

        /// <summary>
        /// Registeers an account to the database
        /// </summary>
        /// <param name="account">
        /// An Account that with all the parameter
        /// </param>
        /// <param name="password">
        /// The password for that account. This is to prevent to SQL INjest
        /// </param>
        /// <returns>
        /// If the Registeer is succesfull it returns True else False.
        /// </returns>
        public bool RegisteerAccount(Account account, string password)
        {
            return this.dbAccount.Insert(account, password);
        }

        /// <summary>
        /// Creates an Project
        /// </summary>
        /// <param name="project">
        /// The Project with all its parameters
        /// </param>
        /// <param name="accountID">
        /// An Account ID
        /// </param>
        /// <returns>
        /// If the Create is succesfull it returns True else False.
        /// </returns>
        public bool CreeerProject(Project project, int accountID)
        {
            return this.dbProject.Insert(project, accountID);
        }

        /// <summary>
        /// It gets all the projects that are in the DB.
        /// </summary>
        /// <returns>
        /// A List of all the Projects.
        /// </returns>
        public List<Project> GetallProject()
        {
            return this.dbProject.GetAllProjects();
        }

        /// <summary>
        /// This gets 4 Random projects from the DB. It is mostly used on the front page
        /// </summary>
        /// <returns>
        /// A List of 4 Projects 
        /// </returns>
        public List<Project> Get4RandomProject()
        {
            return this.dbProject.Get4RandomProjects();
        }

        /// <summary>
        /// Just like GetAllProjects:"It gets all the projects that are in the DB"
        /// Exepts it returns it for an specific account
        /// </summary>
        /// <param name="accountID">
        /// An Account ID
        /// </param>
        /// <returns>
        /// A List of the Account the Projects.
        /// </returns>
        public List<Project> GetallFromAccountProjects(int accountID)
        {
            return this.dbProject.GetAllProjectsFromAccount(accountID);
        }

        /// <summary>
        /// Gets a single project for the DB
        /// </summary>
        /// <param name="projectID">
        /// The project id.
        /// </param>
        /// <returns>
        /// Returns the Project object for a Project
        /// </returns>
        public Project GetProject(int projectID)
        {
            return this.dbProject.GetProject(projectID);
        }

        /// <summary>
        /// Gets categories for the Projects.
        /// </summary>
        /// <returns>
        /// A List of all the Categories in the DB
        /// 
        /// </returns>
        public List<Category> GetCategories()
        {
            return this.dbProject.GetCategories();
        }

        // Not needed
        /// <summary>
        /// Gets Sub Categories for the Projects.
        /// </summary>
        /// <returns>
        /// The <see cref="List"/>.
        /// A List of all the Sub Categories in the DB
        /// </returns>
        public List<SubCategory> GetSubCategories()
        {
            return this.dbProject.GetSubCategories();
        }

        /// <summary>
        /// Backs a project with a specik amount. 
        /// </summary>
        /// <param name="projectId">
        /// A Project ID
        /// </param>
        /// <param name="accountId">
        /// The Backers account ID
        /// </param>
        /// <param name="backamount">
        /// The pledge amount that is in Roundend amount. It is not posible to back 0.2 euro for example.
        /// </param>
        /// <returns>
        /// If the back is succesfull it will return True, Else it will return False
        /// </returns>
        public bool BackProject(string projectId, int accountId, int backamount)
        {
            return this.dbProject.BackProject(projectId, accountId, backamount);
        }

        /// <summary>
        /// Gets all backings from a account. 
        /// </summary>
        /// <param name="accountID">
        /// An AccountID from the requesting account
        /// </param>
        /// <returns>
        /// A list of all the backings from that account 
        /// </returns>
        public List<Backing> GetMyBackings(int accountID)
        {
            return this.dbProject.MyBackings(accountID);
        }

        /// <summary>
        /// Gets a single reward based on that ID
        /// </summary>
        /// <param name="rewardID">
        /// The Reward Id from that specifc reward
        /// </param>
        /// <returns>
        /// A single Reward Object where all the details are stored
        /// </returns>
        public Rewards GetReward(int rewardID)
        {
            return this.dbReward.GetReward(rewardID);
        }

        /// <summary>
        /// Gets all the Rewards for the given Project
        /// </summary>
        /// <param name="projectID">
        /// The Project ID where you want the Rewards from
        /// </param>
        /// <returns>
        /// A List of all the Rewards from the given Project 
        /// </returns>
        public List<Rewards> GetAllRewards(int projectID)
        {
            return this.dbReward.GetAllRewardsPerProject(projectID);
        }

        /// <summary>
        /// Insert a New Reward for the given Project
        /// </summary>
        /// <param name="reward">
        /// A Reward object where all the details are stored from a reward
        /// </param>
        /// <param name="projectID">
        /// The project ID where you want to insert the reward to
        /// </param>
        /// <returns>
        /// If the Insert is succesfull it returns True, Else it returns False
        /// </returns>
        public bool InsertReward(Rewards reward, int projectID)
        {
            return this.dbReward.Insert(reward, projectID);
        }
    }
}