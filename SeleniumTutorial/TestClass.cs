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
using OpenQA.Selenium.Support.UI;

namespace SeleniumTutorial
{
    [TestFixture]
    class TestClass : BaseTest
    {
        [Test, Category("Smoke Testing")]
        public void TestMethod1()
        {
            
            IWebElement email = driver.FindElement(By.XPath(".//*[@id = 'email']"));
            email.SendKeys("USER.");
            IWebElement pass = driver.FindElement(By.XPath(".//*[@id = 'pass']"));
            pass.SendKeys("Pass");

        }

        [Test, Category("Regression Testing")]
        public void TestMethod2()
        {

            IWebElement email = driver.FindElement(By.XPath(".//*[@id = 'email']"));
            email.SendKeys("user");
            IWebElement pass = driver.FindElement(By.XPath(".//*[@id = 'pass']"));
            pass.SendKeys("Pass");
            //IWebElement dropdown = driver.FindElement(By.XPath("")); If there is any dropdown, we can find it trying to use the ID of the element
            //SelectElement choosedElement = new SelectElement(dropdown);
            //element.SelectByIndex(1); selecting by index to better identify the element depeding on the web resource.
            //element.SelectByText("Mar"); Example if there is a month to take reference.
            //element.SelectByValue("6"); Example when we are reffering to numbers presented on the dropdown
        }

        [Test, Category("Smoke Testing")] //We can insert categories within the test tags
        public void TestMethod3()
        {

            IWebElement email = driver.FindElement(By.XPath(".//*[@id = 'email']"));
            email.SendKeys("user");
            IWebElement pass = driver.FindElement(By.XPath(".//*[@id = 'pass']"));
            pass.SendKeys("Pass");

        }
    }
}
