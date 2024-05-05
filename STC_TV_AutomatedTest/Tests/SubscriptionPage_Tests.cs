using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using STC_TV_AutomatedTest.Pages;
using STC_TV_AutomatedTest.Utilities;


namespace STC_TV_AutomatedTest.Tests
{
    [TestFixture]
    public class SubscriptionPageTests
    {
        private IWebDriver _driver;
        private SubscriptionPage _subscriptionPage;
        private FileWriter _fileWriter;

        [SetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver();
            _subscriptionPage = new SubscriptionPage(_driver);
            _fileWriter = new FileWriter();
        }

        [Test]
        [TestCase("Country1")]
        [TestCase("Country2")]
        [TestCase("Country3")]
        public void ValidateSubscriptionPackages(string country)
        {
            // Navigate to the subscription page
            _subscriptionPage.NavigateTo();

            // Select the specified country
            _subscriptionPage.SelectCountry(country);

            // Retrieve subscription packages
            var packages = _subscriptionPage.GetSubscriptionPackages();

            // Validate the subscription packages
            _fileWriter.WriteResultsToNotepad(packages, country);
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }

        
    }
}
