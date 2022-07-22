using Japp.Model.Enums;
using OpenQA.Selenium;
using Japp.Controller.Actions;
using Japp.Controller.ParameterType;

namespace Japp.Model
{
    internal class StepBuilder
    {
        private IWebDriver _driver;
        private IWebElement? _element = null;
        private IStep _step;

        public StepBuilder(IWebDriver driver, IStep step)
        {
            _driver = driver;
            _step = step;
        }

        public object Execute()
        {
            IActions actions = new ActionRun();
            object result =  actions.Execute(_driver, _step);
            return result;
        }

        //Getters
        public IWebDriver GetDriver() { return _driver; }
        public IWebElement GetElement() { return _element; }

        //Setters
        public void SetDriver(IWebDriver driver) { _driver = driver; }
        public void SetElement(IWebElement element) { _element = element; }
    }
}
