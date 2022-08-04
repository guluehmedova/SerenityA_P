using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Smt.Default.Columns
{
    [ColumnsScript("Default.CommonFaq")]
    [BasedOnRow(typeof(CommonFaqRow), CheckNames = true)]
    public class CommonFaqColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int CommonFaqId { get; set; }
        [EditLink]
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}