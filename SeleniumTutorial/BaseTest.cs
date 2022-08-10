using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTutorial.BaseClass
{
    

    
    public class BaseTest
    {
        public IWebDriver driver;

        [SetUp] //OneTimeSetup and SetUp, the difference is that the first one runs only one time and the second runs every time before the tests
        public void Open()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com/";
        }
        [TearDown] //Same idea for OneTimeTear and TearDown when considering start and end point of the test
        public void Close()
        {
            driver.Quit();
        }

    }
}
