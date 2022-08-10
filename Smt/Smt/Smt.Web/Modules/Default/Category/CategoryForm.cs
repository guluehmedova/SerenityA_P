using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;
using Serenity.Data.Mapping;

namespace Smt.Default.Forms
{
    [FormScript("Default.Category")]
    [BasedOnRow(typeof(CategoryRow), CheckNames = true)]
    public class CategoryForm
    {
        public string Title { get; set; }
        public bool Check { get; set; }
        [DisplayName("Brands")]
        [Width(200), BrandListFormatter]
        [LinkingSetRelation(typeof(BrandCategoryRow), "CategoryId", "BrandId")]
        [LookupEditor(typeof(BrandRow), Multiple = true)]
        public List<Int32> BrandList { get; set; }
    }
}