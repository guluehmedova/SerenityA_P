using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Smt.Default.CommonFaqRow>;
using MyRow = Smt.Default.CommonFaqRow;

namespace Smt.Default
{
    public interface ICommonFaqRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class CommonFaqRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICommonFaqRetrieveHandler
    {
        public CommonFaqRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}