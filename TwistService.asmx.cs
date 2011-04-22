using System.Web.Services;

namespace TestWebService
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class TwistService : WebService
    {
        [WebMethod]
        public string WelcomeWorld()
        {
            return "Welcome World";
        }
		
		[WebMethod]
        public string GetMessage(string name)
        {
            return HelloWorld() + name;
        }
		
		[WebMethod]
        public string GetCustomMessage(string message, string name)
        {
            return message + name;
        }
    }
}