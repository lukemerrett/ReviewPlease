namespace Models
{
    public class PrDetails
    {
        /// <summary>
        /// Gets or sets the host. Usually github.com, however we want to cater for GitHub enterprise too.
        /// </summary>
        public string GithubHostName { get; set; }
        
        /// <summary>
        /// Gets or sets the name of the organisation the repository lives under.
        /// </summary>
        public string OrganisationName { get; set; }

        /// <summary>
        /// Gets or sets the repository the PR has been raised in.
        /// </summary>
        public string RepositoryName { get; set; }

        /// <summary>
        /// Gets or sets the number of the PR requested.
        /// </summary>
        public int PrNumber { get; set; }
    }
}
