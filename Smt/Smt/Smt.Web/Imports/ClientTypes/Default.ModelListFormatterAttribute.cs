using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Smt.Default
{
    public partial class ModelListFormatterAttribute : CustomFormatterAttribute
    {
        public const string Key = "Smt.Default.ModelListFormatter";

        public ModelListFormatterAttribute()
            : base(Key)
        {
        }
    }
}
