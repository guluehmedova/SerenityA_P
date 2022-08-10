using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Smt.Default.Columns
{
    [ColumnsScript("Default.Model")]
    [BasedOnRow(typeof(ModelRow), CheckNames = true)]
    public class ModelColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int ModelId { get; set; }
        [EditLink]
        public string Title { get; set; }
        [QuickFilter]
        public string Code { get; set; }
        public string ModelImage { get; set; }
        public string CategoryTitle { get; set; }
        public bool Check { get; set; }
        [DisplayName("Requests")]
        [Width(200), RequestListFormatter]
        public List<Int32> RequestList { get; set; }
    }
}