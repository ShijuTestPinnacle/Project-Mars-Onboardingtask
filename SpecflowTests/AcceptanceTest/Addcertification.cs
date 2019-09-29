using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using static SpecflowPages.CommonMethods;

namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class Addcertification
    {
        [Given(@"I havenavigated to the profile page")]
        public void GivenIHavenavigatedToTheProfilePage()
        {
            //Explicit wait
            CommonMethods.ElementIsVisible(Driver.driver, "//*[@id='account-profile-section']/div/section[1]/div/a[2]", "XPath");
            //Thread.Sleep(1500);
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[2]")).Click();
        }

    [Given(@"I have navigated to the Certification tab")]
        public void GivenIHaveNavigatedToTheCertificationTab()
        {
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]")).Click();
        }
        
        [When(@"I click on the add new button and add new Certification details")]
        public void WhenIClickOnTheAddNewButtonAndAddNewCertificationDetails()
        {
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div")).Click();
            // enter the certification name
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input")).SendKeys("ranorex");
            //enter certified from text box
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input")).SendKeys("ranorexstudio");
            //choose frome year drop down box
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select")).Click();
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select/option[10]")).Click();
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]")).Click();

        }

        [Then(@"I should be able to view added certification details on my profile page")]
        public void ThenIShouldBeAbleToViewAddedCertificationDetailsOnMyProfilePage()
        {
            try
            {

                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add new certification");

                Thread.Sleep(1000);
                for (int i = 1; i <= 10; i++)
                {
                    string ExpectedValue = "ranorex";
                    string ActualValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;
                    Thread.Sleep(1000);
                    if (ExpectedValue == ActualValue)
                    {
                        CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added certification Successfully");
                        SaveScreenShotClass.SaveScreenshot(Driver.driver, "certificationAdded");
                        return;
                    }
                }
                // else
                //CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }

        }
    }
}
