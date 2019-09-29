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
    public class AddskillsSteps
    {
        [Given(@"I have navigated to profile page")]
        public void GivenIHaveNavigatedToProfilePage()
        {
            //Explicit wait
            CommonMethods.ElementIsVisible(Driver.driver, "//*[@id='account-profile-section']/div/section[1]/div/a[2]", "XPath");
           // Thread.Sleep(1500);
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[2]")).Click();
        }
        
        [Given(@"I have navigated to the skill tab")]
        public void GivenIHaveNavigatedToTheSkillTab()
        {
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]")).Click();
        }
        
        [When(@"I click on the add new button and add new skills")]
        public void WhenIClickOnTheAddNewButtonAndAddNewSkills()
        {
            // click add new skills button
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input")).SendKeys("automation");
            //click skill Level
             Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select")).Click();
            //choose  a skill level
            IWebElement skills = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]"));
            skills.Click();
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]")).Click();
        }


        [Then(@"I should be able to view added skills on my profile page")]
        public void ThenIShouldBeAbleToViewAddedSkillsOnMyProfilePage()
        {
            //Console.WriteLine("Enter the value of n" +n);
            //Console.ReadLine();
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add a new skill");

                Thread.Sleep(1000);
                //if(n==1)
               /* {
                    string ExpectedValue = "automation";
                    string ActualValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]")).Text;
                    Thread.Sleep(500);
                    if (ExpectedValue == ActualValue)
                    {
                        CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a skill Successfully");
                        SaveScreenShotClass.SaveScreenshot(Driver.driver, "SkillAdded");
                    }
                }
                else
                {*/
                    for (int i = 1; i <= 10; i++)
                    {
                        string ExpectedValue = "automation";
                        string ActualValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;
                        Thread.Sleep(500);
                        if (ExpectedValue == ActualValue)
                        {
                            CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a skill Successfully");
                            SaveScreenShotClass.SaveScreenshot(Driver.driver, "SkillAdded");
                        return;
                        }
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
