using OpenQA.Selenium;

namespace PuppyAdoptionAgency.Pages
{
    public class YourDetailsPage
    {
        public YourDetailsPage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        public IWebDriver Driver { get; }

        //Identify a name
        IWebElement txtName => Driver.FindElement(By.Name("order[name]"));

        //Identify an address
        IWebElement txtAddress => Driver.FindElement(By.Name("order[address]"));

        //Identify an email
        IWebElement txtEmail => Driver.FindElement(By.Name("order[email]"));

        //Identify a payment method - check
        IWebElement btnCheck => Driver.FindElement(By.XPath("//html/body/div/div[1]/div[3]/div[2]/fieldset/form/div[5]/select/option[2]"));
        public void Check() => btnCheck.Click();

        //Identify a payment method - credit card
        IWebElement btnCreditCard => Driver.FindElement(By.XPath("html/body/div/div[1]/div[3]/div[2]/fieldset/form/div[5]/select/option[3]"));
        public void CreditCard() => btnCreditCard.Click();

        //Identify a payment method - purchase order
        IWebElement btnPurchaseOrder => Driver.FindElement(By.XPath("/html/body/div/div[1]/div[3]/div[2]/fieldset/form/div[5]/select/option[4]"));
        public void PurchaseOrder() => btnPurchaseOrder.Click();

        //Identify place order
        IWebElement btnPlaceOrder => Driver.FindElement(By.XPath("/html/body/div/div[1]/div[3]/div[2]/fieldset/form/div[6]/input"));
        public void PlaceOrder() => btnPlaceOrder.Click();

        //Identify a form
        public void Form(string name, string address, string email)
        {
            txtName.SendKeys(name);
            txtAddress.SendKeys(address);
            txtEmail.SendKeys(email);
        }
    }
}
