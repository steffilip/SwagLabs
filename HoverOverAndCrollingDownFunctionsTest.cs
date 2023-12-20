using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using SwagLabs___Final_Project.PageObjectModels;

namespace SwagLabs___Final_Project
{
    public class HoverOverAndSrollingDownFunctionsTest
    {
        [Fact]
        public void TestHoverOverAndScrollingDownFunctions()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                var swagLabsPage = new SwagLabsPage(driver);
                DemoHelper.Pause();

                swagLabsPage.NavigateTo();
                swagLabsPage.EnterEmail("standard_user");
                DemoHelper.Pause();
                swagLabsPage.EnterPassword("secret_sauce");
                DemoHelper.Pause();
                swagLabsPage.LogIn();
                DemoHelper.Pause();
                swagLabsPage.Menu();
                DemoHelper.Pause();
                swagLabsPage.About();
                DemoHelper.Pause();
                swagLabsPage.HoverOverDevelopers();
                DemoHelper.Pause();
                swagLabsPage.ClickSelenium();
                DemoHelper.Pause();
                swagLabsPage.SwitchToNewTab();
                DemoHelper.Pause();
                swagLabsPage.ClickSelenium4();
                DemoHelper.Pause();
                swagLabsPage.ScrollDown();
                DemoHelper.Pause();
                swagLabsPage.ClickPrevious();
                DemoHelper.Pause();

                bool isTextDisplayed = swagLabsPage.IsTextDisplayed();
                Assert.True(isTextDisplayed);
                DemoHelper.Pause();

                driver.Quit();
            }
        }
    }
}
