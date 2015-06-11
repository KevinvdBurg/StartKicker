using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using Oracle.DataAccess.Client;

namespace Kickstarter_web
{
    

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
    }
}
