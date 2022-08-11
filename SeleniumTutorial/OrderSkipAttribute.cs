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
using SeleniumTutorial.BaseClass;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;

namespace SeleniumTutorial
{
    [TestFixture]
    public class OrderSkipAttribute
    {
        [Test, Order(0), Category("OrderSkipAttribute")]
        public void TestMethod1()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.facebook.com.br";
            IWebElement email = driver.FindElement(By.XPath(".//*[@id = 'email']"));
            email.SendKeys("USER");
            driver.Close();

        }

    }
}
