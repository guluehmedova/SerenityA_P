using Business.IService;
using Microsoft.AspNetCore.Mvc;
using Smt.Default;
using Smt.Web.Modules.Default.DisplayModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Service
{
    public class DisplayModels : IDisplayModels
    {
        private readonly IDisplayModelsRepository _displayModelsRepository;

        public DisplayModels(IDisplayModelsRepository displayModelsRepository)
        {
            _displayModelsRepository = displayModelsRepository;
        }
    }
}
