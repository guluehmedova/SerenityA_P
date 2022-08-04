using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace Smt.Default
{
    [ConnectionKey("Default"), Module("Default"), TableName("[cat].[Category]")]
    [DisplayName("Category"), InstanceName("Category")]
    [ReadPermission("Category")]
    [ModifyPermission("Category")]
    [LookupScript("Default.Category")]
    public sealed class CategoryRow : Row<CategoryRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Category Id"), Identity, IdProperty]
        public int? CategoryId
        {
            get => fields.CategoryId[this];
            set => fields.CategoryId[this] = value;
        }

        [DisplayName("Title"), Size(150), NotNull, QuickSearch, NameProperty]
        public string Title
        {
            get => fields.Title[this];
            set => fields.Title[this] = value;
        }

        public CategoryRow()
            : base()
        {
        }

        public CategoryRow(RowFields fields)
            : base(fields)
        {
        }
        [DisplayName("Brands")]
        [LookupEditor(typeof(BrandRow), Multiple = true), NotMapped]
        [LinkingSetRelation(typeof(BrandCategoryRow), "CategoryId", "BrandId")]
        public List<Int32> BrandList
        {
            get => fields.BrandList[this];
            set => fields.BrandList[this] = value;
        }
        public class RowFields : RowFieldsBase
        {
            public Int32Field CategoryId;
            public StringField Title;

            public ListField<Int32> BrandList;
        }
    }
}
