using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver;

        [TestInitialize]
        public void TestIntialize()
        {            
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.google.co.in/";
            //FuzzBuzzLogic();
            System.Threading.Thread.Sleep(2000);

        }

        [TestMethod]
        public void TestMethod1()
        {            

            //click on Gmail link
            driver.FindElement(By.XPath("//a[text()='Gmail']")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//a[text()='Sign in']")).Click();
            System.Threading.Thread.Sleep(2000);
            IWebElement nameInput = driver.FindElement(By.XPath("//input[@name='identifier']"));
            if (nameInput.Displayed)
            {
                nameInput.SendKeys("test@gmail.com");
            }

            //click on next button
            driver.FindElement(By.XPath("//span[text()='Next']/..")).Click();
            System.Threading.Thread.Sleep(2000);
        }
        [TestCleanup]        
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
