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
    public class FilterProductsTest
    {
        [Fact]
        public void TestFilterProducts()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                var swagLabsPage = new SwagLabsPage(driver);
                DemoHelper.Pause();

                swagLabsPage.NavigateTo();
                DemoHelper.Pause();
                swagLabsPage.EnterEmail("standard_user");
                DemoHelper.Pause();
                swagLabsPage.EnterPassword("secret_sauce");
                DemoHelper.Pause();
                swagLabsPage.LogIn();
                DemoHelper.Pause();

                swagLabsPage.ClickSort();
                DemoHelper.Pause();
                swagLabsPage.SelectHighToLow();
                DemoHelper.Pause();
                swagLabsPage.SelectAddToCart();
                DemoHelper.Pause();
                swagLabsPage.ClickCart();
                DemoHelper.Pause();

                bool isSelectionDisplayed = swagLabsPage.IsSelectionDisplayed();
                Assert.True(isSelectionDisplayed);
                DemoHelper.Pause();

                swagLabsPage.Menu();
                DemoHelper.Pause();
                swagLabsPage.LogOut();
                DemoHelper.Pause();

                driver.Quit();
            }
        }
    }
}
