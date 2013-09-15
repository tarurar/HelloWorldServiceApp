using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace HelloWorldService
{
    [ServiceContract]
    public interface IHelloWorldService
    {
        [OperationContract]
        [WebInvoke(
            Method = "GET", 
            ResponseFormat = WebMessageFormat.Json, 
            BodyStyle = WebMessageBodyStyle.Wrapped, 
            UriTemplate = "json/getHello/{name}")]
        String GetJsonData(String name);

        [OperationContract]
        [WebInvoke(
            Method = "GET", 
            ResponseFormat = WebMessageFormat.Xml, 
            BodyStyle = WebMessageBodyStyle.Wrapped, 
            UriTemplate = "xml/getHello/{name}")]
        String GetXmlData(String name);

    }
}
