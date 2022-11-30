using CoreFramework.DriverCore;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testFramework.PageObject
{
    public class HomePage : WebDriverAction
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        private readonly string btnMenu = "//li[@role='none']";

        private readonly string btnChangePass = "//div[contains(@style,'position')]//li[1]";
        private readonly string boxCurrentPass = "//input[@id='change-password_oldPassword']";
        private readonly string boxNewPass = "//input[@id='change-password_newPassword']";
        private readonly string btnSave = "//button[@class='ant-btn ant-btn-primary ant-btn-dangerous']";
        private readonly string btnCancel = "//button[@class='ant-btn ant-btn-default']";

        private readonly string btnLogout = "//div[contains(@style, 'position')]//li[2]";
        private readonly string btnConfirmLog = "//span[text()='Log out']";
        private readonly string btnCancelLog = "//span[text()='Cancel']";

        private readonly string oldPass = "vangdv@01011990";
        public void ChangePassword(string newPass)
        {
            Click(btnMenu);
            Click(btnChangePass);
            SendKeys_(boxOldPass, oldPass);
            SendKeys_(boxNewPass, newPass);
            Click(btnSaveChange);
        }
        public void CancelChangePassword()
        {
            Click(btnMenu);
            Click(btnChangePass);
            Click(btnCancelChange);
        }
        public void Logout()
        {
            Click(btnMenu);
            Click(btnLogout);
            Click(btnConfirmLog);
        }
        public void CancelLogout()
        {
            Click(btnMenu);
            Click(btnLogout);
            Click(btnCancelLog);
        }
    }
}
