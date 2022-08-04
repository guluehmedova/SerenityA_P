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
        [EditLink]
        public string Title { get; set; }
        [DisplayName("Brands")]
        [Width(200), BrandListFormatter]
        public List<Int32> BrandList { get; set; }
    }
}