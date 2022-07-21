using Japp.Model.Enums;
using OpenQA.Selenium;
using Japp.Controller.Actions;

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

        public string Execute()
        {
            //ElementBuilder();

            IActions actions = new ActionRun();
            actions.Execute(_driver, _element, _step);
            return _element.Text;
        }

        private void ElementBuilder()
        {
            Parameters parameterType = _step.GetParameterType();
            string parameter = _step.GetParameter();
            By _by;
            switch (parameterType)
            {
                case Parameters.XPath:
                    _by = By.XPath(parameter);
                    break;
                case Parameters.Id:
                    _by = By.Id(parameter);
                    break;
                case Parameters.Name:
                    _by = By.Name(parameter);
                    break;
                case Parameters.CssSelector:
                    _by = By.CssSelector(parameter);
                    break;
                default:
                    _by = null;
                    break;
            }
            if (_by != null)
            {
                _element = _driver.FindElement(_by);
            }
        }
        //Getters
        public IWebDriver GetDriver() { return _driver; }
        public IWebElement GetElement() { return _element; }

        //Setters
        public void SetDriver(IWebDriver driver) { _driver = driver; }
        public void SetElement(IWebElement element) { _element = element; }
    }
}
