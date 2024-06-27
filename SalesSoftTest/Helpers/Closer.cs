
using OpenQA.Selenium;
using PageObjectLib.Elements;

namespace SalesSoftTest.Helpers
{
    internal class Closer

    {   private static WebElements CloseButton() => new(By.XPath("//*[@class='slds-button slds-button_icon slds-m-right_x-small']"));

        public static void CloseHomeTab()
        {
            try
            {
                CloseButton().Click();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
