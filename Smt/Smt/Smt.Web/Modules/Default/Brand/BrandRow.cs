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
    [ConnectionKey("Default"), Module("Default"), TableName("[brand].[Brand]")]
    [DisplayName("Brand"), InstanceName("Brand")]
    [ReadPermission("Brand")]
    [ModifyPermission("Brand")]
    [LookupScript("Default.Brand")]
    public sealed class BrandRow : Row<BrandRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Brand Id"), Identity, IdProperty, Unique]
        public int? BrandId
        {
            get => fields.BrandId[this];
            set => fields.BrandId[this] = value;
        }

        [DisplayName("Title"), Size(150), NotNull, QuickSearch, NameProperty]
        public string Title
        {
            get => fields.Title[this];
            set => fields.Title[this] = value;
        }

        [DisplayName("Brand Image"), Size(250), NotNull, ImageUploadEditor(FilenameFormat = "Brand/BrandImage/~")]
        public string BrandImage
        {
            get => fields.BrandImage[this];
            set => fields.BrandImage[this] = value;
        }

        [DisplayName("Check"), NotNull]
        public bool? Check
        {
            get => fields.Check[this];
            set => fields.Check[this] = value;
        }

        public BrandRow()
            : base()
        {
        }

        public BrandRow(RowFields fields)
            : base(fields)
        {
        }
        [DisplayName("Categories")]
        [LookupEditor(typeof(CategoryRow), Multiple = true), NotMapped]
        [LinkingSetRelation(typeof(BrandCategoryRow), "BrandId", "CategoryId")]
        public List<Int32> CategoryList
        {
            get => fields.CategoryList[this];
            set => fields.CategoryList[this] = value;
        }
        [DisplayName("Requests")]
        [LookupEditor(typeof(RequestRow), Multiple = true), NotMapped]
        [LinkingSetRelation(typeof(RequestRow), "BrandId", "RequestId")]
        public List<Int32> RequestList
        {
            get => fields.RequestList[this];
            set => fields.RequestList[this] = value;
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field BrandId;
            public StringField Title;
            public StringField BrandImage;
            public BooleanField Check;

            public ListField<Int32> CategoryList;
            public ListField<Int32> RequestList;
        }
    }
}
