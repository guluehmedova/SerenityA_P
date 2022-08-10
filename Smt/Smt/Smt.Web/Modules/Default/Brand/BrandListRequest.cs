namespace Smt.Default
{
    using Serenity.Services;
    using System.Collections.Generic;

    public class BrandListRequest : ListRequest
    {
        public List<int> Categories { get; set; }
    }
}
