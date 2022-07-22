using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Japp.Model;

namespace Japp.Controller.ParameterType
{
    internal abstract class IParameterType
    {
        public Dictionary<string, IParameterType> IParameterTypeDict = new Dictionary<string, IParameterType>();
        
        public abstract By SelectBy(IStep step);

        public void Config()
        {
            IParameterTypeDict.Add("Id", new IdType());
            IParameterTypeDict.Add("Name", new NameType());
            IParameterTypeDict.Add("XPath", new XPathType());
        }
    }

    class ParameterBuild : IParameterType
    {
        public ParameterBuild()
        {
            Config();
        }

        public override By SelectBy(IStep step)
        {
            By by = IParameterTypeDict[step.GetParameterType()].SelectBy(step);
            return By.Id(step.GetParameter());
        }
    }
}
