using CoreFramework.DriverCore;
using OpenQA.Selenium;

namespace testFramework.PageObject
{
    public class ManageAssetPage : WebDriverAction
    {
        public ManageAssetPage(IWebDriver driver) : base(driver)
        {
        }

        private readonly string btnCreateNewAsset = "//span[text()='Create new asset']";

        public void ClickCreate()
        {
            Click(btnCreateNewAsset);
        }
    }
}
