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
using Dapper;
using System.Data.SqlClient;

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
            using var connection = new SqlConnection(_configuration.GetConnectionString("SmtDefault"));
            var vendors = connection.Query<VendorRow>("SELECT * FROM vendor.Vendor");
            var models = connection.Query<ModelRow>("SELECT * FROM model.Model");

            DisplayModelsViewModel displayModelsViewModel = new DisplayModelsViewModel
            {
                Vendors = vendors.ToList(),
                Models = models.ToList()
            };

            return View("~/Modules/Default/DisplayModel/DisplayModelIndex.cshtml", displayModelsViewModel);
        }
        [HttpPut]
        public IActionResult Check(ModelRow modelrow)
        {
            using var connection = new SqlConnection(_configuration.GetConnectionString("SmtDefault"));
            var existmodels = connection.Query<ModelRow>("SELECT * FROM model.Model");

            var findmodel = existmodels.FirstOrDefault(x => x.ModelId == modelrow.ModelId);
            if (findmodel == null) { return NotFound(); }

            findmodel.Check = modelrow.Check;

            return View("index", findmodel);
        }
    }
}