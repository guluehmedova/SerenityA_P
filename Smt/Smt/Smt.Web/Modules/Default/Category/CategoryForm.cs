using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Smt.Default.Forms
{
    [FormScript("Default.Category")]
    [BasedOnRow(typeof(CategoryRow), CheckNames = true)]
    public class CategoryForm
    {
        public string Title { get; set; }
        [DisplayName("Brands")]
        public List<Int32> BrandList { get; set; } 
    }
}