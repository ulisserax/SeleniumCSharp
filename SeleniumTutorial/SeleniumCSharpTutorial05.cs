using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTutorial
{
    [TestFixture]
    public class SeleniumCSharpTutorial05
    {
        ExtentReports extent = null;

        [OneTimeSetUp]
        public void ExtentStart()
        {
            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\uliss\C# Files\SeleniumTest\SeleniumTutorial\ExtentReports\SeleniumCSharpTutorial05.html");
            extent.AttachReporter(htmlReporter);
        }

        [OneTimeTearDown]
        public void ExtentClose()
        {
            extent.Flush(); //close connection with extentReports
        }

        [Test]
        public void Test1()
        {
            IWebDriver driver = null;
            ExtentTest test = null;

            try
            {
                test = extent.CreateTest("Test1").Info("Test Started"); //Printing the first message in the log
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                test.Log(Status.Info, "Chrome Browser Launched");
                driver.Url = "https://www.facebook.com/";
                IWebElement email = driver.FindElement(By.XPath(".//*[@id = 'email']"));
                email.SendKeys("USER");
                test.Log(Status.Info, "Email ID entered");
                driver.Quit();
                test.Log(Status.Pass, "Test1 Passed"); //Printing the last message in the log
            }
            catch (Exception e)
            {

                throw;
            }
            finally //Will run after running try block or the catch block
            {
                if (driver != null)
                {
                    driver.Quit();
                }
            }
        }

        [Test]
        public void Test2()
        {
            IWebDriver driver = null;
            ExtentTest test = null;

            try
            {
                test = extent.CreateTest("Test2").Info("Test Started"); 
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                test.Log(Status.Info, "Chrome Browser Launched");
                driver.Url = "https://www.facebook.com/";
                IWebElement email = driver.FindElement(By.XPath(".//*[@id = 'abcd']"));
                email.SendKeys("USER");
                test.Log(Status.Info, "Email ID entered");
                driver.Quit();
                test.Log(Status.Pass, "Test2 Passed"); 
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, e.ToString());
                throw;
            }
            finally //Will run after running try block or the catch block
            {
                if (driver != null)
                {
                    driver.Quit();
                }
            }
        }
    }

}
