namespace Smt.Default
{
    using Serenity.Services;
    using System.Collections.Generic;
    public class CategoryListRequest : ListRequest
    {
        public List<int> Brands { get; set; }
    }
}
