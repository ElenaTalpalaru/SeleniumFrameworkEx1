using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFrameworkEx1.BussinessLogic.POM
{
    internal class HomePage
    {
        public string HomePageUrl { get; } = "https://elenatalpalaru.github.io/soap-art/";

        //using By instead of string type -- as this expects to find an xpath
        public By HomePageHeader = By.XPath("//*[@id=\"heading\"]");
        public readonly By forTestingLink = By.XPath("/html/body/h3[4]/a");



    }
}
