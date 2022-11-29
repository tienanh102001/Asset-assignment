using AventStack.ExtentReports;
using CoreFramework.DriverCore;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testFramework.PageObject
{
    public class LoginPage : WebDriverAction
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        private readonly string boxUserName = "//input[@id='login_username']";
        private readonly string boxPassword = "//input[@id='login_password']";
        private readonly string buttonLogin = "//button[@type='submit']";

        private readonly string btnMenu = "//span[@class='ant-menu-title-content']";
        private readonly string btnChangePass = "//a[text()='Change Password']";

        public void ClickMenu()
        {
            Click(btnMenu);
        }

        public void ClickChangePassword()
        {
            Click(btnChangePass);
        }

        public void InputUserName(string username)
        {
            SendKeys_(boxUserName, username);
        }
        public void InputPassword(string password)
        {
            SendKeys_(boxPassword, password);
        }
        public void ClickLogin()
        {
            Click(buttonLogin);
        }
        

    }
}
