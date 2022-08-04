using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace Smt.Default
{
    [ConnectionKey("Default"), Module("Default"), TableName("[comfaq].[CommonFaq]")]
    [DisplayName("Common Faq"), InstanceName("Common Faq")]
    [ReadPermission("CommonFaq")]
    [ModifyPermission("CommonFaq")]
    public sealed class CommonFaqRow : Row<CommonFaqRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Common Faq Id"), Identity, IdProperty]
        public int? CommonFaqId
        {
            get => fields.CommonFaqId[this];
            set => fields.CommonFaqId[this] = value;
        }

        [DisplayName("Question"), Size(200), NotNull, QuickSearch, NameProperty]
        public string Question
        {
            get => fields.Question[this];
            set => fields.Question[this] = value;
        }

        [DisplayName("Answer"), Size(1000), NotNull]
        public string Answer
        {
            get => fields.Answer[this];
            set => fields.Answer[this] = value;
        }

        public CommonFaqRow()
            : base()
        {
        }

        public CommonFaqRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field CommonFaqId;
            public StringField Question;
            public StringField Answer;
        }
    }
}
