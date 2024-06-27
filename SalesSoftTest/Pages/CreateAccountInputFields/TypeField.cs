
using OpenQA.Selenium;
using PageObjectLib.Elements;

namespace SalesSoftTest.Pages.CreateAccountInputFields
{
    internal class TypeField : BaseField
    {
        private WebElements InputField() => new(By.XPath($"//*[text()='{inputFieldLocator}']/following-sibling::*/child::*"));
        private static WebElements TypeOfOptions(string type) => new(By.XPath($"//*[@role='option' and @data-value='{type}']"));
        public TypeField()
        {
            inputFieldLocator = "Type";
        }


        public void InputDataToField(string type)
        {
            InputField().Click();
            TypeOfOptions(type).Click();
        }


    }
}
