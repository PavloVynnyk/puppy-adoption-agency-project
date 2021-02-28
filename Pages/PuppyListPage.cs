using OpenQA.Selenium;

namespace PuppyAdoptionAgency.Pages
{
    public class PuppyListPage
    {
        public PuppyListPage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        public IWebDriver Driver { get; }

        //Identify details of the first dog on the list
        //This part should be rewritten with probably "for" loop or "random generator class" to randomise the selection
        public IWebElement btnDetails => Driver.FindElement(By.XPath("/html/body/div/div[1]/div[3]/div[2]/div/div[4]/form/div/input"));
        public void ClickDetails() => btnDetails.Click();

        //Identify switching to the next page with the list
        public IWebElement btnNextPage => Driver.FindElement(By.LinkText("Next →"));
        public void ClickNextPage() => btnNextPage.Click();

        //Identify success on the homepage
        IWebElement txtSuccess => Driver.FindElement(By.Id("notice"));
        public bool IsSuccess() => txtSuccess.Displayed;
    }
}
