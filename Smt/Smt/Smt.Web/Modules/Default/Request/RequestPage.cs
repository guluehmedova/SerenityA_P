using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace Smt.Default.Pages
{

    [PageAuthorize(typeof(RequestRow))]
    public class RequestController : Controller
    {
        [Route("Default/Request")]
        public ActionResult Index()
        {
            return View("~/Modules/Default/Request/RequestIndex.cshtml");
        }
    }
}