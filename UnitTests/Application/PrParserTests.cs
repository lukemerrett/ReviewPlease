using Application;
using NUnit.Framework;
using System;

namespace UnitTests.Application
{
    [TestFixture]
    public class PrParserTests
    {
        [Test]
        public void GivenInvalidUrl_ReturnedFailedOperation()
        {
            const string Url = "https://bob";

            var response = PRParser.Parse(Url);

            Assert.IsFalse(response.IsSuccess);
        }

        [Test]
        public void GivenValidUrl_SplitsIntoPrDetails()
        {
            const string Url = "https://github.com/my-org/my-repo/pull/342";

            var response = PRParser.Parse(Url);

            Assert.IsTrue(response.IsSuccess);
            Assert.AreEqual("github.com", response.Result.GithubHostName);
            Assert.AreEqual("my-org", response.Result.OrganisationName);
            Assert.AreEqual("my-repo", response.Result.RepositoryName);
            Assert.AreEqual(342, response.Result.PrNumber);
        }
    }
}
