using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Smt.Default.BrandCategoryRow>;
using MyRow = Smt.Default.BrandCategoryRow;

namespace Smt.Default
{
    public interface IBrandCategoryListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class BrandCategoryListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IBrandCategoryListHandler
    {
        public BrandCategoryListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}