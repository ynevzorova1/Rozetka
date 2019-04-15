using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;

namespace Rozet
{
    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void SeyUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://rozetka.com.ua/");
        }

        [TearDown]

        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void TestMethod1()
        {
            string expectedResult = $"https://rozetka.com.ua/notebooks/c80004/filter/producer=asus/";

            RozetkaHomePage element = new RozetkaHomePage(driver);
            Actions actions = new Actions(driver);
            actions.MoveToElement(element.noutAndCompButton).MoveToElement(element.asusLink).Click().Perform();

            Assert.AreEqual(driver.Url, expectedResult, "expected url does not mach");
        
        }

        [Test]
        public void TestMethod2()
        {
            string expectedResult = "Ваша корзина пуста\r\nДобавляйте понравившиеся товары в корзину";

            RozetkaHomePage element = new RozetkaHomePage(driver);
            Actions actions = new Actions(driver);
            actions.MoveToElement(element.shoppingCart).Perform();

            string text = element.popUp.Text;
            Console.WriteLine(text);

            Assert.AreEqual(text, expectedResult, "text is not equal");
        }
    }
}
