﻿using SeleniumFramework;
using SeleniumFramework.Pages;
using SeleniumFramework.Pages.DJIStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages.DJIStore
{
    public class AccountDJILoginPage
    {
        public static void Open()
        {
            Driver.OpenPage("https://account.dji.com/login");
        }
        public static void EnterEmail(string email)
        {
            Common.SendKeys(Locators.StoreDJIFrontPage.emailInputField, email);
        }

        public static void ClickLogIn()
        {
           Common.Click(Locators.StoreDJIFrontPage.logInButton);
        }

        public static string GetPasswordCannotBeEmpyText()
        {
            return Common.GetElementText(Locators.StoreDJIFrontPage.passwordCanNotBeEmptyMessage);
        }

        public static void EnterPassword(string keys)
        {
            Common.SendKeys(Locators.StoreDJIFrontPage.passwordInputField, keys);
        }

        public static string GetFollowTheProptsToCompleteText()
        {
            return Common.GetElementText(Locators.StoreDJIFrontPage.followThePromptsToCompleteMessage);
        }

        public static bool WaitForPasswordCannotBeEmptyBeVisible()
        {
            return Common.WaitForElementToBeEnabled(Locators.StoreDJIFrontPage.passwordCanNotBeEmptyMessage);
        }

        public static bool WaitYourEmailIsIncorrectTextBeVisible()
        {
            return Common.WaitForElementToBeEnabled(Locators.StoreDJIFrontPage.followThePromptsToCompleteMessage);
        }

        public static bool WaitForAcceptAllButtonBeEnabled()
        {
            return Common.WaitForElementToBeVisible(Locators.StoreDJIFrontPage.cookyAcceptAllButton);
        }

        public static void ClickAcceptAllButton()
        {
            Common.Click(Locators.StoreDJIFrontPage.cookyAcceptAllButton);
        }

        public static void Wait()
        {
            Task.Run(async () => await Common.Wait()).Wait(); 
        }

        public static void ClickRecapcha()
        {
            Common.ClickElements(Locators.StoreDJIFrontPage.reCaptcha);
        }

        public static bool WaitTillRecapchaBeActive()
        {
           return Common.WaitForElementToBeEnabled(Locators.StoreDJIFrontPage.reCaptcha);
        }
    }
}
