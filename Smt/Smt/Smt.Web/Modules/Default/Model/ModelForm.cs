using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Smt.Default.Forms
{
    [FormScript("Default.Model")]
    [BasedOnRow(typeof(ModelRow), CheckNames = true)]
    public class ModelForm
    {
        public string Title { get; set; }
        public string Code { get; set; }
        public string ModelImage { get; set; }
        public int CategoryId { get; set; }
        public bool Check { get; set; }
    }
}