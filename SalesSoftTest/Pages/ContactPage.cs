
using OpenQA.Selenium;
using PageObjectLib.Elements;

namespace SalesSoftTest.Pages
{
    internal class ContactPage
    {
        private static WebElements NewContactButton() => new(By.XPath("//*[@title='New']"));

    }
}
