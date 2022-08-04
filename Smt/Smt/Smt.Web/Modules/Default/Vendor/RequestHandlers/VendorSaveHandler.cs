using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<Smt.Default.VendorRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Smt.Default.VendorRow;

namespace Smt.Default
{
    public interface IVendorSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class VendorSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IVendorSaveHandler
    {
        public VendorSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}