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
        public string Title { get; set; }
        [DisplayName("Image")]
        public string BrandImage { get; set; }
        [Width(200), CategoryListFormatter]
        public List<Int32> CategoryList { get; set; }
    }
}