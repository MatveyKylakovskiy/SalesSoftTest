using OpenQA.Selenium;
using PageObjectLib.Elements;

namespace SalesSoftTest.Pages.NavigateMenu
{
    internal class BaseNavigate
    {
        protected string? MenuLocator { get; init; }
        private WebElements MenuButton() => new(By.XPath($"//a[contains(@class,'slds-text-align_center appItem') and @href='{MenuLocator}']/parent::*/parent::*"));

        public void ClickMenuButton() => MenuButton().Click();
    }
}
