using OpenQA.Selenium;

namespace Japp.Controller.Actions
{
    internal class DisplayedAction : IActions
    {
        public override object Execute(params object[] obj)
        {
            bool result;
            IWebElement element = (IWebElement)obj[1];

            result = element.Displayed ? true : false;

            return result;
        }
    }
}
