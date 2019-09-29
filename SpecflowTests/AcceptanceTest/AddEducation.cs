using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using static SpecflowPages.CommonMethods;
using SpecflowPages.Utils;

namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class AddEducationSteps
    {
        [Given(@"I have navigated to the profile page")]
        public void GivenIHaveNavigatedToTheProfilePage()
        {
            //Explicit wait
            CommonMethods.ElementIsVisible(Driver.driver, "//*[@id='account-profile-section']/div/section[1]/div/a[2]", "XPath");
           // Thread.Sleep(1500);
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[2]")).Click();
        }
        
        [Given(@"I have navigated to the Educationl tab")]
        public void GivenIHaveNavigatedToTheEducationlTab()
        {
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]")).Click();
        }
        
        [When(@"I click on the add new button and add new Education details")]
        public void WhenIClickOnTheAddNewButtonAndAddNewEducationDetails()
        {
            //click on add new button
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div")).Click();
            //Enter the university name
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input")).SendKeys("Manonmani");
            //Select country of college from drop down list
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select")).Click();
            IWebElement country = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[66]"));
            country.Click();
            //Select Title
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select")).Click();
            IWebElement title = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option[7]"));
            title.Click();
            //enter degree
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input")).SendKeys("Information Technology");
            //choosing year from dropdown list
             Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select")).Click();
            IWebElement year = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[9]"));
            year.Click();
            //click on add button
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]")).Click();
        }

        [Then(@"I should be able to view added Education details on my profile page")]
        public void ThenIShouldBeAbleToViewAddedEducationDetailsOnMyProfilePage()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
              
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add education details");

                Thread.Sleep(1000);
                for (int i = 1; i <= 10; i++)
                {
                    string TitleExpectedValue = "B.Tech";
                    string TitleActualValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody["+ i +"]/tr/td[3]")).Text;
                    //string UniversityExpectedValue = "Manonmani";
                    //string UniversityActualValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[2]")).Text;

                    Thread.Sleep(500);
                    if (TitleExpectedValue == TitleActualValue)
                    {
                        CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added new Education details Successfully");
                        SaveScreenShotClass.SaveScreenshot(Driver.driver, "EducationAdded");
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
