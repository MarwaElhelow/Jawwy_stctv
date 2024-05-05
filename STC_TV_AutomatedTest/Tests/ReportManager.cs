using System;
using System.IO;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace STC_TV_AutomatedTest.Reports
{
    public static class ReportManager
    {
        private static ExtentReports _extent;

        public static ExtentReports GetReportInstance()
        {
            if (_extent == null)
            {
                var reportPath = @"C:\logs\Reports";
                var htmlReporter = new ExtentHtmlReporter(reportPath);

                _extent = new ExtentReports();
                _extent.AttachReporter((IObserver<AventStack.ExtentReports.Listener.Entity.ReportEntity>)htmlReporter);
            }

            return _extent;
        }
    }

    internal class ExtentHtmlReporter
    {
        private string reportPath;

        public ExtentHtmlReporter(string reportPath)
        {
            this.reportPath = reportPath;
        }
    }
}

