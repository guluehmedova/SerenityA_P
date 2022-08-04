using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Smt.Default.Forms
{
    [FormScript("Default.CommonFaq")]
    [BasedOnRow(typeof(CommonFaqRow), CheckNames = true)]
    public class CommonFaqForm
    {
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}