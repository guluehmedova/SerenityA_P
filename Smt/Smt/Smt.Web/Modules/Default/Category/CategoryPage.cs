using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace Smt.Default.Pages
{

    [PageAuthorize(typeof(CategoryRow))]
    public class CategoryController : Controller
    {
        [Route("Default/Category")]
        public ActionResult Index()
        {
            return View("~/Modules/Default/Category/CategoryIndex.cshtml");
        }
    }
}