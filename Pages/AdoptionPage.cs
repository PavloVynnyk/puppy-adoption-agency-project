using OpenQA.Selenium;

namespace PuppyAdoptionAgency.Pages
{
    public class AdoptionPage
    {
        public AdoptionPage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        public IWebDriver Driver { get; }

        //The check-box part should be rewritten with probably "for" loop
        //or "random generator class" to randomise the selection and don't repeating the code

        //Collar & Leash
        IWebElement txtCollarAndLeash => Driver.FindElement(By.Name("collar"));
        public bool IsCollarAndLeash() => txtCollarAndLeash.Displayed;

        //Identify "Collar & Leash" check-box
        IWebElement checkBox1 => Driver.FindElement(By.Id("collar"));
        public void ClickCheckBox1() => checkBox1.Click();

        //Chew Toy
        IWebElement txtChewToy => Driver.FindElement(By.Name("toy"));
        public bool IsChewToyExist() => txtChewToy.Displayed;

        //Identify "Chew Toy" check-box
        IWebElement checkBox2 => Driver.FindElement(By.Id("toy"));
        public void ClickCheckBox2() => checkBox2.Click();

        //Travel Carrier 
        IWebElement txtTravelCarriery => Driver.FindElement(By.Name("carrier"));
        public bool IsTravelCarriery() => txtTravelCarriery.Displayed;

        //Identify "Travel Carrier" check-box
        IWebElement checkBox3 => Driver.FindElement(By.Id("carrier"));
        public void ClickCheckBox3() => checkBox3.Click();

        //First Vet Visit
        IWebElement txtFirstVetVisit => Driver.FindElement(By.Name("vet"));
        public bool IsFirstVetVisit() => txtFirstVetVisit.Displayed;

        //Identify "First Vet Visit" check-box
        IWebElement checkBox4 => Driver.FindElement(By.Id("vet"));
        public void ClickCheckBox4() => checkBox4.Click();

        //Collar & Leash for another puppy
        IWebElement txtCollarForAnother => Driver.FindElement(By.XPath("/html/body/div/div[1]/div[3]/table/tbody/tr[9]/td[2]/text()"));
        public bool IsCollarForAnother() => txtCollarForAnother.Displayed;

        //Identify "Collar & Leash" check-box for another puppy
        IWebElement checkBox5 => Driver.FindElement(By.XPath("/html/body/div/div[1]/div[3]/table/tbody/tr[9]/td[2]/input"));
        public void ClickCheckBox5() => checkBox5.Click();

        //Identify complete the adoption
        public IWebElement btnCompleteAdoption => Driver.FindElement(By.XPath("/html/body/div/div[1]/div[3]/div[2]/form[1]/div/input"));
        public void ClickComplete() => btnCompleteAdoption.Click();

        //Identify adoptpion another puppy
        public IWebElement btnAdoptAnother => Driver.FindElement(By.XPath("/html/body/div/div[1]/div[3]/div[2]/form[2]/div/input[1]"));
        public void ClickAdoptAnother() => btnAdoptAnother.Click();
    }
}
