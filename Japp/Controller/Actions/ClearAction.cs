using OpenQA.Selenium;

namespace Japp.Controller.Actions
{
    internal class ClearAction : IActions
    {
        public override string Execute(params object[] obj)
        {
            string result = string.Empty;
            IWebElement element = (IWebElement)obj[1];

            element.Clear();
            return result;
        }
    }
}
