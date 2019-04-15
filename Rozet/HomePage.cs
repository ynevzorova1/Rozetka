using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozet
{
    public class RozetkaHomePage
    {
        IWebDriver driver;

        public RozetkaHomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = ("//ul[@class='menu-categories menu-categories_type_main']/li[1]/a"))]
        public IWebElement noutAndCompButton;

        [FindsBy(How = How.XPath, Using = ("//a[@href='https://rozetka.com.ua/notebooks/asus/c80004/v004/']"))]
        public IWebElement asusLink;

        [FindsBy(How = How.XPath, Using = ("//a[@href='https://rozetka.com.ua/cart/']"))]
        public IWebElement shoppingCart;

        [FindsBy(How = How.XPath, Using = ("//div[@class='header-actions__dummy-content header-actions__dummy-content_type_cart']"))]
        public IWebElement popUp;
    }
}
