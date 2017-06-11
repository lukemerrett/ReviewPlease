using Models;
using System;

namespace Application
{
    public static class PRParser
    {
        /// <summary>
        /// Parses the provided url into the components needed to query the PR details.
        /// </summary>
        /// <param name="fullPrUrl">The full url to the PR, e.g: "https://github.com/{organisation}/{repository}/pull/{prId}"</param>
        /// <returns>A DTO containing the details required to query the PR.</returns>
        public static PrDetails Parse(string fullPrUrl)
        {
            throw new NotImplementedException();
        }
    }
}
