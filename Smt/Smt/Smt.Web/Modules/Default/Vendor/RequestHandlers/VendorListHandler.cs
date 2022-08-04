using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Smt.Default.VendorRow>;
using MyRow = Smt.Default.VendorRow;

namespace Smt.Default
{
    public interface IVendorListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class VendorListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IVendorListHandler
    {
        public VendorListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}