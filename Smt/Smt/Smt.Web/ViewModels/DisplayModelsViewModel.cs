using Smt.Default;
using Smt.Default.Columns;
using System.Collections.Generic;

namespace Smt.Web.ViewModels
{
    public class DisplayModelsViewModel
    {
        public List<VendorRow> Vendors { get; set; }
        public List<ModelRow> Models { get; set; }
    }
}
