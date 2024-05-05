STC TV Automated Test:

Description:

This project automates the testing of the subscription page for the STC TV website. It validates the subscription packages, including types, prices, and currencies, for three different countries. The tests verify the functionality and data accuracy of the subscription page./ 

Challenges Faced: 

Originally, the plan was to write the code in Java. However, I faced some issues with installing Java IDEs which led me to use C# and NUnit as the primary language and testing framework./ 

Getting Started: 

Prerequisites: 

Visual Studio or Eclipse or any other IDE with C# support / 
Git / 
Chromedriver (for running Selenium tests) / 

Installation : 

Clone the repository: git clone https://github.com/MarwaElhelow/Jawwy_stctv.git

Navigate to the project directory: cd Jawwy_stctv / 

Usage: 

Open the project in your IDE (e.g., Visual Studio).

Build the project to resolve dependencies and compile the code.

Run the test suite to validate the subscription packages:

You can run the tests directly from your IDE using the NUnit framework.

Alternatively, you can execute tests using a command-line runner such as NUnit Console. / 


Project Structure: 

Pages/: Contains classes that interact with the web pages and perform actions on them. / 

Tests/: Contains test classes that use NUnit to run automated tests. / 

Reports/: Stores the generated test reports. however, I have an issue with "ExtentReports" which I'm still investigating on it. So, Reporting is not working properly now. / 

Utilities/: Contains utility classes, such as file writing. / 

ReadMe.md: The current file, providing project documentation.
