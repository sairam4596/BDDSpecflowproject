using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace BDDSpecflowproject.Steps
{
    [Binding]
    public sealed class BDDSpecFlowSteps
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        private string url = "https://www.bigsmall.in";
        IWebDriver driver;

        public BDDSpecFlowSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            Browserinitial browser = new Browserinitial("Chrome");
        }

        [Given(@"intialize the browser")]
        public void GivenIntializeTheBrowser()
        {
            //string url = "https://www.bigsmall.in";
           driver = Browserinitial.GetDriverInstance();
        }
        [Given(@"navigate to the url")]
        public void GivenNavigateToTheUrl()
        {
            string url= "https://www.bigsmall.in";
            driver.Navigate().GoToUrl(url);
        }

        [Given(@"i am in homepage")]
        public void GivenIAmInHomepage()
        {
            //string url = "https://www.bigsmall.in";
            driver.Navigate().GoToUrl(url);
        }

        [Then(@"get the title of the homepage")]
        public void ThenGetTheTitleOfTheHomepage()
        {
            Console.WriteLine(driver.Title);
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("Title.png", ScreenshotImageFormat.Png);
            driver.Quit();
        }

        [Given(@"I click on signin")]
        public void GivenIClickOnSignin()
        {
            driver.FindElement(By.CssSelector(".link_text")).Click(); 
        }

        [Given(@"enter the email-id and password")]
        public void GivenEnterTheEmail_IdAndPassword()
        {
            driver.FindElement(By.Id("CustomerEmail")).SendKeys("sairamyadav179@gmail.com");
            driver.FindElement(By.Id("CustomerPassword")).SendKeys("Sairam@4596");
        }

        [Then(@"click on the Signin button")]
        public void ThenClickOnTheSigninButton()
        {
            driver.FindElement(By.CssSelector("input[Value='Sign In']")).Click();
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("Signin.png", ScreenshotImageFormat.Png);
            driver.Quit();
        }

        [Given(@"enter the invalid email-id and password")]
        public void GivenEnterTheInvalidEmail_IdAndPassword()
        {
            driver.FindElement(By.Id("CustomerEmail")).SendKeys("sairamyadav1791@gmail.com");
            driver.FindElement(By.Id("CustomerPassword")).SendKeys("Sairam@45961");
        }

        [Then(@"click on the Signin button and screenshot of invalid user")]
        public void ThenClickOnTheSigninButtonAndScreenshotOfInvalidUser()
        {
            driver.FindElement(By.CssSelector("input[Value='Sign In']")).Click();
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("invalidSignin.png", ScreenshotImageFormat.Png);
            driver.Quit();
        }


        [Given(@"click on create account")]
        public void GivenClickOnCreateAccount()
        {
            driver.FindElement(By.Id("customer_register_link")).Click();
        }

        [Given(@"enter  the firstname ,lastname,email and password")]
        public void GivenEnterTheFirstnameLastnameEmailAndPassword()
        {
            driver.FindElement(By.Id("FirstName")).SendKeys("sai");
            driver.FindElement(By.Id("LastName")).SendKeys("ram");
            driver.FindElement(By.Id("Email")).SendKeys("sa123@gmail.com");
            driver.FindElement(By.Id("CreatePassword")).SendKeys("Sa@45961");
        }

        [When(@"click on create button")]
        public void WhenClickOnCreateButton()
        {
            driver.FindElement(By.CssSelector("input[Value='Create']")).Click();
        }

        [Then(@"login to the new create account")]
        public void ThenLoginToTheNewCreateAccount()
        {
           
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("createAccount.png", ScreenshotImageFormat.Png);
            driver.Quit();
        }

        [Given(@"click on the google link")]
        public void GivenClickOnTheGoogleLink()
        {
            driver.FindElement(By.ClassName("social_login.google")).Click();
        }

        [When(@"enter  the value on the email")]
        public void WhenEnterTheValueOnTheEmail()
        {
            driver.FindElement(By.Name("identifier")).SendKeys("a@gmail.com");
        }

        [Then(@"take the screenshot")]
        public void ThenTakeTheScreenshot()
        {
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("signinwithgoogle.png", ScreenshotImageFormat.Png);
            driver.Quit();
        }

        [Given(@"enter the item in the search bar")]
        public void GivenEnterTheItemInTheSearchBar()
        {
            driver.FindElement(By.Name("q")).SendKeys("keychain"+Keys.Enter);
        }

        [Then(@"take the screenshot of result")]
        public void ThenTakeTheScreenshotOfResult()
        {
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("searchitem.png", ScreenshotImageFormat.Png);
            driver.Quit();
        }

        [Given(@"click on the gifts card")]
        public void GivenClickOnTheGiftsCard()
        {
            driver.FindElement(By.CssSelector("a[href$='card']")).Click();
        }

        [When(@"click on the add to card")]
        public void WhenClickOnTheAddToCard()
        {
            driver.FindElement(By.CssSelector("button[name='add']")).Click();
        }

        [Then(@"take the screenshot of card")]
        public void ThenTakeTheScreenshotOfCard()
        {
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("giftcard.png", ScreenshotImageFormat.Png);
            driver.Quit();
        }

        [Given(@"click on the cart")]
        public void GivenClickOnTheCart()
        {
            driver.FindElement(By.ClassName("carticonimage")).Click();
        }

        [Then(@"take the screenshot of cart item")]
        public void ThenTakeTheScreenshotOfCartItem()
        {
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("card.png", ScreenshotImageFormat.Png);
            driver.Quit();
        }

        [When(@"enter the pin code and click on check button")]
        public void WhenEnterThePinCodeAndClickOnCheckButton()
        {
            driver.FindElement(By.CssSelector("input[name='PostalCode']")).SendKeys("500018");
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/main/div[1]/div[1]/div/div/div[1]/div[2]/div/div[3]/button")).Click();
            Thread.Sleep(3000);
        }


        [Then(@"take screenshot of address")]
        public void ThenTakeScreenshotOfAddress()
        {
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("pincode.png", ScreenshotImageFormat.Png);
            driver.Quit();
        }

        [Given(@"Click on the wish list")]
        public void GivenClickOnTheWishList()
        {
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[1]/div[1]/div[1]/header/div[2]/div[2]/div[4]/div/div/a[2]/span")).Click();
        }

        [Then(@"take screenshot of wish list page")]
        public void ThenTakeScreenshotOfWishListPage()
        {
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("wishlist.png", ScreenshotImageFormat.Png);
            driver.Quit();
        }

        [Given(@"click on the birthday gift")]
        public void GivenClickOnTheBirthdayGift()
        {
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[1]/div[1]/div[1]/div/div/ul/li[10]/a")).Click();
        }

        [Then(@"take screenshot of birthday gifts")]
        public void ThenTakeScreenshotOfBirthdayGifts()
        {
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("birthdaygifts.png", ScreenshotImageFormat.Png);
            driver.Quit();
        }

        [Given(@"click on the gifts and click on the click on gift for guys")]
        public void GivenClickOnTheGiftsAndClickOnTheClickOnGiftForGuys()
        {
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[1]/div[1]/div[1]/div/div/ul/li[7]/a")).Click();
            
        }

        [Then(@"take the screenshot of the page")]
        public void ThenTakeTheScreenshotOfThePage()
        {
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("gifts.png", ScreenshotImageFormat.Png);
            driver.Quit();
        }


    }
}
