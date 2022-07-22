using OpenQA.Selenium;
using Japp.Model;

namespace Japp.Controller.ParameterType
{
    internal class IdType : IParameterType
    {
        public override By SelectBy(IStep  step)
        {
            return By.Id(step.GetParameter());
        }
    }
}
