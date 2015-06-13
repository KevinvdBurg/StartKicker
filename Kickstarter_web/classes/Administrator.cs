using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace Kickstarter_web
{
    using System.Collections.Generic;
    using System.Drawing;

    public class Administrator
    {
        private DBLogin dblogin = new DBLogin();
        private DBAccount dbAccount = new DBAccount();
        private DBProject dbProject = new DBProject();

        public Account Login(string email, string password)
        {
            Account getAccount = this.dblogin.Login(email, password);
            return getAccount;
        }

        public Account getAccountDetails(int account_id, string rights)
        {
            Account getAccountDetails = this.dblogin.GetAccount(account_id, rights);
            return getAccountDetails;
        }

        public bool RegisteerAccount(Account account, string password)
        {
            return this.dbAccount.Insert(account, password);
        }

        public bool CreeerProject(Project project, int accountID)
        {
            return this.dbProject.Insert(project, accountID);
        }

        public List<Project> GetallProject()
        {

            return this.dbProject.GetAllProjects();
        }

        public List<Project> GetallFromAccountProjects(int accountID)
        {

            return this.dbProject.GetAllProjectsFromAccount(accountID);
        }

        public Project GetProjects(int projectID)
        {

            return this.dbProject.GetProject(projectID);
        }

        public List<Category> GetCategories()
        {
            return this.dbProject.GetCategories();
        }

        
        //Not needed  -- is should have
        public List<SubCategory> GetSubCategories()
        {
            return this.dbProject.GetSubCategories();
        }


    }    
}
