using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Smt.Default.BrandCategoryRow>;
using MyRow = Smt.Default.BrandCategoryRow;

namespace Smt.Default
{
    public interface IBrandCategoryRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class BrandCategoryRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IBrandCategoryRetrieveHandler
    {
        public BrandCategoryRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}