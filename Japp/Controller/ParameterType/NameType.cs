using OpenQA.Selenium;
using Japp.Model;

namespace Japp.Controller.ParameterType
{
    internal class NameType : IParameterType
    {
        public override By SelectBy(IStep step)
        {
            return By.Name(step.GetParameter());
        }
    }
}
