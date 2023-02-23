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
    internal class ChangeToDarkTheme
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
            public void ChangeToDarkTheme()
            {
                // Navigate to the Google homepage
                driver.Navigate().GoToUrl(Config.baseURL);

                // Wait for the cookies alert box to appear
                Thread.Sleep(500);

                // Click on the "Reject All" button
                IWebElement rejectButton = driver.FindElement(By.XPath("//*[@id=\"W0wltc\"]/div"));
                rejectButton.Click();

                // click on settings 
                IWebElement settingsButton = driver.FindElement(By.XPath("/html/body/div[1]/div[5]/div[2]/div[3]/span/span/g-popup/div[1]/div"));
                settingsButton.Click();
                Thread.Sleep(1000);

                // click on dark theme
                IWebElement darkThemeButton = driver.FindElement(By.CssSelector("#YUIDDb > div > div:nth-child(1)"));
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("arguments[0].click();", darkThemeButton);
                Thread.Sleep(1000);

                // click on settings 
                IWebElement settingsReturn = driver.FindElement(By.XPath("/html/body/div[1]/div[5]/div[2]/div[3]/span/span/g-popup/div[1]/div"));
                settingsReturn.Click();
                Thread.Sleep(1000);

                // check that dark theme is turned on 
                IWebElement darkThemeButtonReturn  = driver.FindElement(By.CssSelector("#YUIDDb > div > div:nth-child(1)"));
                Thread.Sleep(1000);

                string darkThemeText = darkThemeButtonReturn.Text;
                bool darkThemeIsActive = false;

                if (darkThemeText.Contains("On"))
                {
                    darkThemeIsActive = true;
                }

                Thread.Sleep(1000);
                Assert.IsTrue(darkThemeIsActive);
            }


            [TearDown]
            public void Teardown()
            {
                driver.Quit();
            }
        }

    }
}
