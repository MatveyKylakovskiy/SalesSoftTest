using OpenQA.Selenium;
using PageObjectLib.Elements;
using SalesSoftTest.Pages.NavigateMenu;

namespace SalesSoftTest.Pages
{
    internal class HomePage
    {
        public static AccountsButton AccountsButton = new();
        public static ContactsButton ContactsButton = new();

        private static WebElements NavigetaMenuButtons(string item) => new(By.XPath($"//span[contains(@class,'slds-m-top') and text()='{item}']"));
    }
}
