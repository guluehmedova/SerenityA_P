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
        public Status Status { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
        public DateTime CreationDate { get; set; }
        [DisplayName("Model")]
        public int ModelId { get; set; }
        [DisplayName("Category")]
        public int CategoryId { get; set; }
        [DisplayName("Brand")]
        public int BrandId { get; set; }
    }
}