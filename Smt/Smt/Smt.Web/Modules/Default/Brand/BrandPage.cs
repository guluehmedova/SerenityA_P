using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace Smt.Default.Pages
{

    [PageAuthorize(typeof(BrandRow))]
    public class BrandController : Controller
    {
        [Route("Default/Brand")]
        public ActionResult Index()
        {
            return View("~/Modules/Default/Brand/BrandIndex.cshtml");
        }
    }
}