using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Smt.Default.RequestRow>;
using MyRow = Smt.Default.RequestRow;

namespace Smt.Default
{
    public interface IRequestListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class RequestListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IRequestListHandler
    {
        public RequestListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}