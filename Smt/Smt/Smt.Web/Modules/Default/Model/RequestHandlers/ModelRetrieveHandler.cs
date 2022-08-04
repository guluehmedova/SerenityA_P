using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Smt.Default.ModelRow>;
using MyRow = Smt.Default.ModelRow;

namespace Smt.Default
{
    public interface IModelRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class ModelRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IModelRetrieveHandler
    {
        public ModelRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}