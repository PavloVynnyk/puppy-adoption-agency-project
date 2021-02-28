using OpenQA.Selenium;
using NUnit.Framework;
using PuppyAdoptionAgency.Pages;
using OpenQA.Selenium.Chrome;

namespace PuppyAdoptionAgency.Tests
{
    public class TwoDogsAdoptTest
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
        public void TwoDogsAdopt()
        {
            PuppyListPage puppyListPage = new PuppyListPage(webDriver);
            //Step 1: Click on the "View Details" btn in the selected dog section
            puppyListPage.ClickDetails();

            DogDetailsPage dogDetailsPage = new DogDetailsPage(webDriver);
            //Step 2: Click on the "Adopt Me!" btn
            dogDetailsPage.ClickAdopt();

            AdoptionPage adoptionPage = new AdoptionPage(webDriver);
            //Step 3: Click on the "Adopt Another Puppy" btn
            adoptionPage.ClickAdoptAnother();

            //Step 4: Click on the "Next" btn
            puppyListPage.ClickNextPage();

            //Step 2: Click on the "View Details" btn in the selected dog section
            puppyListPage.ClickDetails();

            //Step6: Click on the "Adopt Me!" btn
            dogDetailsPage.ClickAdopt();

            //Step 7: Select "Collar & Leash" for the first puppy
            adoptionPage.ClickCheckBox1();

            //Step 8: Select "Collar & Leash" for the second puppy
            adoptionPage.ClickCheckBox5();

            //Step 9: Click on the "Complete the Adoption" btn
            adoptionPage.ClickComplete();

            YourDetailsPage yourDetailsPage = new YourDetailsPage(webDriver);
            //Step 10: Fill-in the form
            yourDetailsPage.Form("John Doe", "2034 Tully Street, Detroit, Michigan, 48219", "test@test.com");
            //Step 11: Click on the "Credit Card" payment typ
            yourDetailsPage.CreditCard();
            //Step 12: Click on the "Place Order" btn
            yourDetailsPage.PlaceOrder();

            //Step 13: Verify the success on the homepage
            Assert.That(puppyListPage.IsSuccess, Is.True);
        }
        //Close the browser
        [TearDown]
        public void TearDoen() => webDriver.Quit();
    }
}

