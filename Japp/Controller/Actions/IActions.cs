using Japp.Controller.ParameterType;
using Japp.Model;
using OpenQA.Selenium;

namespace Japp.Controller.Actions
{
    internal abstract class IActions
    {
        public Dictionary<string, IActions> ActionsDict = new Dictionary<string, IActions>();
        // Driver | Step
        public abstract object Execute(params object[] obj);

        public void Config()
        {
            ActionsDict.Add("Click", new ClickAction());
            ActionsDict.Add("Clear", new ClearAction());
            ActionsDict.Add("SendKeys", new SendKeysAction());
            ActionsDict.Add("Displayed", new DisplayedAction());
            ActionsDict.Add("Navigate", new NavigateAction());
            ActionsDict.Add("Sleep", new SleepAction());
            ActionsDict.Add("PressEnter", new PressEnterAction());
            ActionsDict.Add("Refresh", new RefreshAction());
            ActionsDict.Add("GetText", new GetTextAction());
            ActionsDict.Add("CaptchaSolve", new CaptchaSolverAction());
        }

        public IWebElement ElementBuilder(IWebDriver driver ,IStep step)
        {
            IParameterType parameterType = new ParameterBuild();
            By by = parameterType.IParameterTypeDict[step.GetParameterType()].SelectBy(step);
            return driver.FindElement(by);
        }
    }

    class ActionRun : IActions
    {
        public ActionRun()
        {
            Config();
        }

        public override object Execute(params object[] obj)
        {
            IStep step = (IStep)obj[1];
            object result = ActionsDict[step.GetActions()].Execute(obj);
            return result;
        }
    }
}
