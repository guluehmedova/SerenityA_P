using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Smt.Default
{
    public partial class BrandListFormatterAttribute : CustomFormatterAttribute
    {
        public const string Key = "Smt.Default.BrandListFormatter";

        public BrandListFormatterAttribute()
            : base(Key)
        {
        }
    }
}
