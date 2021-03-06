﻿using Models;
using System;
using System.Text.RegularExpressions;

namespace Application
{
    public static class PRParser
    {
        private static readonly Regex ParsingExpression = new Regex(
            @"https?:\/\/(?<Host>.*?)\/(?<Organisation>.*?)\/(?<Repository>.*?)\/pull\/(?<Number>\d*)",
            RegexOptions.Compiled);

        /// <summary>
        /// Parses the provided url into the components needed to query the PR details.
        /// </summary>
        /// <param name="fullPrUrl">The full url to the PR, e.g: "https://github.com/{organisation}/{repository}/pull/{prId}"</param>
        /// <returns>A DTO containing the details required to query the PR.</returns>
        public static OperationResult<PrDetails, string> Parse(string fullPrUrl)
        {
            var match = ParsingExpression.Match(fullPrUrl.ToLower());

            if (match.Success)
            {
                return OperationResult<PrDetails, string>.Success(new PrDetails
                {
                    GithubHostName = match.Groups["Host"].Value,
                    OrganisationName = match.Groups["Organisation"].Value,
                    RepositoryName = match.Groups["Repository"].Value,
                    PrNumber = int.Parse(match.Groups["Number"].Value)
                });
            }

            return OperationResult<PrDetails, string>.Failed("Could not parse the PR Url");
        }
    }
}
