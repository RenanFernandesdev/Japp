using Japp.Model;

namespace Japp.Controller.Actions
{
    internal abstract class IActions
    {
        public Dictionary<string, IActions> ActionsDict = new Dictionary<string, IActions>();
        // Driver | Elemento | Step
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
            IStep step = (IStep)obj[2];
            object result = ActionsDict[step.GetActions()].Execute(obj);
            return result;
        }
    }
}
