using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<Smt.Default.CommonFaqRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Smt.Default.CommonFaqRow;

namespace Smt.Default
{
    public interface ICommonFaqSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class CommonFaqSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICommonFaqSaveHandler
    {
        public CommonFaqSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}