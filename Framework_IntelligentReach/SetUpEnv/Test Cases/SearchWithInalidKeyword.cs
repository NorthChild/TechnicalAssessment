using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V107.CacheStorage;

namespace SetUpEnv.Test_Cases
{
    internal class SearchWithInvalidKeyword
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
            public void SearchWithInvalidKeyword()
            {
                driver.Navigate().GoToUrl(Config.baseURL);

                // Wait for the cookies alert box to appear
                Thread.Sleep(2000);

                // Click on the "Reject All" button
                IWebElement rejectButton = driver.FindElement(By.XPath("//*[@id=\"W0wltc\"]/div"));
                rejectButton.Click();

                // Send Invalid input 
                driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[1]/div/div[2]/input")).SendKeys(Config.invalidInput);
                driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[4]/center/input[1]")).Click();

                // Take header text to compare 
                IWebElement googleResultHeader = driver.FindElement(By.XPath("//*[@id=\"topstuff\"]/div/div/p[1]"));
                string resultHeaderText = googleResultHeader.Text;
                bool elementFound = false;

                // check if element is found
                if (resultHeaderText.Contains(Config.invalidInputMessage))
                {
                    elementFound = true;
                    Action.GreenMessage("Found");
                }

                Assert.IsTrue(elementFound);

            }


            [TearDown]
            public void Teardown()
            {
                driver.Quit();
            }
        }

    }
}
