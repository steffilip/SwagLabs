using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SwagLabs___Final_Project.PageObjectModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SwagLabs___Final_Project
{
    public class LockedOutUserTest
    {
        [Fact]
        public void TestLockedOutUser()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                var swagLabsPage = new SwagLabsPage(driver);
                DemoHelper.Pause();

                swagLabsPage.NavigateTo();
                DemoHelper.Pause();
                swagLabsPage.EnterEmail("locked_out_user");
                DemoHelper.Pause();
                swagLabsPage.EnterPassword("secret_sauce");
                DemoHelper.Pause();
                swagLabsPage.LogIn();
                DemoHelper.Pause();

                bool isErrorDisplayed = swagLabsPage.IsErrorDisplayed();
                Assert.True(isErrorDisplayed);
                DemoHelper.Pause();

                driver.Quit();
            }
        }
    }
}
