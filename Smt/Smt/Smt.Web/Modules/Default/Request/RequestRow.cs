using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace Smt.Default
{
    [ConnectionKey("Default"), Module("Default"), TableName("[request].[Request]")]
    [DisplayName("Request"), InstanceName("Request")]
    [ReadPermission("Request")]
    [ModifyPermission("Request")]
    [LookupScript("Default.Request")]
    public sealed class RequestRow : Row<RequestRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Request Id"), Identity, IdProperty]
        public int? RequestId
        {
            get => fields.RequestId[this];
            set => fields.RequestId[this] = value;
        }

        [DisplayName("Theme"), Size(150), NotNull, QuickSearch, NameProperty]
        public string Theme
        {
            get => fields.Theme[this];
            set => fields.Theme[this] = value;
        }

        [DisplayName("Images"), Size(250), NotNull, MultipleImageUploadEditor(FilenameFormat = "Request/RequestImages/~")]
        public string RequestImages
        {
            get => fields.RequestImages[this];
            set => fields.RequestImages[this] = value;
        }

        [DisplayName("Forwarded To")]
        public bool? ForwardedTo
        {
            get => fields.ForwardedTo[this];
            set => fields.ForwardedTo[this] = value;
        }

        [DisplayName("Status"), NotNull, DefaultValue(1)]
        public Status? Status
        {
            get => (Status?)fields.Status[this];
            set => fields.Status[this] = (Int32?)value;
        }

        [DisplayName("Date")]
        public DateTime? Date
        {
            get => fields.Date[this];
            set => fields.Date[this] = value;
        }

        [DisplayName("Text"), Size(1000), NotNull]
        public string Text
        {
            get => fields.Text[this];
            set => fields.Text[this] = value;
        }

        [DisplayName("Creation Date"), NotNull]
        public DateTime? CreationDate
        {
            get => fields.CreationDate[this];
            set => fields.CreationDate[this] = value;
        }

        [DisplayName("Model"), NotNull, ForeignKey("[model].[Model]", "ModelId"), LeftJoin("jModel"), TextualField("ModelTitle")]
        [LookupEditor(typeof(ModelRow), InplaceAdd = true)]
        public int? ModelId
        {
            get => fields.ModelId[this];
            set => fields.ModelId[this] = value;
        }

        [DisplayName("Category"), NotNull, ForeignKey("[cat].[Category]", "CategoryId"), LeftJoin("jCategory"), TextualField("CategoryTitle")]
        [LookupEditor(typeof(CategoryRow), InplaceAdd = true)]
        public int? CategoryId
        {
            get => fields.CategoryId[this];
            set => fields.CategoryId[this] = value;
        }

        [DisplayName("Brand"), NotNull, ForeignKey("[brand].[Brand]", "BrandId"), LeftJoin("jBrand"), TextualField("BrandTitle")]
        [LookupEditor(typeof(BrandRow), InplaceAdd = true)]
        public int? BrandId
        {
            get => fields.BrandId[this];
            set => fields.BrandId[this] = value;
        }

        [DisplayName("Model Title"), Expression("jModel.[Title]")]
        public string ModelTitle
        {
            get => fields.ModelTitle[this];
            set => fields.ModelTitle[this] = value;
        }

        [DisplayName("Model Code"), Expression("jModel.[Code]")]
        public string ModelCode
        {
            get => fields.ModelCode[this];
            set => fields.ModelCode[this] = value;
        }

        [DisplayName("Model Model Image"), Expression("jModel.[ModelImage]")]
        public string ModelModelImage
        {
            get => fields.ModelModelImage[this];
            set => fields.ModelModelImage[this] = value;
        }

        [DisplayName("Model Category Id"), Expression("jModel.[CategoryId]")]
        public int? ModelCategoryId
        {
            get => fields.ModelCategoryId[this];
            set => fields.ModelCategoryId[this] = value;
        }

        [DisplayName("Category Title"), Expression("jCategory.[Title]")]
        public string CategoryTitle
        {
            get => fields.CategoryTitle[this];
            set => fields.CategoryTitle[this] = value;
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

        public RequestRow()
            : base()
        {
        }

        public RequestRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field RequestId;
            public StringField Theme;
            public StringField RequestImages;
            public BooleanField ForwardedTo;
            public Int32Field Status;
            public DateTimeField Date;
            public StringField Text;
            public DateTimeField CreationDate;
            public Int32Field ModelId;
            public Int32Field CategoryId;
            public Int32Field BrandId;

            public StringField ModelTitle;
            public StringField ModelCode;
            public StringField ModelModelImage;
            public Int32Field ModelCategoryId;

            public StringField CategoryTitle;

            public StringField BrandTitle;
            public StringField BrandBrandImage;
        }
    }
}
