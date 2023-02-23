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
    internal class CheckSuggestionBoxIsShown
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
            public void CheckSuggestionBoxIsShown()
            {
                //// Navigate to the Google homepage
                driver.Navigate().GoToUrl(Config.baseURL);

                //// Wait for the cookies alert box to appear
                Thread.Sleep(500);

                //// Click on the "Reject All" button
                IWebElement rejectButton = driver.FindElement(By.XPath("//*[@id=\"W0wltc\"]/div"));
                rejectButton.Click();

                // click on search bar and insert keyword
                driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[1]/div/div[2]/input")).SendKeys(Config.autocompleteKeyword);
                driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[1]/div/div[2]/input")).Click();
                Thread.Sleep(1000);

                // check that the suggestion box is shown
                IWebElement suggestionTab = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[2]/div[2]/div[2]"));
                Thread.Sleep(1000);

                bool suggestionTabIsShown = false;
                Thread.Sleep(1000);

                if (suggestionTab.Displayed)
                {
                    suggestionTabIsShown = true;
                }

                Thread.Sleep(1000);
                Assert.IsTrue(suggestionTabIsShown);
            }

            [TearDown]
            public void Teardown()
            {
                driver.Quit();
            }
        }

    }
}
