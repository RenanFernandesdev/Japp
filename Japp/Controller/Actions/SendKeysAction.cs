using OpenQA.Selenium;

namespace Japp.Controller.Actions
{
    internal class SendKeysAction : IActions
    {
        public override string Execute(params object[] obj)
        {
            string result = string.Empty;
            IWebElement element = (IWebElement)obj[0];
            string parameter = (string) obj[1];

            element.SendKeys(parameter);
            return result;
        }
    }
}
