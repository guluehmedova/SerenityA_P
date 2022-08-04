using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Smt.Default.ModelRow>;
using MyRow = Smt.Default.ModelRow;

namespace Smt.Default
{
    public interface IModelListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class ModelListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IModelListHandler
    {
        public ModelListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}