namespace Japp.Controller.Actions
{
    internal class PressEnterAction : IActions
    {
        public override object Execute(params object[] obj)
        {
            string result = string.Empty;
            SendKeys.Send("{ENTER}");

            return result;
        }
    }
}
