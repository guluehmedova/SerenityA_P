﻿using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Smt.Default.RequestRow;

namespace Smt.Default
{
    public interface IRequestDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class RequestDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IRequestDeleteHandler
    {
        public RequestDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}