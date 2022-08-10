using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Smt.Default.BrandListRequest;
using MyResponse = Serenity.Services.ListResponse<Smt.Default.BrandRow>;
using MyRow = Smt.Default.BrandRow;

namespace Smt.Default
{
    public interface IBrandListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class BrandListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IBrandListHandler
    {
        private static MyRow.RowFields fld => MyRow.Fields;
        public BrandListHandler(IRequestContext context)
             : base(context)
        {
        }
        protected override void ApplyFilters(SqlQuery query)
        {
            base.ApplyFilters(query);

            if (!Request.Categories.IsEmptyOrNull())
            {
                var mg = BrandCategoryRow.Fields.As("mg");

                query.Where(Criteria.Exists(
                    query.SubQuery()
                        .From(mg)
                        .Select("1")
                        .Where(
                            mg.BrandId == fld.BrandId &&
                            mg.CategoryId.In(Request.Categories))
                        .ToString()));
            }
        }
    }
}