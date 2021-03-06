﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    public class NavigationHelper : HelperBase
    {
        private string baseURL;

        public NavigationHelper(ApplicationManager manager, string baseURl) : base(manager)
        {
            this.baseURL = baseURl;
        }

        public void GoToGroupsPage()
        {
            if (driver.Url == baseURL+"group.php"
                && IsElementPresent(By.Name("new")))
            {
                return;
            }
            driver.Navigate().GoToUrl(baseURL + "group.php");
        }

        public void GoToHomePage()
        {
            if (driver.Url == baseURL)
            {
                return;
            }
            driver.Navigate().GoToUrl(baseURL);
        }
    }
}
