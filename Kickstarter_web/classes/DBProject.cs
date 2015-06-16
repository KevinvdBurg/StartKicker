// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DBProject.cs" company="StartKicker">
//   
// </copyright>
// <summary>
//   All the Methods needed to get all the projects details
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

using Oracle.DataAccess.Client;

namespace Kickstarter_web
{
    using System.Collections.Generic;

    /// <summary>
    /// All the methods needed for the dbProject
    /// </summary>
    public class DBProject : Database
    {
        /// <summary>
        /// Insert a new project into the database
        /// </summary>
        /// <param name="project">
        /// A Project object that contains all the details for the project
        /// </param>
        /// <param name="accountID">
        /// The account id form the creator of the project
        /// </param>
        /// <returns>
        /// If its is succesfull is will return True, Else False
        /// </returns>
        public bool Insert(Project project, int accountID)
        {
            bool resultaat = false;

            string sql =
                "INSERT INTO KICKSTARTER_PROJECT(ACCOUNT_ID, TITLE,SHORTBLURB,CATEGORY_ID,SUBCATEGORY_ID,PROJECT_LOCATION, FUNDING_DURATION, FUNDING_GOAL, PROJECTVIDEO, PROJECTDESCRIPTION, RISKSANDCHALLENGES) VALUES(:ACCOUNT_ID, :TITLE,:SHORTBLURB,:CATEGORY_ID,:SUBCATEGORY_ID,:PROJECT_LOCATION, :FUNDING_DURATION, :FUNDING_GOAL, :PROJECTVIDEO, :PROJECTDESCRIPTION, :RISKSANDCHALLENGES)";
            try
            {
                this.Connect();
                OracleCommand cmd = new OracleCommand(sql, this.connection);
                cmd.Parameters.Add(new OracleParameter("ACCOUNT_ID", accountID));
                cmd.Parameters.Add(new OracleParameter("TITLE", project.Title));
                cmd.Parameters.Add(new OracleParameter("SHORTBLURB", project.ShortBlurb));
                cmd.Parameters.Add(new OracleParameter("CATEGORY_ID", project.Category.ID));
                cmd.Parameters.Add(new OracleParameter("SUBCATEGORY_ID", project.SubCategory));
                cmd.Parameters.Add(new OracleParameter("PROJECT_LOCATION", project.ProjectLocation));
                cmd.Parameters.Add(new OracleParameter("FUNDING_DURATION", project.FundingDuration));
                cmd.Parameters.Add(new OracleParameter("FUNDING_GOAL", project.FundingGoal));
                cmd.Parameters.Add(new OracleParameter("PROJECTVIDEO", project.ProjectVideo));
                cmd.Parameters.Add(new OracleParameter("PROJECTDESCRIPTION", project.ProjectDescription));
                cmd.Parameters.Add(new OracleParameter("RISKSANDCHALLENGES", project.RisksAndChallenges));
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
        /// The get all projects from the Database
        /// </summary>
        /// <returns>
        /// A list of all the projects in the database
        /// </returns>
        public List<Project> GetAllProjects()
        {
            string sql =
                "SELECT p.TITLE, p.SHORTBLURB, p.CATEGORY_ID, c.KICKNAME, p.SUBCATEGORY_ID, p.PROJECT_LOCATION, p.FUNDING_DURATION, p.FUNDING_GOAL, p.PROJECTVIDEO, p.PROJECTDESCRIPTION, p.RISKSANDCHALLENGES, p.PROJECT_ID FROM KICKSTARTER_PROJECT p INNER JOIN KICKSTARTER_CATEGORY c ON c.CATEGORY_ID = p.CATEGORY_ID";
            List<Project> listProjects = new List<Project>();

            try
            {
                this.Connect();
                OracleCommand cmd = new OracleCommand(sql, this.connection);
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Category cat = new Category(
                            Convert.ToInt32(reader["CATEGORY_ID"]), 
                            Convert.ToString(reader["KICKNAME"]));
                        Project tempProject = new Project(
                            Convert.ToString(reader["TITLE"]), 
                            Convert.ToString(reader["SHORTBLURB"]), 
                            Convert.ToString(reader["PROJECT_LOCATION"]), 
                            Convert.ToString(reader["FUNDING_DURATION"]), 
                            Convert.ToInt32(reader["FUNDING_GOAL"]), 
                            Convert.ToString(reader["PROJECTVIDEO"]), 
                            Convert.ToString(reader["PROJECTDESCRIPTION"]), 
                            Convert.ToString(reader["RISKSANDCHALLENGES"]), 
                            cat, 
                            Convert.ToString(reader["SUBCATEGORY_ID"]), 
                            Convert.ToInt32(reader["PROJECT_ID"]));
                        listProjects.Add(tempProject);
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

            return listProjects;
        }

        /// <summary>
        /// The get 4 random projects from the database.
        /// </summary>
        /// <returns>
        /// A list of 4 random projects from the database
        /// </returns>
        public List<Project> Get4RandomProjects()
        {
            string sql =
                "SELECT p.TITLE, p.SHORTBLURB, p.CATEGORY_ID, c.KICKNAME, p.SUBCATEGORY_ID, p.PROJECT_LOCATION, p.FUNDING_DURATION, p.FUNDING_GOAL, p.PROJECTVIDEO, p.PROJECTDESCRIPTION, p.RISKSANDCHALLENGES, p.PROJECT_ID FROM KICKSTARTER_PROJECT p INNER JOIN KICKSTARTER_CATEGORY c ON c.CATEGORY_ID = p.CATEGORY_ID ORDER BY dbms_random.value";
            List<Project> listProjects = new List<Project>();
            int count = 0;
            try
            {
                this.Connect();
                OracleCommand cmd = new OracleCommand(sql, this.connection);
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read() && count < 4)
                    {
                        Category cat = new Category(
                            Convert.ToInt32(reader["CATEGORY_ID"]), 
                            Convert.ToString(reader["KICKNAME"]));
                        Project tempProject = new Project(
                            Convert.ToString(reader["TITLE"]), 
                            Convert.ToString(reader["SHORTBLURB"]), 
                            Convert.ToString(reader["PROJECT_LOCATION"]), 
                            Convert.ToString(reader["FUNDING_DURATION"]), 
                            Convert.ToInt32(reader["FUNDING_GOAL"]), 
                            Convert.ToString(reader["PROJECTVIDEO"]), 
                            Convert.ToString(reader["PROJECTDESCRIPTION"]), 
                            Convert.ToString(reader["RISKSANDCHALLENGES"]), 
                            cat, 
                            Convert.ToString(reader["SUBCATEGORY_ID"]), 
                            Convert.ToInt32(reader["PROJECT_ID"]));
                        listProjects.Add(tempProject);
                        count++;
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

            return listProjects;
        }

        /// <summary>
        /// The get all projects from account.
        /// </summary>
        /// <param name="accountID">
        /// The accountID from the whitch all the project needs to bee
        /// </param>
        /// <returns>
        /// A List of all the projects from an account
        /// </returns>
        public List<Project> GetAllProjectsFromAccount(int accountID)
        {
            // string sql = "SELECT TITLE,SHORTBLURB, CATEGORY_ID, SUBCATEGORY_ID, PROJECT_LOCATION, FUNDING_DURATION, FUNDING_GOAL, PROJECTVIDEO, PROJECTDESCRIPTION, RISKSANDCHALLENGES, PROJECT_ID FROM KICKSTARTER_PROJECT WHERE ACCOUNT_ID = :accountID";
            string sql =
                "SELECT p.TITLE, p.SHORTBLURB, p.CATEGORY_ID, c.KICKNAME, p.SUBCATEGORY_ID, p.PROJECT_LOCATION, p.FUNDING_DURATION, p.FUNDING_GOAL, p.PROJECTVIDEO, p.PROJECTDESCRIPTION, p.RISKSANDCHALLENGES, p.PROJECT_ID FROM KICKSTARTER_PROJECT p INNER JOIN KICKSTARTER_CATEGORY c ON c.CATEGORY_ID = p.CATEGORY_ID WHERE p.ACCOUNT_ID = :accountID";
            List<Project> listProjects = new List<Project>();

            try
            {
                this.Connect();
                OracleCommand cmd = new OracleCommand(sql, this.connection);
                cmd.Parameters.Add(new OracleParameter("accountID", accountID));
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Category cat = new Category(
                            Convert.ToInt32(reader["CATEGORY_ID"]), 
                            Convert.ToString(reader["KICKNAME"]));
                        Project tempProject = new Project(
                            Convert.ToString(reader["TITLE"]), 
                            Convert.ToString(reader["SHORTBLURB"]), 
                            Convert.ToString(reader["PROJECT_LOCATION"]), 
                            Convert.ToString(reader["FUNDING_DURATION"]), 
                            Convert.ToInt32(reader["FUNDING_GOAL"]), 
                            Convert.ToString(reader["PROJECTVIDEO"]), 
                            Convert.ToString(reader["PROJECTDESCRIPTION"]), 
                            Convert.ToString(reader["RISKSANDCHALLENGES"]), 
                            cat, 
                            Convert.ToString(reader["SUBCATEGORY_ID"]), 
                            Convert.ToInt32(reader["PROJECT_ID"]));
                        listProjects.Add(tempProject);
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

            return listProjects;
        }

        /// <summary>
        /// Gets a Single project from the database
        /// </summary>
        /// <param name="projectID">
        /// The project id of that project.
        /// </param>
        /// <returns>
        /// A Project Object with all the infromation
        /// </returns>
        public Project GetProject(int projectID)
        {
            string sql =
                "SELECT p.TITLE, p.SHORTBLURB, p.CATEGORY_ID, c.KICKNAME, p.SUBCATEGORY_ID, p.PROJECT_LOCATION, p.FUNDING_DURATION, p.FUNDING_GOAL, p.PROJECTVIDEO, p.PROJECTDESCRIPTION, p.RISKSANDCHALLENGES, p.PROJECT_ID FROM KICKSTARTER_PROJECT p INNER JOIN KICKSTARTER_CATEGORY c ON c.CATEGORY_ID = p.CATEGORY_ID WHERE p.PROJECT_ID = :projectID";

            Project thisProjects = new Project();
            try
            {
                this.Connect();
                OracleCommand cmd = new OracleCommand(sql, this.connection);
                cmd.Parameters.Add(new OracleParameter("projectID", projectID));
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    Category cat = new Category(
                        Convert.ToInt32(reader["CATEGORY_ID"]), 
                        Convert.ToString(reader["KICKNAME"]));
                    Project tempProject = new Project(
                        Convert.ToString(reader["TITLE"]), 
                        Convert.ToString(reader["SHORTBLURB"]), 
                        Convert.ToString(reader["PROJECT_LOCATION"]), 
                        Convert.ToString(reader["FUNDING_DURATION"]), 
                        Convert.ToInt32(reader["FUNDING_GOAL"]), 
                        Convert.ToString(reader["PROJECTVIDEO"]), 
                        Convert.ToString(reader["PROJECTDESCRIPTION"]), 
                        Convert.ToString(reader["RISKSANDCHALLENGES"]), 
                        cat, 
                        Convert.ToString(reader["SUBCATEGORY_ID"]), 
                        Convert.ToInt32(reader["PROJECT_ID"]));
                    thisProjects = tempProject;
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

            return thisProjects;
        }

        /// <summary>
        /// Gets all the categories 
        /// </summary>
        /// <returns>
        /// A List of all the Categories
        /// </returns>
        public List<Category> GetCategories()
        {
            string sql = "SELECT CATEGORY_ID, KICKNAME FROM KICKSTARTER_CATEGORY";

            List<Category> listCategory = new List<Category>();
            try
            {
                this.Connect();
                OracleCommand cmd = new OracleCommand(sql, this.connection);
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Category newCategory = new Category(
                            Convert.ToInt32(reader["CATEGORY_ID"]), 
                            Convert.ToString(reader["KICKNAME"]));
                        listCategory.Add(newCategory);
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

            return listCategory;
        }

        /// <summary>
        ///  Gets all the sub categories 
        /// </summary>
        /// <returns>
        ///A List of all the SUB Categories
        /// </returns>
        public List<SubCategory> GetSubCategories()
        {
            string sql =
                "SELECT s.SUBCATEGORY_ID as SUBID, s.KICKNAME as SUBNAME, c.CATEGORY_ID as CATID, c.KICKNAME AS CATNAME FROM KICKSTARTER_SUBCATEGORY s INNER JOIN KICKSTARTER_CATEGORY c ON s.CATEGORY_ID = c.CATEGORY_ID; ";

            List<SubCategory> listSubCategories = new List<SubCategory>();
            try
            {
                this.Connect();
                OracleCommand cmd = new OracleCommand(sql, this.connection);
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Category newCategory = new Category(
                            Convert.ToInt32(reader["CATID"]), 
                            Convert.ToString(reader["CATNAME"]));
                        SubCategory newSubCategory = new SubCategory(
                            Convert.ToInt32(reader["SUBID"]), 
                            Convert.ToString(reader["SUBNAME"]), 
                            newCategory);
                        listSubCategories.Add(newSubCategory);
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

            return listSubCategories;
        }

        /// <summary>
        /// This method will back the given project
        /// </summary>
        /// <param name="projectId">
        /// The project ID from the project
        /// </param>
        /// <param name="accountId">
        /// The account id from the one whos backing the account
        /// </param>
        /// <param name="backamount">
        /// The Plegde amount in a 'int'
        /// </param>
        /// <returns>
        /// If its is succesfull is will return True, Else False
        /// </returns>
        public bool BackProject(string projectId, int accountId, int backamount)
        {
            bool resultaat = false;

            string sql =
                "INSERT INTO KICKSTARTER_BACKING(ACCOUNT_ID,PROJECT_ID,PLEDGEAMOUNT) VALUES(:accountId,:projectId,:backamount)";
            try
            {
                this.Connect();
                OracleCommand cmd = new OracleCommand(sql, this.connection);
                cmd.Parameters.Add(new OracleParameter("accountId", accountId));
                cmd.Parameters.Add(new OracleParameter("projectId", projectId));
                cmd.Parameters.Add(new OracleParameter("backamount", backamount));
                cmd.ExecuteNonQuery();
                resultaat = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                this.connection.Close();
            }

            return resultaat;
        }

        /// <summary>
        /// Get all backings from a given account
        /// </summary>
        /// <param name="accountId">
        /// The account id.
        /// </param>
        /// <returns>
        /// A list of all the backings for a account
        /// </returns>
        public List<Backing> MyBackings(int accountId)
        {
            string sql =
                "SELECT PROJECT_ID, PLEDGEAMOUNT, BETAALD FROM KICKSTARTER_BACKING WHERE ACCOUNT_ID = :accountId";
            List<Backing> myBackings = new List<Backing>();
            try
            {
                this.Connect();
                OracleCommand cmd = new OracleCommand(sql, this.connection);
                cmd.Parameters.Add(new OracleParameter("accountId", accountId));
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        bool betaald;
                        int btld = Convert.ToInt32(reader["BETAALD"]);
                        if (btld == 1)
                        {
                            betaald = true;
                        }
                        else
                        {
                            betaald = false;
                        }

                        Backing myBacking = new Backing(
                            Convert.ToInt32(reader["PLEDGEAMOUNT"]), 
                            betaald, 
                            GetProject(Convert.ToInt32(reader["PROJECT_ID"])), 
                            accountId);
                        myBackings.Add(myBacking);
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

            return myBackings;
        }
    }
}