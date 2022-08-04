using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace Smt.Default.Pages
{

    [PageAuthorize(typeof(CommonFaqRow))]
    public class CommonFaqController : Controller
    {
        [Route("Default/CommonFaq")]
        public ActionResult Index()
        {
            return View("~/Modules/Default/CommonFaq/CommonFaqIndex.cshtml");
        }
    }
}