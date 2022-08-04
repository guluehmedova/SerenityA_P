using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Smt.Default.BrandRow>;
using MyRow = Smt.Default.BrandRow;

namespace Smt.Default
{
    public interface IBrandListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class BrandListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IBrandListHandler
    {
        public BrandListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}