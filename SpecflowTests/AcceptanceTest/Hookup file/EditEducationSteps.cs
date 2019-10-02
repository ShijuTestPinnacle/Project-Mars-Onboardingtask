using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using static SpecflowPages.CommonMethods;

namespace SpecflowTests.AcceptanceTest.Hookup_file
{
    [Binding]
    public class EditEducationSteps
    {
        [Given(@"I have navigated to theprofile page")]
        public void GivenIHaveNavigatedToTheprofilePage()
        {
            //Explicit wait
            CommonMethods.ElementIsVisible(Driver.driver, "//*[@id='account-profile-section']/div/section[1]/div/a[2]", "XPath");
            // Thread.Sleep(1500);
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[2]")).Click();
        }
        
        [Given(@"I have navigated to the Education tab")]
        public void GivenIHaveNavigatedToTheEducationTab()
        {
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]")).Click();
        }
        
        [When(@"I click on the write icon and editdetails")]
        public void WhenIClickOnTheWriteIconAndEditdetails()
        {
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td[6]/span[1]/i")).Click();
            IWebElement uniname = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td/div[1]/div[1]/input"));
            uniname.Clear();
            uniname.SendKeys("victoria");
            //Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"))
            var year = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td/div[2]/div[3]/select"));
            year.Click();
            var selectElement = new SelectElement(year);
            selectElement.SelectByText("2014");
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td/div[3]/input[1]")).Click();
        }
        
        [Then(@"the edited details should be visible on mypage")]
        public void ThenTheEditedDetailsShouldBeVisibleOnMypage()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                //Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("update Education");

                // Thread.Sleep(1000);
                CommonMethods.ElementIsVisible(Driver.driver, "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td[2]", "XPath");
                string ExpectedValue = "victoria";
                string ActualValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td[2]")).Text;
                Thread.Sleep(1500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, updated Education Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Education updated");
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
