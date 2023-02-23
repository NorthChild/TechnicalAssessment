
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;

internal class NameAccess : Helper
{
    static IWebDriver driver = new ChromeDriver();
    static IWebElement element;
    //static IWebElement comment;
    //static IWebElement dropDownMenu;
    //static IWebElement elementFromTheDropDownMenu;
    //static Action action;

    static void Main()
    {
        Actions action = new Actions(driver);

        //// BY NAME
        //driver.Manage().Window.FullScreen();
        //string url = "http://testing.todorvachev.com/selectors/name";
        //string name = "myName";
        //driver.Navigate().GoToUrl(url);
        //element = driver.FindElement(By.Name(name));

        //// BY NAME
        //driver.Manage().Window.FullScreen();
        string url = "https://www.google.com/";
        string name = "q";
        driver.Navigate().GoToUrl(url);
        element = driver.FindElement(By.Name(name));



        //BY ID
        //driver.Manage().Window.FullScreen();
        //string url = "http://testing.todorvachev.com/selectors/id";
        //string ID = "testImage";
        //driver.Navigate().GoToUrl(url);
        //element = driver.FindElement(By.Id(ID));



        // BY CLASS
        //driver.Manage().Window.FullScreen();
        //string url = "http://testing.todorvachev.com/selectors/class-name";
        //string className = "testClass";
        //driver.Navigate().GoToUrl(url);
        //element = driver.FindElement(By.ClassName(className));



        // BY CSS & XPATH
        //string url = "https://testing.todorvachev.com/css-path/";
        ////string url = "https://testing.todorvachev.com/xpath/";
        //string cssPath = "#post-108 > div > figure > img";
        //string commentField = "comment";
        ////string XPath = "//*[@id=\"post-109\"]/div/figure/img";
        //driver.Navigate().GoToUrl(url);


        // LOOPING THROUGH THE DROPDOWN MENU
        //string url = "http://testing.todorvachev.com/special-elements/drop-down-menu-test/";
        //string dropDownMenuElements = "#post-6 > div > p:nth-child(6) > select > option:nth-child(3)";

        //driver.Navigate().GoToUrl(url);

        //dropDownMenu = driver.FindElement(By.Name("DropDownTest"));

        //Console.WriteLine("The selected value is: " + dropDownMenu.GetAttribute("value"));

        //elementFromTheDropDownMenu = driver.FindElement(By.CssSelector(dropDownMenuElements));

        //Console.WriteLine("The third option from the drop down menu is: " + elementFromTheDropDownMenu.GetAttribute("value"));

        //elementFromTheDropDownMenu.Click();

        //Console.WriteLine("The selected value is: " + dropDownMenu.GetAttribute("value"));
        //Thread.Sleep(3000);

        //Console.ForegroundColor = ConsoleColor.Green;
        //for (int i = 1; i <= 4; i++)
        //{
        //    dropDownMenuElements = "#post-6 > div > p:nth-child(6) > select > option:nth-child(" + i + ")";
        //    elementFromTheDropDownMenu = driver.FindElement(By.CssSelector(dropDownMenuElements));
        //    Console.WriteLine("The " + i + " option from the drop down menu is: " + elementFromTheDropDownMenu.GetAttribute("value"));
        //}
        //Console.ForegroundColor = ConsoleColor.White;

        Thread.Sleep(3000);
        driver.Quit();



        // ------------------------------------------------------- //
        // Checking if element is found

        //if (element.Displayed)
        //{
        //    GreenMessage("Element visible");
        //    Console.WriteLine(element.Text);
        //}
        //else
        //{
        //    RedMessage("Element not visible");
        //}



        // Checking for XPath and CSSPath
        //try
        //{
        //    driver.Manage().Window.FullScreen();
        //    element = driver.FindElement(By.CssSelector(cssPath));
        //    comment = driver.FindElement(By.Name(commentField));
        //    //element = driver.FindElement(By.XPath(XPath));

        //    action.MoveToElement(comment).Perform();

        //    if (element.Displayed)
        //    {
        //        GreenMessage("Element visible");
        //    }

        //}
        //catch (NoSuchElementException)
        //{
        //    RedMessage("Element not visible");
        //}

        //Thread.Sleep(2000);
        //driver.Quit();




    }


}


