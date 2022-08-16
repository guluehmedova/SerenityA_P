using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;
using Smt.Web.ViewModels;
using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using System.Linq;

namespace Smt.Default.Pages
{

    [PageAuthorize(typeof(DisplayModelRow))]
    public class DisplayModelController : Controller
    {
        [Route("Default/DisplayModel")]
        public ActionResult Index()
        {
            return View("~/Modules/Default/DisplayModel/DisplayModelIndex.cshtml");
        }
    }
}