using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using SwagLabs___Final_Project.PageObjectModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SwagLabs___Final_Project
{
    public class ProblemUserTest
    {
        [Fact]
        public void TestCheckOutProducts()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                var swagLabsPage = new SwagLabsPage(driver);
                DemoHelper.Pause();

                swagLabsPage.NavigateTo();
                swagLabsPage.EnterEmail("problem_user");
                DemoHelper.Pause();
                swagLabsPage.EnterPassword("secret_sauce");
                DemoHelper.Pause();
                swagLabsPage.LogIn();
                DemoHelper.Pause();
                swagLabsPage.ClickAddtoCart();
                DemoHelper.Pause();
                swagLabsPage.ClickCart();
                DemoHelper.Pause();
                swagLabsPage.ClickCheckout();
                DemoHelper.Pause();
                swagLabsPage.FirstName("Filip");
                DemoHelper.Pause();
                swagLabsPage.LastName("Stefanovski");
                DemoHelper.Pause();

                bool isProblemVisible = swagLabsPage.IsProblemVisible();
                Assert.True(isProblemVisible);
                DemoHelper.Pause();

                driver.Quit();
            }
        }
    }
}
