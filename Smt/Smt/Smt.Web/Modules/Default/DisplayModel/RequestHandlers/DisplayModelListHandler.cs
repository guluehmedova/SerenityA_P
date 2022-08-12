using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Smt.Default.DisplayModelRow>;
using MyRow = Smt.Default.DisplayModelRow;

namespace Smt.Default
{
    public interface IDisplayModelListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class DisplayModelListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IDisplayModelListHandler
    {
        public DisplayModelListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}