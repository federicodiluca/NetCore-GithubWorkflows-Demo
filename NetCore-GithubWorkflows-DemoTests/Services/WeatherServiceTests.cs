using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetCore_GithubWorkflows_Demo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore_GithubWorkflows_Demo.Services.Tests
{
    [TestClass()]
    public class WeatherServiceTests
    {
        [TestMethod()]
        public void GetTest()
        {
            // arrange
            var expected = new string[] { "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" };
            var weatherService = new WeatherService();

            // act
            var res = weatherService.Get();

            // assert
            int match = 0;
            foreach (var r in res)
                match += expected.Any(_ => _.Equals(r.Summary, StringComparison.OrdinalIgnoreCase)) ? 1 : 0;

            Assert.AreEqual(5, match);
        }
    }
}