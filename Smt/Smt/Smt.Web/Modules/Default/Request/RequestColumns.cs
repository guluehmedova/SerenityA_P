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
        [TextAreaEditor(Rows = 12), Width(200)]
        public string Text { get; set; }
        public DateTime CreationDate { get; set; }
        public string ModelTitle { get; set; }
        public string CategoryTitle { get; set; }
        public string BrandTitle { get; set; }
    }
}