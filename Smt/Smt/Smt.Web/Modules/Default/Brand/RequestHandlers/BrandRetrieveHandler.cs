using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Smt.Default.BrandRow>;
using MyRow = Smt.Default.BrandRow;

namespace Smt.Default
{
    public interface IBrandRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class BrandRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IBrandRetrieveHandler
    {
        public BrandRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}