using Japp.Model;

namespace Japp.Controller.Actions
{
    internal class SleepAction : IActions
    {
        public override object Execute(params object[] obj)
        {
            string result = string.Empty;
            IStep parametro = (IStep)obj[1];
            Thread.Sleep(parametro.GetTime());

            return result;
        }
    }
}
