using OpenQA.Selenium;

namespace SeleniumFrameworkEx1.BussinessLogic.POM
{
    public class ForTestingPage
    {
        public readonly string TestingPageUrl = "https://elenatalpalaru.github.io/soap-art/for-testing.html";

        public readonly By userNameBoundryForm = By.XPath("//*[@id=\"username\"]");
        public readonly By passwordBoundryForm = By.XPath("//*[@id=\"password\"]");
        public readonly By submitButton = By.XPath("//*[@id=\"submit\"]");
        public readonly By firstTextOnForTesting = By.XPath("/html/body/div[1]/p[1]");        

        
    }
}
