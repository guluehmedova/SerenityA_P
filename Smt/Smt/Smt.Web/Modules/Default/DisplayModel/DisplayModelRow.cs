using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace Smt.Default
{
    [ConnectionKey("Default"), Module("Default"), TableName("[dModel].[DisplayModel]")]
    [DisplayName("Display Model"), InstanceName("Display Model")]
    [ReadPermission("DisplayModel")]
    [ModifyPermission("DisplayModel")]
    public sealed class DisplayModelRow : Row<DisplayModelRow.RowFields>, IIdRow
    {
        [DisplayName("Display Model Id"), Identity, IdProperty]
        public int? DisplayModelId
        {
            get => fields.DisplayModelId[this];
            set => fields.DisplayModelId[this] = value;
        }

        [DisplayName("Model"), NotNull, ForeignKey("[model].[Model]", "ModelId"), LeftJoin("jModel"), TextualField("ModelTitle")]
        public int? ModelId
        {
            get => fields.ModelId[this];
            set => fields.ModelId[this] = value;
        }

        [DisplayName("Vendor"), NotNull, ForeignKey("[vendor].[Vendor]", "VendorId"), LeftJoin("jVendor"), TextualField("VendorUserName")]
        public int? VendorId
        {
            get => fields.VendorId[this];
            set => fields.VendorId[this] = value;
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

        [DisplayName("Model Check"), Expression("jModel.[Check]")]
        public bool? ModelCheck
        {
            get => fields.ModelCheck[this];
            set => fields.ModelCheck[this] = value;
        }

        [DisplayName("Vendor User Name"), Expression("jVendor.[UserName]")]
        public string VendorUserName
        {
            get => fields.VendorUserName[this];
            set => fields.VendorUserName[this] = value;
        }

        [DisplayName("Vendor Email"), Expression("jVendor.[Email]")]
        public string VendorEmail
        {
            get => fields.VendorEmail[this];
            set => fields.VendorEmail[this] = value;
        }

        [DisplayName("Vendor Confirm Password"), Expression("jVendor.[ConfirmPassword]")]
        public string VendorConfirmPassword
        {
            get => fields.VendorConfirmPassword[this];
            set => fields.VendorConfirmPassword[this] = value;
        }

        [DisplayName("Vendor Name"), Expression("jVendor.[Name]")]
        public string VendorName
        {
            get => fields.VendorName[this];
            set => fields.VendorName[this] = value;
        }

        [DisplayName("Vendor User Image"), Expression("jVendor.[UserImage]")]
        public string VendorUserImage
        {
            get => fields.VendorUserImage[this];
            set => fields.VendorUserImage[this] = value;
        }

        public DisplayModelRow()
            : base()
        {
        }

        public DisplayModelRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field DisplayModelId;
            public Int32Field ModelId;
            public Int32Field VendorId;

            public StringField ModelTitle;
            public StringField ModelCode;
            public StringField ModelModelImage;
            public Int32Field ModelCategoryId;
            public BooleanField ModelCheck;

            public StringField VendorUserName;
            public StringField VendorEmail;
            public StringField VendorConfirmPassword;
            public StringField VendorName;
            public StringField VendorUserImage;
        }
    }
}
