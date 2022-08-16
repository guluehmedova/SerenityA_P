using Business.IService;
using Microsoft.AspNetCore.Mvc;
using Smt.Default;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Service
{
    public class DisplayModel : IDisplayModel
    {
        public Task<ActionResult> GetConnect(ModelRow modelrow)
        {
            throw new NotImplementedException();
        }
    }
}
