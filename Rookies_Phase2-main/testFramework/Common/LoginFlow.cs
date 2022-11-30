using CoreFramework.NUnitTestSetup;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testFramework.PageObject;
using testFramework.TestSetup;

namespace testFramework.Common
{
    public class LoginFlow
    {
        public void CMUserLogin(IWebDriver _driver)
        {
            LoginPage loginPage = new LoginPage(_driver);
            loginPage.InputUserName(Constant.UserID1);
            loginPage.InputPassword(Constant.PassID1);
            loginPage.ClickLogin();
        }

        
    }
}
