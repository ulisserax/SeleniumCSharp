// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using NUnit.Framework;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTutorial.BaseClass;
using SeleniumTutorial.Utilities;

namespace SeleniumTutorial
{
    [TestFixture]
    public class ParallelTesting
    {
        IWebDriver driver;

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod1()
        {
            var Driver = new BrowserUtility().Init(driver); //Not just about the type that is returning on the method (var)
            IWebElement email = driver.FindElement(By.XPath(".//*[@id = 'email']"));
            email.SendKeys("user");
            Driver.Close();
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod2()
        {
            var Driver = new BrowserUtility().Init(driver); //Not just about the type that is returning on the method (var)
            IWebElement email = driver.FindElement(By.XPath(".//*[@id = 'email']"));
            email.SendKeys("user");
            Driver.Close();
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod3()
        {
            var Driver = new BrowserUtility().Init(driver); //Not just about the type that is returning on the method (var)
            IWebElement email = driver.FindElement(By.XPath(".//*[@id = 'email']"));
            email.SendKeys("username");
            Driver.Close();
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod4()
        {
            var Driver = new BrowserUtility().Init(driver); //Not just about the type that is returning on the method (var)
            IWebElement email = driver.FindElement(By.XPath(".//*[@id = 'email']"));
            email.SendKeys("user");
            Driver.Close();
        }
    }
}
