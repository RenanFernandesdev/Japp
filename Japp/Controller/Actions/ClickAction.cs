using OpenQA.Selenium;

namespace Japp.Controller.Actions
{
    internal class ClickAction : IActions
    {
        public override string Execute(params object[] obj)
        {
            string result = string.Empty;
            IWebElement element = (IWebElement) obj[1];
            
            element.Click();
            return result;
        }
    }
}
