using NUnit.Framework;
using SeleniumTutorial.BaseClass;
using SeleniumTutorial.PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumTutorial.TestScripts
{
    [TestFixture]
    class Module1 : BaseTest
    {
        [Test]
        public void TestMethod1()
        {
            var searchPage = new SearchPage(driver);
            var resultPage = searchPage.NavigateToResultPage();
            var channelPage = resultPage.NavigateToChannel();
            String actuallyChannelName = channelPage.getChannelName();
            String expectedChannelName = "ChannelName";

            Assert.IsTrue(actuallyChannelName.Equals(expectedChannelName));
            Thread.Sleep(5000);
        }
    }
}
