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
                cmd.Parameters.Add(new OracleParameter("CATEGORY_ID", project.Category));
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
            string sql = "SELECT TITLE,SHORTBLURB, CATEGORY_ID, SUBCATEGORY_ID, PROJECT_LOCATION, FUNDING_DURATION, FUNDING_GOAL, PROJECTVIDEO, PROJECTDESCRIPTION, RISKSANDCHALLENGES, PROJECT_ID FROM KICKSTARTER_PROJECT";
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
                        Project tempProject = new Project(
                            Convert.ToString(reader["TITLE"]), 
                            Convert.ToString(reader["SHORTBLURB"]), 
                            Convert.ToString(reader["PROJECT_LOCATION"]),
                            Convert.ToString(reader["FUNDING_DURATION"]),
                            Convert.ToInt32(reader["FUNDING_GOAL"]),
                            Convert.ToString(reader["PROJECTVIDEO"]),
                            Convert.ToString(reader["PROJECTDESCRIPTION"]),
                            Convert.ToString(reader["RISKSANDCHALLENGES"]),
                            Convert.ToString(reader["CATEGORY_ID"]), 
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
            string sql = "SELECT TITLE,SHORTBLURB, CATEGORY_ID, SUBCATEGORY_ID, PROJECT_LOCATION, FUNDING_DURATION, FUNDING_GOAL, PROJECTVIDEO, PROJECTDESCRIPTION, RISKSANDCHALLENGES, PROJECT_ID FROM KICKSTARTER_PROJECT WHERE ACCOUNT_ID = :accountID";
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
                        Project tempProject = new Project(
                            Convert.ToString(reader["TITLE"]),
                            Convert.ToString(reader["SHORTBLURB"]),
                            Convert.ToString(reader["PROJECT_LOCATION"]),
                            Convert.ToString(reader["FUNDING_DURATION"]),
                            Convert.ToInt32(reader["FUNDING_GOAL"]),
                            Convert.ToString(reader["PROJECTVIDEO"]),
                            Convert.ToString(reader["PROJECTDESCRIPTION"]),
                            Convert.ToString(reader["RISKSANDCHALLENGES"]),
                            Convert.ToString(reader["CATEGORY_ID"]),
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
            string sql = "SELECT TITLE,SHORTBLURB, CATEGORY_ID, SUBCATEGORY_ID, PROJECT_LOCATION, FUNDING_DURATION, FUNDING_GOAL, PROJECTVIDEO, PROJECTDESCRIPTION, RISKSANDCHALLENGES, PROJECT_ID FROM KICKSTARTER_PROJECT WHERE PROJECT_ID = :projectID";
            Project thisProjects = new Project();
            try
            {
                this.Connect();
                OracleCommand cmd = new OracleCommand(sql, this.connection);
                cmd.Parameters.Add(new OracleParameter("projectID", projectID));
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                        Project tempProject = new Project(
                            Convert.ToString(reader["TITLE"]),
                            Convert.ToString(reader["SHORTBLURB"]),
                            Convert.ToString(reader["PROJECT_LOCATION"]),
                            Convert.ToString(reader["FUNDING_DURATION"]),
                            Convert.ToInt32(reader["FUNDING_GOAL"]),
                            Convert.ToString(reader["PROJECTVIDEO"]),
                            Convert.ToString(reader["PROJECTDESCRIPTION"]),
                            Convert.ToString(reader["RISKSANDCHALLENGES"]),
                            Convert.ToString(reader["CATEGORY_ID"]),
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
    }
}
