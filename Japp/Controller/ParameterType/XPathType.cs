using OpenQA.Selenium;
using Japp.Model;

namespace Japp.Controller.ParameterType
{
    internal class XPathType : IParameterType
    {
        public override By SelectBy(IStep step)
        {
            return By.XPath(step.GetParameter());
        }
    }
}