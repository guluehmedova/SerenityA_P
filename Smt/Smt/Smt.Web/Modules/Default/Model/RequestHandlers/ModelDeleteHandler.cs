using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Smt.Default.ModelRow;

namespace Smt.Default
{
    public interface IModelDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class ModelDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IModelDeleteHandler
    {
        public ModelDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}