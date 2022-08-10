using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Smt.Default.Columns
{
    [ColumnsScript("Default.Category")]
    [BasedOnRow(typeof(CategoryRow), CheckNames = true)]
    public class CategoryColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int CategoryId { get; set; }
        [EditLink, QuickFilter]
        public string Title { get; set; }
        public bool Check { get; set; }
        [DisplayName("Brands")]
        [Width(200), BrandListFormatter, QuickFilter]
        public List<Int32> BrandList { get; set; }
        [Width(200), RequestListFormatter]
        [DisplayName("Requests")]
        public List<Int32> RequestList { get; set; }
        [DisplayName("Models")]
        [Width(200), ModelListFormatter]
        public List<Int32> ModelList { get; set; }
    }
}