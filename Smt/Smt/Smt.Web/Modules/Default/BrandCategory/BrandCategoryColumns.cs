using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Smt.Default.Columns
{
    [ColumnsScript("Default.BrandCategory")]
    [BasedOnRow(typeof(BrandCategoryRow), CheckNames = true)]
    public class BrandCategoryColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int BrandCategoryId { get; set; }
        public string BrandTitle { get; set; }
        public string CategoryTitle { get; set; }
    }
}