using OpenQA.Selenium;
using Japp.Model;

namespace Japp.Controller.Actions
{
    internal class NavigateAction : IActions
    {
        public override object Execute(params object[] obj)
        {
            string result = string.Empty;
            IStep parametro = (IStep)obj[2];
            IWebDriver driver = (IWebDriver)obj[0];

            driver.Navigate().GoToUrl(parametro.GetParameter());

            return result;
        }
    }
}
