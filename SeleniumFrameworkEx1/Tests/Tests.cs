using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;
using SeleniumFrameworkEx1.Drivers;
using System.Reflection.Metadata;
using SeleniumFrameworkEx1.BussinessLogic;
using SeleniumFrameworkEx1.BussinessLogic.POM;
using FluentAssertions;

namespace SeleniumFrameworkEx1.Tests
{
    public class Tests
    {
        BaseDriver? baseDriver;
        ActionHandler? handler;
        HomePage homePage = new HomePage();
        ForTestingPage forTesting = new ForTestingPage();

        [SetUp]
        public void Setup()
        {
            baseDriver = new BaseDriver();
            baseDriver.NavigateToURL(homePage.HomePageUrl);
            handler = new ActionHandler(baseDriver.webDriver);
        }

        [Test]
        public void HeaderIsPresentOnHomePage()
        {           
            handler!
                .GetElementText(homePage.HomePageHeader)
                .Should()
                .Be("Elena's soap art");
        }

        [Test]
        public void NavigateToForTestingPage()
        {
            //click on for testing link from home page and be on for testing page
            handler.ClickLink(homePage.forTestingLink);
            handler.GetElementText(forTesting.firstTextOnForTesting)
                .Should().Be("1. Boundary value");
        }

        [TearDown]
        public void Teardown()
        {
            baseDriver!.Quit();
        }
    }
}