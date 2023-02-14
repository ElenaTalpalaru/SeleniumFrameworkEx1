using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumFrameworkEx1.Drivers;
using SeleniumFrameworkEx1.BussinessLogic.POM;

namespace SeleniumFrameworkEx1.BussinessLogic
{
    public class ActionHandler
    {
        private IWebDriver driver;

        public int DefaultWait { get; } = 30;

        public string GetElementText(By element) => driver.FindElement(element).Text;
        public void ClickLink(By element) => driver.FindElement(element).Click();
        public void SendFormText(By element, string text) => driver.FindElement(element).SendKeys(text);
        


        public ActionHandler(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
