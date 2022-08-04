using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Smt.Default.BrandCategoryRow;

namespace Smt.Default
{
    public interface IBrandCategoryDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class BrandCategoryDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IBrandCategoryDeleteHandler
    {
        public BrandCategoryDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}