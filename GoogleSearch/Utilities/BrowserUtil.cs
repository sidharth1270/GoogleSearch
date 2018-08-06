using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

public class BrowserUtil
{
    public static IWebDriver driver;

    public static void OpenUrl(string url)
    {
        driver.Navigate().GoToUrl(url);
        driver.Manage().Window.Maximize();

    }

    public static IWebDriver LaunchBrowser(string browsername)
    {
        if (browsername == "Chrome")
        {
            driver = new ChromeDriver();
        }
        else if (browsername == "InternetExplorer")
        {
            driver = new InternetExplorerDriver();
        }
        else if (browsername == "Firefox")
        {
            driver = new FirefoxDriver();
        }
        return driver;
    }

    public static void CloseBrowser()
    {
        driver.Close();
        driver.Quit();
    }
}