using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SetUpEnv.Test_Cases
{
    internal class SearchWithValidKeyword
    {
        [TestFixture]
        public class GoogleSearchTests
        {
            private IWebDriver driver;

            [SetUp]
            public void Setup()
            {
                driver = new ChromeDriver();
            }

            [Test]
            public void SearchWithValidKeyword()
            {
                driver.Navigate().GoToUrl(Config.baseURL);

                // Wait for the cookies alert box to appear
                Thread.Sleep(2000);
                
                // Reject Cookies
                IWebElement rejectButton = driver.FindElement(By.XPath("//*[@id=\"W0wltc\"]/div"));
                rejectButton.Click();
                
                // Send Valid Input and check for title containing expected result
                driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[1]/div/div[2]/input")).SendKeys(Config.validInput);
                driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[4]/center/input[1]")).Click();
                Assert.IsTrue(driver.Title.Contains(Config.validInput));
            }


            [TearDown]
            public void Teardown()
            {
                driver.Quit();
            }
        }

    }
}
