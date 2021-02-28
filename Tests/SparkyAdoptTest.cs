using OpenQA.Selenium;
using NUnit.Framework;
using PuppyAdoptionAgency.Pages;
using OpenQA.Selenium.Chrome;

namespace PuppyAdoptionAgency.Tests
{
    public class SparkyAdoptTest
    {
        //Browser driver
        IWebDriver webDriver = new ChromeDriver();

        [SetUp]
        public void Setup()
        {
            //Navigate to the site
            webDriver.Navigate().GoToUrl("http://puppies.herokuapp.com/");
            webDriver.Manage().Window.Maximize();
        }

        [Test]
        public void SparkyAdopt()
        {
            PuppyListPage puppyListPage = new PuppyListPage(webDriver);
            //Step 1: Click on the "Next" btn
            puppyListPage.ClickNextPage();
            //Step 2: Click on the "View Details" btn in the selected dog section
            puppyListPage.ClickDetails();

            DogDetailsPage dogDetailsPage = new DogDetailsPage(webDriver);
            //Step 3: Click on the "Adopt Me!" btn
            dogDetailsPage.ClickAdopt();

            AdoptionPage adoptionPage = new AdoptionPage(webDriver);
            //Step 4: Select "Collar & Leash"
            adoptionPage.ClickCheckBox1();
            //Step 5: Click on the "Complete the Adoption" btn
            adoptionPage.ClickComplete();

            YourDetailsPage yourDetailsPage = new YourDetailsPage(webDriver);
            //Step 6: Fill-in the form
            yourDetailsPage.Form("John Doe", "2034 Tully Street, Detroit, Michigan, 48219", "test@test.com");
            //Step 7: Click on the "Credit Card" payment typ
            yourDetailsPage.CreditCard();
            //Step 8: Click on the "Place Order" btn
            yourDetailsPage.PlaceOrder();

            //Step 9: Verify the success on the homepage
            Assert.That(puppyListPage.IsSuccess, Is.True);
        }
        //Close the browser
        [TearDown]
        public void TearDoen() => webDriver.Quit();
    }
}

