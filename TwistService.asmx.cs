using System.Web.Services;

namespace TestWebService
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class TwistService : WebService
    {
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
		
		[WebMethod]
        public string GetMessage(string name)
        {
            return HelloWorld() + name;
        }
    }
}