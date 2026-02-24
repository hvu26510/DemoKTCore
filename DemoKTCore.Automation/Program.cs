using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Runtime.CompilerServices;

namespace DemoKTCore.Automation
{
    static class DomHelpers
    {
        public static IWebElement SafeFind(this IWebDriver d, By by, int timeout = 12)
        {
            return new WebDriverWait(d, TimeSpan.FromSeconds(timeout)).Until(ExpectedConditions.ElementExists(by));
        }

        public static IWebElement SafeClick(this IWebDriver d, By by, int timeout = 12)
        {
            return new WebDriverWait(d, TimeSpan.FromSeconds(timeout)).Until(ExpectedConditions.ElementToBeClickable(by));
        }

        public static void ScrollClick(this IWebDriver d, IWebElement el)
        {
            try
            {
                ((IJavaScriptExecutor)d).ExecuteScript("arguments[0].scrollIntoView({block:'center'});", el);
                el.Click();
            }
            catch (Exception ex) {
                ((IJavaScriptExecutor)d).ExecuteScript("arguments[0].click();", el);
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            var option = new ChromeOptions();

            option.AddArgument("--start--maximized");

            using var driver = new ChromeDriver(option);
            ThemGioHang(driver);
            Console.WriteLine("Da them gio hang");


            Console.WriteLine("Thanh cong");
        }

        public static void ThemGioHang(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://www.savor.vn/products/combo-best-seller");

            By by = By.XPath("//button[(contains(.,'Thêm vào giỏ'))]");

            var addGioHangBtn = driver.SafeClick(by, 12);

            driver.ScrollClick(addGioHangBtn);

            driver.Navigate().GoToUrl("https://www.savor.vn/checkout");

           
        }

        public void DatHang()
        {

        }
    }
}
