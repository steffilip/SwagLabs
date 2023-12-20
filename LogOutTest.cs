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
    public class LogOutTest
    {
        [Fact]
        public void TestLogOut()
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
                swagLabsPage.LogOut();

                Assert.Contains("https://www.saucedemo.com/", driver.Url);
                DemoHelper.Pause();

                driver.Quit();
            }
        }
    }
}
