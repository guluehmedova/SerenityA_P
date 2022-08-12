using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<Smt.Default.DisplayModelRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Smt.Default.DisplayModelRow;

namespace Smt.Default
{
    public interface IDisplayModelSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class DisplayModelSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IDisplayModelSaveHandler
    {
        public DisplayModelSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}