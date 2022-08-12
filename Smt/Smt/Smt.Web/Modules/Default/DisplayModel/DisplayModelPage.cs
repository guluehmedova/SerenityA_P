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
        private readonly IConfiguration _configuration;
        public DisplayModelController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        
        [Route("Default/DisplayModel")]
        public ActionResult Index()
        {
            using var connection = new SqlConnection(_configuration.GetConnectionString("Data"));
            var vendors = connection.Query<VendorRow>("select * from vendor.Vendor");

            DisplayModelsViewModel displayVM = new DisplayModelsViewModel
            {
                Vendors = vendors.ToList()
            };
            return View("~/Modules/Default/DisplayModel/DisplayModelIndex.cshtml", displayVM);
        }
    }
}