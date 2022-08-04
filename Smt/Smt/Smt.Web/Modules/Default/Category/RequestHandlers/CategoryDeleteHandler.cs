using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Smt.Default.CategoryRow;

namespace Smt.Default
{
    public interface ICategoryDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class CategoryDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICategoryDeleteHandler
    {
        public CategoryDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}