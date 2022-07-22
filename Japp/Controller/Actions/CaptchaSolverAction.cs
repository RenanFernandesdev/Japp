using Japp.Model;
using OpenQA.Selenium;
using Japp.Util;

namespace Japp.Controller.Actions
{
    internal class CaptchaSolverAction : IActions
    {
        public override string Execute(params object[] obj)
        {
            IWebDriver driver = (IWebDriver)obj[0];
            IStep step = (IStep)obj[1];
            IWebElement element = ElementBuilder(driver, step);

            string link = element.GetAttribute("src");

            ImageServices services = new ImageServices(link);
            services.Download();
            Byte[] img = services.ImageToByte(services.GetImage());
            string result = services.Captcharesult(img);
            
            MessageBox.Show(result);

            return link;
        }
    }
}