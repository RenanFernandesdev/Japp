using Japp.Model;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Japp.Controller.Actions
{
    internal class RefreshAction : IActions
    {
        public override object Execute(params object[] obj)
        {
            string result = string.Empty;
            IWebDriver driver = (IWebDriver)obj[0];

            driver.Navigate().Refresh();

            return result;
        }
    }
}