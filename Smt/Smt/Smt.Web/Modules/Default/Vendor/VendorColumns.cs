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
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Name { get; set; }
        public string UserImage { get; set; }
    }
}