using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Smt.Default.Columns
{
    [ColumnsScript("Default.DisplayModel")]
    [BasedOnRow(typeof(DisplayModelRow), CheckNames = true)]
    public class DisplayModelColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int DisplayModelId { get; set; }
        public string ModelTitle { get; set; }
        public string VendorUserName { get; set; }
    }
}