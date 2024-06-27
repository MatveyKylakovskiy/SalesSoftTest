
using OpenQA.Selenium;
using PageObjectLib.Elements;

namespace SalesSoftTest.Pages
{
    internal class HomePage
    {
        private static WebElements NavigetaMenuButtons(string item) => new(By.XPath($"//span[contains(@class,'slds-m-top') and text()='{item}']"));
    }
}
