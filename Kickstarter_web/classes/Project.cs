// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Project.cs" company="">
//   
// </copyright>
// <summary>
//   The project.
// </summary>
// --------------------------------------------------------------------------------------------------------------------



using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace Kickstarter_web
{
    using System.CodeDom;

    /// <summary>
    /// The project.
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the short blurb.
        /// </summary>
        public string ShortBlurb { get; set; }

        /// <summary>
        /// Gets or sets the project location.
        /// </summary>
        public string ProjectLocation { get; set; }

        /// <summary>
        /// Gets or sets the funding duration.
        /// </summary>
        public string FundingDuration { get; set; }

        /// <summary>
        /// Gets or sets the funding goal.
        /// </summary>
        public int FundingGoal { get; set; }

        /// <summary>
        /// Gets or sets the project video.
        /// </summary>
        public string ProjectVideo { get; set; }

        /// <summary>
        /// Gets or sets the project description.
        /// </summary>
        public string ProjectDescription { get; set; }

        /// <summary>
        /// Gets or sets the risks and challenges.
        /// </summary>
        public string RisksAndChallenges { get; set; }

        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Gets or sets the sub category.
        /// </summary>
        public string SubCategory { get; set; }

        /// <summary>
        /// Gets or sets the project id.
        /// </summary>
        public int ProjectID { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Project"/> class.
        /// </summary>
        /// <param name="title">
        /// The title.
        /// </param>
        /// <param name="shortBlurb">
        /// The short blurb.
        /// </param>
        /// <param name="projectLocation">
        /// The project location.
        /// </param>
        /// <param name="fundingDuration">
        /// The funding duration.
        /// </param>
        /// <param name="fundingGoal">
        /// The funding goal.
        /// </param>
        /// <param name="projectVideo">
        /// The project video.
        /// </param>
        /// <param name="projectDescription">
        /// The project description.
        /// </param>
        /// <param name="risksAndChallenges">
        /// The risks and challenges.
        /// </param>
        /// <param name="category">
        /// The category.
        /// </param>
        /// <param name="subCategory">
        /// The sub category.
        /// </param>
        /// <param name="projectID">
        /// The project id.
        /// </param>
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

        /// <summary>
        /// Initializes a new instance of the <see cref="Project"/> class.
        /// </summary>
        public Project()
        {
            
        }
    }
}


