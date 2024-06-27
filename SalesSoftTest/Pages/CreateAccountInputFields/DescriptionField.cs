
using OpenQA.Selenium;
using PageObjectLib.Elements;

namespace SalesSoftTest.Pages.CreateAccountInputFields
{
    internal class DescriptionField : BaseField
    {
        public DescriptionField()
        {
            inputFieldLocator = "Description";
        }
    }
}
