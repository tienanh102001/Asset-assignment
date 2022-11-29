using NUnit.Framework;
using NUnit.Framework.Internal;
using testFramework.Common;
using testFramework.PageObject;
using testFramework.TestSetup;

namespace testFramework.Testcases
{
    [TestFixture]
    public class LoginTest : ProjectNUnitTestSetup
    {
        //[TestCase("vangdv", "vangdv@01011990")]
        //[TestCase("tuandv", "tuandv@01011990")]
        //[TestCase("quynhct", "quynhct@01011990")]
        

        [Test]
        public void LoginSuccess()
        {
            CommonFlow commonFlow = new CommonFlow();
            commonFlow.CMUserLogin(_driver);
            Assert.AreEqual(Constant.HOME_URL, Constant.BASE_URL + "home");
        }

        [Test]
        public void ChangePassword()
        {
            CommonFlow commonFlow = new CommonFlow();
            HomePage homePage = new HomePage(_driver);

            commonFlow.CMUserLogin(_driver);
            homePage.ChangePassword("v@01011990");

            
        }
        [Test]
        public void LogOut()
        {
            CommonFlow commonFlow = new CommonFlow();
            HomePage menuHeader = new HomePage(_driver);

            commonFlow.CMUserLogin(_driver);
            menuHeader.Logout();
        }
    }
}
