using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Japp.Model.Enums;
using OpenQA.Selenium;

namespace Japp.Model
{
    internal class StepBuilder
    {
        private IWebDriver _driver;
        private IWebElement _element;
        private IStep _step;

        public StepBuilder(IWebDriver driver, IStep step)
        {
            _driver = driver;
            _step = step;
        }

        public void ExecuteVoid()
        {
            ElementBuilder();
            Actions action = _step.GetActions();
            switch (action)
            {
                case Actions.Click:
                    _element.Click();
                    break;
                case Actions.Clear:
                    _element.Clear();
                    break;
                case Actions.Sleep:
                    Thread.Sleep(_step.GetTime());
                    break;
                case Actions.SendKeys:
                    _element.SendKeys(_step.GetText());
                    break;
                case Actions.Navigate:
                    _driver.Navigate().GoToUrl(_step.GetParameter());
                    break;
            }
        }
        public string ExecuteString()
        {
            ElementBuilder();
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
