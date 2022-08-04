using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace Smt.Default.Pages
{

    [PageAuthorize(typeof(VendorRow))]
    public class VendorController : Controller
    {
        [Route("Default/Vendor")]
        public ActionResult Index()
        {
            return View("~/Modules/Default/Vendor/VendorIndex.cshtml");
        }
    }
}