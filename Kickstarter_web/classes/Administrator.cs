// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Administrator.cs" company="">
//   
// </copyright>
// <summary>
//   The administrator.
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
        /// The login.
        /// </summary>
        /// <param name="email">
        /// The email.
        /// </param>
        /// <param name="password">
        /// The password.
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
        /// The get account details.
        /// </summary>
        /// <param name="account_id">
        /// The account_id.
        /// </param>
        /// <param name="rights">
        /// The rights.
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
        /// The registeer account.
        /// </summary>
        /// <param name="account">
        /// The account.
        /// </param>
        /// <param name="password">
        /// The password.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool RegisteerAccount(Account account, string password)
        {
            return this.dbAccount.Insert(account, password);
        }

        /// <summary>
        /// The creeer project.
        /// </summary>
        /// <param name="project">
        /// The project.
        /// </param>
        /// <param name="accountID">
        /// The account id.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool CreeerProject(Project project, int accountID)
        {
            return this.dbProject.Insert(project, accountID);
        }

        /// <summary>
        /// The getall project.
        /// </summary>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        public List<Project> GetallProject()
        {

            return this.dbProject.GetAllProjects();
        }

        /// <summary>
        /// The get 4 random project.
        /// </summary>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        public List<Project> Get4RandomProject()
        {

            return this.dbProject.Get4RandomProjects();
        }

        /// <summary>
        /// The getall from account projects.
        /// </summary>
        /// <param name="accountID">
        /// The account id.
        /// </param>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        public List<Project> GetallFromAccountProjects(int accountID)
        {

            return this.dbProject.GetAllProjectsFromAccount(accountID);
        }

        /// <summary>
        /// The get project.
        /// </summary>
        /// <param name="projectID">
        /// The project id.
        /// </param>
        /// <returns>
        /// The <see cref="Project"/>.
        /// </returns>
        public Project GetProject(int projectID)
        {

            return this.dbProject.GetProject(projectID);
        }

        /// <summary>
        /// The get categories.
        /// </summary>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        public List<Category> GetCategories()
        {
            return this.dbProject.GetCategories();
        }

        // Not needed  -- is should have
        /// <summary>
        /// The get sub categories.
        /// </summary>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        public List<SubCategory> GetSubCategories()
        {
            return this.dbProject.GetSubCategories();
        }

        /// <summary>
        /// The back project.
        /// </summary>
        /// <param name="projectId">
        /// The project id.
        /// </param>
        /// <param name="accountId">
        /// The account id.
        /// </param>
        /// <param name="backamount">
        /// The backamount.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool BackProject(string projectId, int accountId, int backamount)
        {
            return this.dbProject.BackProject(projectId, accountId, backamount);
        }

        /// <summary>
        /// The get my backings.
        /// </summary>
        /// <param name="accountID">
        /// The account id.
        /// </param>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        public List<Backing> GetMyBackings(int accountID)
        {
            return this.dbProject.MyBackings(accountID);
        }

        /// <summary>
        /// The get reward.
        /// </summary>
        /// <param name="rewardID">
        /// The reward id.
        /// </param>
        /// <returns>
        /// The <see cref="Rewards"/>.
        /// </returns>
        public Rewards GetReward(int rewardID)
        {
            return this.dbReward.GetReward(rewardID);
        }

        /// <summary>
        /// The get all rewards.
        /// </summary>
        /// <param name="projectID">
        /// The project id.
        /// </param>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        public List<Rewards> GetAllRewards(int projectID)
        {
            return this.dbReward.GetAllRewardsPerProject(projectID);
        }

        /// <summary>
        /// The insert reward.
        /// </summary>
        /// <param name="reward">
        /// The reward.
        /// </param>
        /// <param name="projectID">
        /// The project id.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool InsertReward(Rewards reward, int projectID)
        {
            return this.dbReward.Insert(reward, projectID);
        }

    }    
}
