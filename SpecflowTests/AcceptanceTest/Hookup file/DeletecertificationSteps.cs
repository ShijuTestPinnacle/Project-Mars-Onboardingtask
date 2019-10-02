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
    public class DeleteCertificationSteps
    {
        [Given(@"I havenavigatedto the profile page")]
        public void GivenIHavenavigatedtoTheProfilePage()
        {
            //Explicit wait
            CommonMethods.ElementIsVisible(Driver.driver, "//*[@id='account-profile-section']/div/section[1]/div/a[2]", "XPath");
            //Thread.Sleep(1500);
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[2]")).Click();
        }

        [Given(@"I have navigated tothe certification tab")]
        public void GivenIHaveNavigatedTotheCertificationTab()
        {
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]")).Click();
        }


        [When(@"I click on  delete icon")]
        public void WhenIClickOnDeleteIcon()
        {
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[2]/i")).Click();
        }
        
        [Then(@"the deleted certification details should  not be visible on mypage")]
        public void ThenTheDeletedCertificationDetailsShouldNotBeVisibleOnMypage()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Delete certification");

                CommonMethods.ElementIsVisible(Driver.driver, "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[1]/tr/td[1]", "XPath");

                string ExpectedValue = "renorex";
                string ActualValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[1]/tr/td[1]")).Text;
                Thread.Sleep(1500);
                if (ExpectedValue != ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, certification entry successfully removed");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Deletedcertification");

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
