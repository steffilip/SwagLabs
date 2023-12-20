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
    public class CheckOutProductsTest
    {
        [Fact]
        public void TestCheckOutProducts()
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
                swagLabsPage.ClickAddToCart1();
                DemoHelper.Pause();
                swagLabsPage.ClickAddToCart2();
                DemoHelper.Pause();
                swagLabsPage.ClickCart();
                DemoHelper.Pause();
                swagLabsPage.ClickCheckout();
                DemoHelper.Pause();
                swagLabsPage.FirstName("Filip");
                DemoHelper.Pause();
                swagLabsPage.LastName("Stefanovski");
                DemoHelper.Pause();
                swagLabsPage.PostalCode("1000");
                DemoHelper.Pause();
                swagLabsPage.Continue();
                DemoHelper.Pause();
                swagLabsPage.ClickFinish();
                DemoHelper.Pause();

                bool isThankYouDisplayed = swagLabsPage.IsThankYouDisplayed();
                Assert.True(isThankYouDisplayed);
                DemoHelper.Pause();

                driver.Quit();

            }
        }
    }
}
