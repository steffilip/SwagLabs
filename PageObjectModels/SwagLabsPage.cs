using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Reflection.Metadata;

namespace SwagLabs___Final_Project.PageObjectModels
{
    // Defines a class named SwagLabsPage
    public class SwagLabsPage
    {
        // Private variable to hold the WebDriver instance
        private readonly IWebDriver driver;

        // Constructor for SwagLabsPage, receives the WebDriver instance
        public SwagLabsPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Constant string defining the URL of the Swag Labs page
        private const string pageUrl = "https://www.saucedemo.com/";
        private const string pageTitle = "SwagLabs";

        public void NavigateTo()
        {
            // Navigates to the specified URL and adds a pause
            driver.Navigate().GoToUrl(pageUrl);
            DemoHelper.Pause(); // A pause for demonstration, can be removed
        }

        #region LogInTest
        public IWebElement EmailInput => driver.FindElement(By.XPath("/html/body/div/div/div[2]/div[1]/div/div/form/div[1]/input"));
        public IWebElement PasswordInput => driver.FindElement(By.XPath("//*[@id=\"password\"]"));
        public IWebElement LogInButton => driver.FindElement(By.XPath("/html/body/div/div/div[2]/div[1]/div/div/form/input"));

        // Enters the email into the email input field
        public void EnterEmail(string email) { EmailInput.SendKeys(email); }

        // Enters the password into the password input field
        public void EnterPassword(string password) { PasswordInput.SendKeys(password); }


        // Clicks the login button to initiate the login process
        public void LogIn() { LogInButton.Click(); }


        #endregion

        #region LogOutTest

        // Web elements related to filtering products
        public IWebElement MenuButton => driver.FindElement(By.XPath("/html/body/div/div/div/div[1]/div[1]/div[1]/div/div[1]/div/button"));
        public IWebElement LogOutButton => driver.FindElement(By.XPath("/html/body/div/div/div/div[1]/div[1]/div[1]/div/div[2]/div[1]/nav/a[3]"));

        // Clicks on the menu button to open the menu
        public void Menu() { MenuButton.Click(); }

        // Clicks on the logout button to perform logout action
        public void LogOut() { LogOutButton.Click(); }
        #endregion

        #region HoverOverAndScrollingDownFunctionsTest
        // Elements related to hover-over and scrolling functions
        public IWebElement AboutButton => driver.FindElement(By.XPath("/html/body/div/div/div/div[1]/div[1]/div[1]/div/div[2]/div[1]/nav/a[2]"));
        public IWebElement HoverOver => driver.FindElement(By.XPath("/html/body/div[1]/header/div/div/div[1]/div[2]/div/div[4]/div[1]/div[1]/span"));
        public IWebElement SeleniumRedirectButton => driver.FindElement(By.XPath("/html/body/div[1]/header/div/div/div[1]/div[2]/div/div[4]/div[2]/div/div/div[1]/div[2]/div[2]/div[2]/div[1]/a/div/div/div/div/span"));
        public IWebElement Selenium4 => driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/aside/div/div/nav/ul/li[6]/ul/li[3]/ul/li[1]/ul/li[3]"));
        public IWebElement PreviousButton => driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/main/div/div/div[1]/div/nav/a[1]"));

        //Clicks on the 'About' button
        public void About() { AboutButton.Click(); }

        // Moves the mouse pointer to the 'HoverOver' element
        public void HoverOverDevelopers()
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(HoverOver).Perform();
        }

        // Clicks the Selenium button
        public void ClickSelenium() { SeleniumRedirectButton.Click(); } // Clicks the 'SeleniumRedirectButton

        public void ClickSelenium4() { Selenium4.Click(); }
        public void SwitchToNewTab()
        {
            // Get the handles of all open tabs/windows
            var windowHandles = this.driver.WindowHandles;

            // Switch to the last opened tab (assuming it's the new tab)
            string newTabHandle = windowHandles[windowHandles.Count - 1];
            this.driver.SwitchTo().Window(newTabHandle);
        }
        //Scrolls down
        public void ScrollDown()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
        }
        // Clicks the Previous button
        public void ClickPrevious() { PreviousButton.Click(); }
        public bool IsTextDisplayed()
        {
            try
            {
                // Find the header text element on the page
                IWebElement correctTextMessage = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/main/div/div/div[1]/div/article/div[2]/header/h1"));
                return correctTextMessage.Displayed; // Returns true if the element is displayed
            }
            catch
            {
                return false; // Returns false if the element is not found or an exception occurs
            }
        }

        #endregion

        #region CheckOutProductsTest
        public IWebElement AddtoCart1 => driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/div/div/div[1]/div[2]/div[2]/button"));
        public IWebElement AddtoCart2 => driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/div/div/div[2]/div[2]/div[2]/button"));
        public IWebElement CartButton => driver.FindElement(By.XPath("/html/body/div/div/div/div[1]/div[1]/div[3]/a"));
        public IWebElement CheckoutButton => driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/div[2]/button[2]"));
        public IWebElement FirstNameInput => driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/form/div[1]/div[1]/input"));
        public IWebElement LastNameInput => driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/form/div[1]/div[2]/input"));
        public IWebElement PostalCodeInput => driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/form/div[1]/div[3]/input"));
        public IWebElement ContinueButton => driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/form/div[2]/input"));
        public IWebElement FinishButton => driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/div[2]/div[9]/button[2]"));


        public void ClickAddToCart1() { AddtoCart1.Click(); }
        public void ClickAddToCart2() { AddtoCart2.Click(); }
        public void ClickCart() { CartButton.Click(); }
        public void ClickCheckout() { CheckoutButton.Click(); }
        public void FirstName(string firstname) { FirstNameInput.SendKeys(firstname); }
        public void LastName(string lastname) { LastNameInput.SendKeys(lastname); }
        public void PostalCode(string postalcode) { PostalCodeInput.SendKeys(postalcode); }
        public void Continue() { ContinueButton.Click(); }
        public void ClickFinish() { FinishButton.Click(); }

        public bool IsThankYouDisplayed()
        {
            try
            {
                IWebElement thankYouMessage = driver.FindElement(By.XPath("//*[contains(text(), 'Thank you')]"));
                return thankYouMessage.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false; // Return false if the element is not found
            }
        }
        #endregion

        #region FilterProductsTest

        // Web elements related to filtering products
        public IWebElement SortButton => driver.FindElement(By.XPath("/html/body/div/div/div/div[1]/div[2]/div/span/select"));
        public IWebElement HighToLowSelection => driver.FindElement(By.XPath("//*[contains(text(), 'Price (high to low)')]"));
        public IWebElement AddToCartSelection => driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/div/div/div[1]/div[2]/div[2]/button"));

        // Clicks on the 'Sort' button
        public void ClickSort() { SortButton.Click(); }

        // Selects 'Price (high to low)' from the dropdown
        public void SelectHighToLow() { HighToLowSelection.Click(); }

        // Clicks on the 'Add to Cart' button for a product
        public void SelectAddToCart() { AddToCartSelection.Click(); }

        // Checks if a specific selection is displayed
        public bool IsSelectionDisplayed()
        {
            try
            {
                // Find a specific element representing the displayed selection
                IWebElement correctSelectionDisplayed = driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/div[1]/div[3]/div[2]/a/div"));
                return correctSelectionDisplayed.Displayed; // Returns true if the element is displayed
            }
            catch
            {
                return false; // Returns false if the element is not found or an exception occurs
            }
        }


        #endregion

        #region LockedOutUserTest

        // Checks if a specific selection is displayed
        public bool IsErrorDisplayed()
        {
            try
            {
                // Find a specific element representing the displayed selection
                IWebElement errorMessage = driver.FindElement(By.XPath("/html/body/div/div/div[2]/div[1]/div/div/form/div[3]"));
                return errorMessage.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false; // Returns false if the element is not found or an exception occurs
            }
        }

        #endregion

        #region ProblemUserTest

        public IWebElement AddtoCart => driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/div/div/div[1]/div[2]/div[2]/button"));
        public void ClickAddtoCart() { AddtoCart.Click(); }

        public bool IsProblemVisible()
        {
            try
            {
                // Find a specific element representing the displayed selection
                IWebElement errorMessage = driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/form/div[1]/div[1]/input"));
                return errorMessage.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false; // Returns false if the element is not found or an exception occurs
            }
        }
        #endregion

    }

}
