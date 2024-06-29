

using NUnit.Framework.Internal;
using OpenQA.Selenium;
using PageObjectLib.Elements;
using PageObjectLib.Factories;

namespace SalesSoftTest.Pages.InputFields.CreateContactInputFields
{
    internal class AccountNameField : BaseField
    {
        private WebElements InputField() => new(By.XPath($"//*[text()='{inputFieldLocator}']/following-sibling::*/child::*"));

        public AccountNameField()
        {
            inputFieldLocator = "Account Name";
        }
        private static WebElements SelectAccount(string accountName) => new(By.XPath($"//span[@class='slds-truncate' and text()='{accountName}']"));

        public void InputDataToField(string accountName)
        {
            InputField().Click();
            SelectAccount(accountName).Click();
        }
    }
}
