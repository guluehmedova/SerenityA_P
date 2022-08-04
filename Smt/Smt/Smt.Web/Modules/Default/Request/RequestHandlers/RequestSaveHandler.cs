using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<Smt.Default.RequestRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Smt.Default.RequestRow;

namespace Smt.Default
{
    public interface IRequestSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class RequestSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IRequestSaveHandler
    {
        public RequestSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}