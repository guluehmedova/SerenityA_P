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
    [ConnectionKey("Default"), Module("Default"), TableName("[model].[Model]")]
    [DisplayName("Model"), InstanceName("Model")]
    [ReadPermission("Model")]
    [ModifyPermission("Model")]
    [LookupScript("Default.Model")]
    public sealed class ModelRow : Row<ModelRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Model Id"), Identity, IdProperty]
        public int? ModelId
        {
            get => fields.ModelId[this];
            set => fields.ModelId[this] = value;
        }

        [DisplayName("Title"), Size(150), NotNull, QuickSearch, NameProperty]
        public string Title
        {
            get => fields.Title[this];
            set => fields.Title[this] = value;
        }

        [DisplayName("Code"), Size(100)]
        public string Code
        {
            get => fields.Code[this];
            set => fields.Code[this] = value;
        }

        [DisplayName("Model Image"), Size(250), NotNull, ImageUploadEditor(FilenameFormat = "Model/ModelImage/~")]
        public string ModelImage
        {
            get => fields.ModelImage[this];
            set => fields.ModelImage[this] = value;
        }

        [DisplayName("Category"), NotNull, ForeignKey("[cat].[Category]", "CategoryId"), LeftJoin("jCategory"), TextualField("CategoryTitle")]
        [LookupEditor("Default.Category")]
        public int? CategoryId
        {
            get => fields.CategoryId[this];
            set => fields.CategoryId[this] = value;
        }

        [DisplayName("Category Title"), Expression("jCategory.[Title]")]
        public string CategoryTitle
        {
            get => fields.CategoryTitle[this];
            set => fields.CategoryTitle[this] = value;
        }

        public ModelRow()
            : base()
        {
        }

        public ModelRow(RowFields fields)
            : base(fields)
        {
        }
        public class RowFields : RowFieldsBase
        {
            public Int32Field ModelId;
            public StringField Title;
            public StringField Code;
            public StringField ModelImage;
            public Int32Field CategoryId;

            public StringField CategoryTitle;
        }
    }
}
