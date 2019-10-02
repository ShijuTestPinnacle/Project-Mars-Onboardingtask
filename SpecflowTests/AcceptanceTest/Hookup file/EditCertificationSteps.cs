using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using static SpecflowPages.CommonMethods;

namespace SpecflowTests.AcceptanceTest.Hookup_file
{
    [Binding]
    public class EditCertificationSteps
    {
        [Given(@"I have navigated to profilepage")]
        public void GivenIHaveNavigatedToProfilepage()
        {
            //Explicit wait
            CommonMethods.ElementIsVisible(Driver.driver, "//*[@id='account-profile-section']/div/section[1]/div/a[2]", "XPath");
            // Thread.Sleep(1500);
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[2]")).Click();
        }
        
        [Given(@"I have navigated to  certification tab")]
        public void GivenIHaveNavigatedToCertificationTab()
        {
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]")).Click();
        }
        
        [When(@"I click on  write icon and edit details")]
        public void WhenIClickOnWriteIconAndEditDetails()
        {
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[1]/tr/td[4]/span[1]/i")).Click();
            IWebElement certiname = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[1]/tr/td/div/div/div[1]/input"));
            certiname.Clear();
            certiname.SendKeys("volunteer");
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]")).Click();

        }
        
        [Then(@"the edited certification details should be visible on mypage")]
        public void ThenTheEditedCertificationDetailsShouldBeVisibleOnMypage()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                //Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("update certification");

                //Thread.Sleep(1000);
                CommonMethods.ElementIsVisible(Driver.driver, "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[1]/tr/td[1]", "XPath");
                string ExpectedValue = "volunteer";
                string ActualValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[1]/tr/td[1]")).Text;
                Thread.Sleep(1500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, updated certification Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "certification updated");
                    return;
                }

                // }

                // else
                // CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }
        }
    }
}
