using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<Smt.Default.BrandCategoryRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Smt.Default.BrandCategoryRow;

namespace Smt.Default
{
    public interface IBrandCategorySaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class BrandCategorySaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IBrandCategorySaveHandler
    {
        public BrandCategorySaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}