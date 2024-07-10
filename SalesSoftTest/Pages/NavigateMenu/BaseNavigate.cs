using OpenQA.Selenium;
using PageObjectLib.Elements;

namespace SalesSoftTest.Pages.NavigateMenu
{
    internal class BaseNavigate
    {
        protected string? MenuLocator { get; init; }

        private WebElements MenuButton() => new(By.XPath($"//a[contains(@class,'slds-text-align_center appItem') and @href='{MenuLocator}']/parent::*/parent::*"));
        private static WebElements NewItemButton() => new(By.XPath("//*[@title='New']"));
        private static WebElements SaveEditButton() => new(By.XPath("//*[@name='SaveEdit']"));

        public static void SaveEdit() => SaveEditButton().Click();
        public static void CreateNewItem() => NewItemButton().Click();
        public void ClickMenuButton() => MenuButton().Click();
    }
}
