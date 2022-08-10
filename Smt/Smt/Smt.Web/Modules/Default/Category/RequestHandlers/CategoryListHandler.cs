using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Smt.Default.CategoryListRequest;
using MyResponse = Serenity.Services.ListResponse<Smt.Default.CategoryRow>;
using MyRow = Smt.Default.CategoryRow;

namespace Smt.Default
{
    public interface ICategoryListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class CategoryListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICategoryListHandler
    {
        private static MyRow.RowFields fld => MyRow.Fields;
        public CategoryListHandler(IRequestContext context)
             : base(context)
        {
        }
        protected override void ApplyFilters(SqlQuery query)
        {
            base.ApplyFilters(query);

            if (!Request.Brands.IsEmptyOrNull())
            {
                var mg = BrandCategoryRow.Fields.As("mg");

                query.Where(Criteria.Exists(
                    query.SubQuery()
                        .From(mg)
                        .Select("1")
                        .Where(
                            mg.CategoryId == fld.CategoryId &&
                            mg.BrandId.In(Request.Brands))
                        .ToString()));
            }
        }
    }
}