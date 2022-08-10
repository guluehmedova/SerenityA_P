using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Smt.Default.Columns
{
    [ColumnsScript("Default.Brand")]
    [BasedOnRow(typeof(BrandRow), CheckNames = true)]
    public class BrandColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int BrandId { get; set; }
        [EditLink]
        [QuickFilter]
        public string Title { get; set; }
        public string BrandImage { get; set; }
        public bool Check { get; set; }
        [DisplayName("Categories")]
        [Width(200), CategoryListFormatter, QuickFilter]
        public List<Int32> CategoryList { get; set; }
        [DisplayName("Requests")]
        [Width(200), RequestListFormatter]
        public List<Int32> RequestList { get; set; }
    }
}