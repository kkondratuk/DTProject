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
            return "Welcome World";
        }
    }
}