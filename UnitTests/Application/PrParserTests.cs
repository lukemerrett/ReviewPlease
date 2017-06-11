using Application;
using NUnit.Framework;
using System;

namespace UnitTests.Application
{
    [TestFixture]
    public class PrParserTests
    {
        [Test]
        public void GivenInvalidUrl_ThrowsException()
        {
            const string Url = "https://bob";

            Assert.Throws<Exception>(() => PRParser.Parse(Url));
        }

        [Test]
        public void GivenValidUrl_SplitsIntoPrDetails()
        {
            const string Url = "https://github.com/my-org/my-repo/pull/342";

            var details = PRParser.Parse(Url);

            Assert.AreEqual("github.com", details.GithubHostName);
            Assert.AreEqual("my-org", details.OrganisationName);
            Assert.AreEqual("my-repo", details.RepositoryName);
            Assert.AreEqual(342, details.PrNumber);
        }
    }
}
