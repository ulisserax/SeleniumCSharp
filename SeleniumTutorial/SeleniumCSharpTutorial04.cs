using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTutorial
{
    [TestFixture]
    public class SeleniumCSharpTutorial04
    {
        [Test]
        [Author("Ulisses", "ulissesbgd@gmail.com")] //Author attribute
        [Description("Facebook Login verify")]
        [TestCaseSource("DataDrivenTest")] //calling the method to take the list of urls
        public void Test1(String urlName)
        {
            IWebDriver driver = null;
            try
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                //driver.Url = "https://www.facebook.com/";
                driver.Url = urlName;
                IWebElement email = driver.FindElement(By.XPath(".//*[@id = 'email']"));
                //IWebElement email = driver.FindElement(By.XPath(".//*[@id = 'abcd']"));
                email.SendKeys("USER");
                driver.Quit();
            }
            catch (Exception e)
            {
                ITakesScreenshot ts = driver as ITakesScreenshot;
                Screenshot screenshot = ts.GetScreenshot();
                screenshot.SaveAsFile("C:\\Users\\uliss\\C# Files\\SeleniumTest\\SeleniumTutorial\\Screenshots\\screenshotName1.jpeg", ScreenshotImageFormat.Jpeg);
                Console.WriteLine(e.StackTrace); //Will print info on the screen if anything runs with any issue on the try block
                throw;
            }
            finally //Will run after running try block or the catch block
            {
                if(driver!= null)
                {
                    driver.Quit();
                }
            }
            
        }

        static IList DataDrivenTest()
        {
            ArrayList list = new ArrayList();
            list.Add("https://www.facebook.com/");
            //list.Add("https://www.youtube.com/");
            //list.Add("https://www.gmail.com/");
            return list;
        }

    }
}
