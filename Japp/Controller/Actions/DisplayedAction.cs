﻿using Japp.Model;
using OpenQA.Selenium;

namespace Japp.Controller.Actions
{
    internal class DisplayedAction : IActions
    {
        public override object Execute(params object[] obj)
        {
            bool result;
            IWebDriver driver = (IWebDriver)obj[0];
            IStep step = (IStep)obj[1];
            IWebElement element = ElementBuilder(driver, step);

            result = element.Displayed ? true : false;

            return result;
        }
    }
}
