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
using Smt.Web.Modules.Default.DisplayModel;
using System.Threading.Tasks;

namespace Smt.Default.Pages
{

    [PageAuthorize(typeof(DisplayModelRow))]
    public class DisplayModelController : Controller
    {
        private readonly IDisplayModelsRepository _displayModelsRepository;

        public DisplayModelController(IDisplayModelsRepository displayModelsRepository)
        {
            _displayModelsRepository = displayModelsRepository;
        }

        [Route("Default/DisplayModel")]
        public ActionResult Index()
        {
            var models = _displayModelsRepository.GetModel();
            return View("~/Modules/Default/DisplayModel/DisplayModelIndex.cshtml", models);
        }
    }
}