using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace Kickstarter_web
{
    using System.CodeDom;

    public class Project
    {
        public string Title { get; set; }

        public string ShortBlurb { get; set; }

        public string ProjectLocation { get; set; }

        public string FundingDuration { get; set; }

        public int FundingGoal { get; set; }

        public string ProjectVideo { get; set; }

        public string ProjectDescription { get; set; }

        public string RisksAndChallenges { get; set; }
        public Category Category { get; set; }
        public string SubCategory { get; set; }
        public int ProjectID { get; set; }

        public Project(string title, string shortBlurb, string projectLocation, string fundingDuration, int fundingGoal, string projectVideo, string projectDescription, string risksAndChallenges, Category category, string subCategory, int projectID)
        {
            Title = title;
            ShortBlurb = shortBlurb;
            ProjectLocation = projectLocation;
            FundingDuration = fundingDuration;
            FundingGoal = fundingGoal;
            ProjectVideo = projectVideo;
            ProjectDescription = projectDescription;
            RisksAndChallenges = risksAndChallenges;
            Category = category;
            SubCategory = subCategory;
            ProjectID = projectID;
        }

        public Project()
        {
            
        }
    }
}


