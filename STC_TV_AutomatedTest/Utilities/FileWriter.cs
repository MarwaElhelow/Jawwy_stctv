using System;
using System.Collections.Generic;
using System.IO;
using STC_TV_AutomatedTest.Pages;

namespace STC_TV_AutomatedTest.Utilities
{
    public class FileWriter
    {
        private readonly string _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SubscriptionResults.txt");

        public void WriteResultsToNotepad(List<SubscriptionPackage> packages, string country)
        {
            using (var writer = new StreamWriter(_filePath, true))
            {
                writer.WriteLine($"Country: {country}");
                foreach (var package in packages)
                {
                    writer.WriteLine($"Type: {package.Type}, Price: {package.Price}, Currency: {package.Currency}");
                }
                writer.WriteLine(); // Add a blank line between different countries
            }
        }
    }
}
