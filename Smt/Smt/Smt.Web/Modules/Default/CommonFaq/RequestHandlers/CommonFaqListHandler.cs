using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Smt.Default.CommonFaqRow>;
using MyRow = Smt.Default.CommonFaqRow;

namespace Smt.Default
{
    public interface ICommonFaqListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class CommonFaqListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICommonFaqListHandler
    {
        public CommonFaqListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}