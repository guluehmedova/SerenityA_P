using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Smt.Default.DisplayModelRow>;
using MyRow = Smt.Default.DisplayModelRow;

namespace Smt.Default
{
    public interface IDisplayModelRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class DisplayModelRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IDisplayModelRetrieveHandler
    {
        public DisplayModelRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}