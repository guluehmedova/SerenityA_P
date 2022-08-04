using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Smt.Default.VendorRow>;
using MyRow = Smt.Default.VendorRow;

namespace Smt.Default
{
    public interface IVendorRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class VendorRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IVendorRetrieveHandler
    {
        public VendorRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}