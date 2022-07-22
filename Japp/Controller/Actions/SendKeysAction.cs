using Japp.Model;
using OpenQA.Selenium;

namespace Japp.Controller.Actions
{
    internal class SendKeysAction : IActions
    {
        public override string Execute(params object[] obj)
        {
            string result = string.Empty;
            IWebDriver driver = (IWebDriver)obj[0];
            IStep step = (IStep)obj[1];
            IWebElement element = ElementBuilder(driver, step);
            string parameter = step.GetText();

            element.SendKeys(parameter);
            return result;
        }
    }
}
