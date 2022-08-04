using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace Smt.Default
{
    [ConnectionKey("Default"), Module("Default"), TableName("[vendor].[Vendor]")]
    [DisplayName("Vendor"), InstanceName("Vendor")]
    [ReadPermission("Vendor")]
    [ModifyPermission("Vendor")]
    public sealed class VendorRow : Row<VendorRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Vendor Id"), Identity, IdProperty]
        public int? VendorId
        {
            get => fields.VendorId[this];
            set => fields.VendorId[this] = value;
        }

        [DisplayName("User Name"), Size(100), NotNull, QuickSearch, NameProperty]
        public string UserName
        {
            get => fields.UserName[this];
            set => fields.UserName[this] = value;
        }

        [DisplayName("Email"), Size(200), NotNull]
        public string Email
        {
            get => fields.Email[this];
            set => fields.Email[this] = value;
        }

        [DisplayName("Password"), Size(100), NotNull]
        public string Password
        {
            get => fields.Password[this];
            set => fields.Password[this] = value;
        }

        [DisplayName("Confirm Password"), Size(100), NotNull]
        public string ConfirmPassword
        {
            get => fields.ConfirmPassword[this];
            set => fields.ConfirmPassword[this] = value;
        }

        [DisplayName("Name"), Size(100), NotNull]
        public string Name
        {
            get => fields.Name[this];
            set => fields.Name[this] = value;
        }

        [DisplayName("User Image"), Size(250), NotNull]
        public string UserImage
        {
            get => fields.UserImage[this];
            set => fields.UserImage[this] = value;
        }

        public VendorRow()
            : base()
        {
        }

        public VendorRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field VendorId;
            public StringField UserName;
            public StringField Email;
            public StringField Password;
            public StringField ConfirmPassword;
            public StringField Name;
            public StringField UserImage;
        }
    }
}
