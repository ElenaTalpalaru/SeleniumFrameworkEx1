using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;
using OpenQA.Selenium;
using WebDriverManager.Helpers;

namespace SeleniumFrameworkEx1.Drivers
{
    public class BaseDriver
    {
        public IWebDriver webDriver { get; private set; }
        public BaseDriver()
        {
            new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
            webDriver = new ChromeDriver();

            webDriver.Manage().Window.Maximize();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            webDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
        }
        public void NavigateToURL(string url)
        {
            webDriver.Navigate().GoToUrl(url);
        }

    public void Quit() 
        { webDriver.Quit(); }    
    }
}
