using NUnit.Framework;
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
    public class DeleteEducationSteps
    {
        [Given(@"I have navigated tothe profile page")]
        public void GivenIHaveNavigatedTotheProfilePage()
        {
            //Explicit wait
            CommonMethods.ElementIsVisible(Driver.driver, "//*[@id='account-profile-section']/div/section[1]/div/a[2]", "XPath");
            // Thread.Sleep(1500);
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[2]")).Click();
        }

        [Given(@"I have navigated to the Educationtab")]
        public void GivenIHaveNavigatedToTheEducationtab()
        {
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]")).Click();
        }

        [When(@"I click on the deleteicon")]
        public void WhenIClickOnTheDeleteicon()
        {
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td[6]/span[2]/i")).Click();
        }

        [Then(@"the deleted education details should  not be visible on mypage")]
        public void ThenTheDeletedEducationDetailsShouldNotBeVisibleOnMypage()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Delete Education");

                CommonMethods.ElementIsVisible(Driver.driver, "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td[2]", "XPath");

                //string ExpectedValue = "abcd";
                string ActualValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td[2]")).Text;
                Thread.Sleep(1500);
                Assert.That(ActualValue, Is.Not.EqualTo("abcd"));
                // if (ExpectedValue != ActualValue)
                //{
                CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Education entry successfully removed");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "DeletedEducation");

                //}

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
