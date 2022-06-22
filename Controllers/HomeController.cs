using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Http;
using System.Web;

namespace MailServiceAPI.Controllers
{
    public class HomeController : Controller
    {
        public string Get()
        {
            return "Welcome to Web API";
        }

        public List<string> Get(int Id)
        {
            return new List<string>
            {
                "Data1",
                "Data2"
            };
        }
    }
}
