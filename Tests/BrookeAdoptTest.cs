using OpenQA.Selenium;
using NUnit.Framework;
using PuppyAdoptionAgency.Pages;
using OpenQA.Selenium.Chrome;

namespace PuppyAdoptionAgency.Tests
{
    public class BrookeAdoptTest
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
        public void BrookeAdopt()
        {
            PuppyListPage puppyListPage = new PuppyListPage(webDriver);
            //Step 1: Click on the "View Details" btn in the selected dog section
            puppyListPage.ClickDetails();

            DogDetailsPage dogDetailsPage = new DogDetailsPage(webDriver);
            //Step 2: Click on the "Adopt Me!" btn
            dogDetailsPage.ClickAdopt();

            AdoptionPage adoptionPage = new AdoptionPage(webDriver);
            //Step 3: Select "Chew Toy"
            adoptionPage.ClickCheckBox2();
            //Step 4: Select "Travel Carrier"
            adoptionPage.ClickCheckBox3();
            //Step 5: Click on the "Complete the Adoption" btn
            adoptionPage.ClickComplete();

            YourDetailsPage yourDetailsPage = new YourDetailsPage(webDriver);
            //Step 6: Fill-in the form
            yourDetailsPage.Form("John Doe", "2034 Tully Street, Detroit, Michigan, 48219", "test@test.com");
            //Step 7: Click on the "Check" payment type
            yourDetailsPage.Check();
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
