using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Smt.Default.CommonFaqRow;

namespace Smt.Default
{
    public interface ICommonFaqDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class CommonFaqDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICommonFaqDeleteHandler
    {
        public CommonFaqDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}