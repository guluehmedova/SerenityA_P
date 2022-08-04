using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<Smt.Default.ModelRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Smt.Default.ModelRow;

namespace Smt.Default
{
    public interface IModelSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class ModelSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IModelSaveHandler
    {
        public ModelSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}