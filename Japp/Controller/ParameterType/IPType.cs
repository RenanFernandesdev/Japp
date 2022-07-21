using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Japp.Model;

namespace Japp.Controller.ParameterType
{
    internal abstract class IPType
    {
        public Dictionary<string, IPType> IParameterTypeDict = new Dictionary<string, IPType>();
        
        public abstract By SelectBy(IStep step);

        public void Config()
        {

        }
    }
}
