using CoreFramework.DriverCore;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testFramework.PageObject
{
    public class MenuLeft : WebDriverAction
    {
        public MenuLeft(IWebDriver driver) : base(driver)
        {
        }
        private readonly string btnHome = "//a[@href='/home']";
        private readonly string btnM_Users = "//a[@href='/manage-users']";
        private readonly string btnM_Assets = "//a[@href='/manage-assets']";
        private readonly string btnM_Assignments = "//a[@href='/manage-assignments']";
        private readonly string btnRequest_Return = "//a[@href='/request-for-returning']";
        private readonly string btnReport = "//a[@href='/report']";

        public void ClickHome()
        {
            Click(btnHome);
        }
        public void ClickManageAsset()
        {
            Click(btnM_Assets);
        }
        public void ClickManageAssi()
        {
            Click(btnM_Assignments);
        }
        public void ClickManageUser()
        {
            Click(btnM_Users);
        }
        public void ClickRequest()
        {
            Click(btnRequest_Return);
        }
        public void ClickReport()
        {
            Click(btnReport);
        }
    }
}
