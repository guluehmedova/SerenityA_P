using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace Smt.Default
{
    [ConnectionKey("Default"), Module("Default"), TableName("[brandcat].[BrandCategory]")]
    [DisplayName("Brand Category"), InstanceName("Brand Category")]
    [ReadPermission("BrandCategory")]
    [ModifyPermission("BrandCategory")]
    [LookupScript("Default.BrandCategory")]
    public sealed class BrandCategoryRow : Row<BrandCategoryRow.RowFields>, IIdRow
    {
        [DisplayName("Brand Category Id"), Identity, IdProperty]
        public int? BrandCategoryId
        {
            get => fields.BrandCategoryId[this];
            set => fields.BrandCategoryId[this] = value;
        }

        [DisplayName("Brand"), NotNull, ForeignKey("[brand].[Brand]", "BrandId"), LeftJoin("jBrand"), TextualField("BrandTitle")]
        public int? BrandId
        {
            get => fields.BrandId[this];
            set => fields.BrandId[this] = value;
        }

        [DisplayName("Category"), NotNull, ForeignKey("[cat].[Category]", "CategoryId"), LeftJoin("jCategory"), TextualField("CategoryTitle")]
        public int? CategoryId
        {
            get => fields.CategoryId[this];
            set => fields.CategoryId[this] = value;
        }

        [DisplayName("Brand Title"), Expression("jBrand.[Title]")]
        public string BrandTitle
        {
            get => fields.BrandTitle[this];
            set => fields.BrandTitle[this] = value;
        }

        [DisplayName("Brand Brand Image"), Expression("jBrand.[BrandImage]")]
        public string BrandBrandImage
        {
            get => fields.BrandBrandImage[this];
            set => fields.BrandBrandImage[this] = value;
        }

        [DisplayName("Category Title"), Expression("jCategory.[Title]")]
        public string CategoryTitle
        {
            get => fields.CategoryTitle[this];
            set => fields.CategoryTitle[this] = value;
        }

        public BrandCategoryRow()
            : base()
        {
        }

        public BrandCategoryRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field BrandCategoryId;
            public Int32Field BrandId;
            public Int32Field CategoryId;

            public StringField BrandTitle;
            public StringField BrandBrandImage;

            public StringField CategoryTitle;
        }
    }
}
