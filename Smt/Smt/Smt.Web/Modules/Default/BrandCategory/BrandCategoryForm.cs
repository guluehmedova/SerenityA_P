using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Smt.Default.Forms
{
    [FormScript("Default.BrandCategory")]
    [BasedOnRow(typeof(BrandCategoryRow), CheckNames = true)]
    public class BrandCategoryForm
    {
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
    }
}