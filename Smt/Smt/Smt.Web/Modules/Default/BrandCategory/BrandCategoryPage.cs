using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace Smt.Default.Pages
{

    [PageAuthorize(typeof(BrandCategoryRow))]
    public class BrandCategoryController : Controller
    {
        [Route("Default/BrandCategory")]
        public ActionResult Index()
        {
            return View("~/Modules/Default/BrandCategory/BrandCategoryIndex.cshtml");
        }
    }
}