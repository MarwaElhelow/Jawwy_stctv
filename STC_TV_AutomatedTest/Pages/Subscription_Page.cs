using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace STC_TV_AutomatedTest.Pages
{
    public class SubscriptionPage
    {
        private readonly IWebDriver _driver;
        private readonly string _url = "https://subscribe.stctv.com/";

        // Define locators
        private By _packageDetailsLocator = By.CssSelector(".package-details");

        public SubscriptionPage(IWebDriver driver)
        {
            _driver = driver;
        }

        // Method to navigate to the subscription page
        public void NavigateTo()
        {
            _driver.Navigate().GoToUrl(_url);
        }

        // Method to select country
        public void SelectCountry(string country)
        {
            // Implement the logic to select the country on the page
        }

        // Method to retrieve package details
        public List<SubscriptionPackage> GetSubscriptionPackages()
        {
            var packages = new List<SubscriptionPackage>();

            var packageElements = _driver.FindElements(_packageDetailsLocator);

            foreach (var element in packageElements)
            {
                var type = element.FindElement(By.CssSelector(".package-type")).Text;
                var price = element.FindElement(By.CssSelector(".package-price")).Text;
                var currency = element.FindElement(By.CssSelector(".package-currency")).Text;

                packages.Add(new SubscriptionPackage
                {
                    Type = type,
                    Price = price,
                    Currency = currency,
                });
            }

            return packages;
        }
    }

    // Define a class to hold subscription package details
    public class SubscriptionPackage
    {
        public string Type { get; set; }
        public string Price { get; set; }
        public string Currency { get; set; }
    }
}

