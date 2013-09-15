using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldService
{
    public class HelloWorldService: IHelloWorldService
    {
        private static String GetMessage(String name)
        {
            return "Hello World from " + name + "!";
        }

        public string GetJsonData(string name)
        {
            return GetMessage(name);
        }

        public string GetXmlData(string name)
        {
            return GetMessage(name);
        }
    }
}
