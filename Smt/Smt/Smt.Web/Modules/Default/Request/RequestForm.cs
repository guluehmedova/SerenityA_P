using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Smt.Default.Forms
{
    [FormScript("Default.Request")]
    [BasedOnRow(typeof(RequestRow), CheckNames = true)]
    public class RequestForm
    {
        public string Theme { get; set; }
        public string RequestImages { get; set; }
        public bool ForwardedTo { get; set; }
        public int Status { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModelId { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
    }
}