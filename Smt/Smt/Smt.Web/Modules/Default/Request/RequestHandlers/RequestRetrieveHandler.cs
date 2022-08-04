using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Smt.Default.RequestRow>;
using MyRow = Smt.Default.RequestRow;

namespace Smt.Default
{
    public interface IRequestRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class RequestRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IRequestRetrieveHandler
    {
        public RequestRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}