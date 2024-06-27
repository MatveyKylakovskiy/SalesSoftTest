using OpenQA.Selenium;
using PageObjectLib.Elements;

namespace SalesSoftTest.Pages.CreateAccountInputFields
{
    internal class BaseField
    {
        protected string? inputFieldLocator { get; init; }
        private WebElements InputField() => new(By.XPath($"//*[text()='{inputFieldLocator}']/following-sibling::*"));

        public void InputDataToField(string data) => InputField().SendValue(data);
    }
}
