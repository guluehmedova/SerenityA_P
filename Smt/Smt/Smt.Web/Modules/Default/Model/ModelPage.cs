using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace Smt.Default.Pages
{

    [PageAuthorize(typeof(ModelRow))]
    public class ModelController : Controller
    {
        [Route("Default/Model")]
        public ActionResult Index()
        {
            return View("~/Modules/Default/Model/ModelIndex.cshtml");
        }
    }
}