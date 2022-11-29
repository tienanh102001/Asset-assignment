using NUnit.Framework;
using OpenQA.Selenium;
using testFramework.Common;
using testFramework.PageObject;
using testFramework.TestSetup;

namespace testFramework.Testcases
{
    [TestFixture]
    public class MangageAssetsTest : ProjectNUnitTestSetup
    {
        [Test]
        public void CreateNewAsset()
        {
            CommonFlow commonFlow = new CommonFlow();
            commonFlow.CMUserLogin(_driver);

            MenuLeft menuLeft = new MenuLeft(_driver);
            menuLeft.ClickManageAsset();

            ManageAssetPage manageAssetPage = new ManageAssetPage(_driver);
            manageAssetPage.ClickCreate();
        }

    }
}
