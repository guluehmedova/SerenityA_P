using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Smt.Default.Forms
{
    [FormScript("Default.DisplayModel")]
    [BasedOnRow(typeof(DisplayModelRow), CheckNames = true)]
    public class DisplayModelForm
    {
        public int ModelId { get; set; }
        public int VendorId { get; set; }
    }
}