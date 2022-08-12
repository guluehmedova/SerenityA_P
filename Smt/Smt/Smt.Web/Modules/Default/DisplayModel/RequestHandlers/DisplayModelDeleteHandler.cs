using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Smt.Default.DisplayModelRow;

namespace Smt.Default
{
    public interface IDisplayModelDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class DisplayModelDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IDisplayModelDeleteHandler
    {
        public DisplayModelDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}