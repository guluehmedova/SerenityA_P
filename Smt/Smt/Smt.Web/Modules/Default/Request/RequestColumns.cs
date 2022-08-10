using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Smt.Default.Columns
{
    [ColumnsScript("Default.Request")]
    [BasedOnRow(typeof(RequestRow), CheckNames = true)]
    public class RequestColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int RequestId { get; set; }
        [EditLink]
        public string Theme { get; set; }
        public string RequestImages { get; set; }
        public bool ForwardedTo { get; set; }
        public Status Status { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
        public DateTime CreationDate { get; set; }
        [QuickFilter]
        public string ModelTitle { get; set; }
        [QuickFilter]
        public string CategoryTitle { get; set; }
        [QuickFilter]
        public string BrandTitle { get; set; }
    }
}