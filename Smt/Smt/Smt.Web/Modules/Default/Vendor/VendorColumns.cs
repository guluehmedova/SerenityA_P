using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Smt.Default.Columns
{
    [ColumnsScript("Default.Vendor")]
    [BasedOnRow(typeof(VendorRow), CheckNames = true)]
    public class VendorColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int VendorId { get; set; }
        [EditLink]
        [QuickFilter]
        public string UserName { get; set; }
        [QuickFilter]
        public string Email { get; set; }
        public string Password { get; set; }
        [QuickFilter]
        public string Name { get; set; }
        public string UserImage { get; set; }
        [Width(200), ModelListFormatter]
        public List<Int32> ModelList { get; set; }
    }
}