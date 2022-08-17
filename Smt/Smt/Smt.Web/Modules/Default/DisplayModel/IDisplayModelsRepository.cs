using Microsoft.AspNetCore.Mvc;
using Smt.Default;
using Smt.Web.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Smt.Web.Modules.Default.DisplayModel
{
    public interface IDisplayModelsRepository
    {
        Task<DisplayModelsViewModel> GetModel();
    }
}
