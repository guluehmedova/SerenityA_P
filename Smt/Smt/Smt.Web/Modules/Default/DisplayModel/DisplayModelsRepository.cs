using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Smt.Default;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using System.Collections.Generic;
using Smt.Web.ViewModels;
using System.Linq;

namespace Smt.Web.Modules.Default.DisplayModel
{
    public class DisplayModelsRepository : IDisplayModelsRepository
    {
        private readonly IConfiguration _configuration;

        public DisplayModelsRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<DisplayModelsViewModel> GetModel()
        {
            List<VendorRow> vendors;

            string cmd = @"SELECT  V.* FROM vendor.Vendor V
            JOIN dModel.DisplayModel DM ON V.VendorId = DM.VendorId
            JOIN model.Model M ON DM.ModelId = M.ModelId";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("SmtDefault")))
            {
                vendors = (await connection.QueryAsync<VendorRow>(cmd)).ToList();
            }

            DisplayModelsViewModel displayModelsViewModel = new DisplayModelsViewModel
            {
                Vendors = vendors
            };

            return displayModelsViewModel;
        }
    }
}
