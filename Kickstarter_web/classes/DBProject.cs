using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using Oracle.DataAccess.Client;

namespace Kickstarter_web
{
    using System.Collections.Generic;

    public class DBProject : Database
    {
        public void Delete()
        {
            throw new System.NotImplementedException();
        }

        public bool Insert(Project project, int accountID)
        {
            bool resultaat = false;

            string sql =
                "INSERT INTO KICKSTARTER_PROJECT(ACCOUNT_ID, TITLE,SHORTBLURB,CATEGORY_ID,SUBCATEGORY_ID,PROJECT_LOCATION, FUNDING_DURATION, FUNDING_GOAL, PROJECTVIDEO, PROJECTDESCRIPTION, RISKSANDCHALLENGES) VALUES(:ACCOUNT_ID, :TITLE,:SHORTBLURB,:CATEGORY_ID,:SUBCATEGORY_ID,:PROJECT_LOCATION, :FUNDING_DURATION, :FUNDING_GOAL, :PROJECTVIDEO, :PROJECTDESCRIPTION, :RISKSANDCHALLENGES)";
            try
            {
                this.Connect();
                OracleCommand cmd = new OracleCommand(sql, this.connection);
                cmd.Parameters.Add(new OracleParameter("ACCOUNT_ID",accountID));
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

        public void Update()
        {
            throw new System.NotImplementedException();
        }

        public List<Project> GetAllProjects()
        {
            string sql = "SELECT p.TITLE, p.SHORTBLURB, p.CATEGORY_ID, c.KICKNAME, p.SUBCATEGORY_ID, p.PROJECT_LOCATION, p.FUNDING_DURATION, p.FUNDING_GOAL, p.PROJECTVIDEO, p.PROJECTDESCRIPTION, p.RISKSANDCHALLENGES, p.PROJECT_ID FROM KICKSTARTER_PROJECT p INNER JOIN KICKSTARTER_CATEGORY c ON c.CATEGORY_ID = p.CATEGORY_ID";
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

        public List<Project> GetAllProjectsFromAccount(int accountID)
        {
            //string sql = "SELECT TITLE,SHORTBLURB, CATEGORY_ID, SUBCATEGORY_ID, PROJECT_LOCATION, FUNDING_DURATION, FUNDING_GOAL, PROJECTVIDEO, PROJECTDESCRIPTION, RISKSANDCHALLENGES, PROJECT_ID FROM KICKSTARTER_PROJECT WHERE ACCOUNT_ID = :accountID";
            string sql = "SELECT p.TITLE, p.SHORTBLURB, p.CATEGORY_ID, c.KICKNAME, p.SUBCATEGORY_ID, p.PROJECT_LOCATION, p.FUNDING_DURATION, p.FUNDING_GOAL, p.PROJECTVIDEO, p.PROJECTDESCRIPTION, p.RISKSANDCHALLENGES, p.PROJECT_ID FROM KICKSTARTER_PROJECT p INNER JOIN KICKSTARTER_CATEGORY c ON c.CATEGORY_ID = p.CATEGORY_ID WHERE p.ACCOUNT_ID = :accountID";
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

        public Project GetProject(int projectID)
        {
            string sql = "SELECT p.TITLE, p.SHORTBLURB, p.CATEGORY_ID, c.KICKNAME, p.SUBCATEGORY_ID, p.PROJECT_LOCATION, p.FUNDING_DURATION, p.FUNDING_GOAL, p.PROJECTVIDEO, p.PROJECTDESCRIPTION, p.RISKSANDCHALLENGES, p.PROJECT_ID FROM KICKSTARTER_PROJECT p INNER JOIN KICKSTARTER_CATEGORY c ON c.CATEGORY_ID = p.CATEGORY_ID WHERE p.PROJECT_ID = :projectID";

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
                        Category newCategory = new Category(Convert.ToInt32(reader["CATEGORY_ID"]), Convert.ToString(reader["KICKNAME"]));
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



        public List<SubCategory> GetSubCategories()
        {
            string sql = "SELECT s.SUBCATEGORY_ID as SUBID, s.KICKNAME as SUBNAME, c.CATEGORY_ID as CATID, c.KICKNAME AS CATNAME FROM KICKSTARTER_SUBCATEGORY s INNER JOIN KICKSTARTER_CATEGORY c ON s.CATEGORY_ID = c.CATEGORY_ID; ";

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
                        Category newCategory = new Category(Convert.ToInt32(reader["CATID"]), Convert.ToString(reader["CATNAME"]));
                        SubCategory newSubCategory = new SubCategory(Convert.ToInt32(reader["SUBID"]), Convert.ToString(reader["SUBNAME"]), newCategory);
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

        public string GetCategoryName(int id)
        {
            string sql = "SELECT KICKNAME FROM KICKSTARTER_CATEGORY WHERE CATEGORY_ID = :id";
            string result = "";
            try
            {
                this.Connect();
                OracleCommand cmd = new OracleCommand(sql, this.connection);
                cmd.Parameters.Add(new OracleParameter("id", id));
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    result = Convert.ToString(reader["KICKNAME"]);
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
            return result;
        }

        public bool BackProject(string projectId, int accountId, int backamount)
        {
            bool resultaat = false;

            string sql =
                "INSERT INTO KICKSTARTER_BACKING(ACCOUNT_ID,PROJECT_ID,PLEDGEAMOUNT) VALUES(ACCOUNT_ID = :accountId,PROJECT_ID = :projectId, PLEDGEAMOUNT = :backamount)";
            try
            {
                this.Connect();
                OracleCommand cmd = new OracleCommand(sql, this.connection);
                cmd.Parameters.Add(new OracleParameter("ACCOUNT_ID", accountId));
                cmd.Parameters.Add(new OracleParameter("PROJECT_ID", projectId));
                cmd.Parameters.Add(new OracleParameter("PLEDGEAMOUNT", backamount));
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

        public List<Backing> MyBackings(int accountId)
        {
            string sql = "SELECT PROJECT_ID, PLEDGEAMOUNT, BETAALD FROM KICKSTARTER_BACKING WHERE ACCOUNT_ID = :accountId";
            List<Backing> myBackings = null;
            try
            {
                this.Connect();
                OracleCommand cmd = new OracleCommand(sql, this.connection);
                cmd.Parameters.Add(new OracleParameter("accountId", accountId));
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
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
                    Backing myBacking = new Backing(Convert.ToInt32(reader["PLEDGEAMOUNT"]), betaald, GetProject(Convert.ToInt32(reader["PROJECT_ID"])), accountId);
                    myBackings.Add(myBacking);
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
