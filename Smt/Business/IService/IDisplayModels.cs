using Microsoft.AspNetCore.Mvc;
using Smt.Default;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.IService
{
    public interface IDisplayModels
    {
        public ActionResult Display(ModelRow modelRow);
    }
}
