using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Smt.Default
{
    public partial class RequestListFormatterAttribute : CustomFormatterAttribute
    {
        public const string Key = "Smt.Default.RequestListFormatter";

        public RequestListFormatterAttribute()
            : base(Key)
        {
        }
    }
}
