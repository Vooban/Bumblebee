﻿using System;
using Bumblebee.Setup;
using OpenQA.Selenium;
using OpenQA.Selenium.PhantomJS;

namespace Bumblebee.IntegrationTests.Shared.DriverEnvironments
{
    public class LocalPhantomEnvironment : IDriverEnvironment
    {
        public IWebDriver CreateWebDriver()
        {
            var driver = new PhantomJSDriver();
            driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(5));
            driver.Manage().Window.Maximize();
            return driver;
        }
    }
}