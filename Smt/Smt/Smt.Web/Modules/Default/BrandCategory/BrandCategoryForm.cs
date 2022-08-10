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
        [DisplayName("Brand")]
        public int BrandId { get; set; }
        [DisplayName("Category")]
        public int CategoryId { get; set; }
    }
}