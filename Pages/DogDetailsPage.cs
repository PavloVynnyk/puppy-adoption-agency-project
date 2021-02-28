using OpenQA.Selenium;

namespace PuppyAdoptionAgency.Pages
{
    public class DogDetailsPage
    {
        public DogDetailsPage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        public IWebDriver Driver { get; }

        //Identify adoption
        public IWebElement btnAdopt => Driver.FindElement(By.XPath("/html/body/div/div[1]/div[3]/div[2]/div/form/div/input[1]"));
        public void ClickAdopt() => btnAdopt.Click();
    }
}
