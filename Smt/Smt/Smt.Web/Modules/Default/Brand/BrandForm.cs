using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Smt.Default.Forms
{
    [FormScript("Default.Brand")]
    [BasedOnRow(typeof(BrandRow), CheckNames = true)]
    public class BrandForm
    {
        public string Title { get; set; }
        public string BrandImage { get; set; }
        public bool Check { get; set; }
        [DisplayName("Categories"), CategoryListFormatter]
        public List<Int32> CategoryList { get; set; }
    }
}