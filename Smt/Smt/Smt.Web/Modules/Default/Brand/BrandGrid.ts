
namespace Smt.Default {

    @Serenity.Decorators.registerClass()
    export class BrandGrid extends Serenity.EntityGrid<BrandRow, any> {
        protected getColumnsKey() { return BrandColumns.columnsKey; }
        protected getDialogType() { return BrandDialog; }
        protected getIdProperty() { return BrandRow.idProperty; }
        protected getInsertPermission() { return BrandRow.insertPermission; }
        protected getLocalTextPrefix() { return BrandRow.localTextPrefix; }
        protected getService() { return BrandService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getQuickFilters() {
            let items = super.getQuickFilters();

            const genreListFilter = Q.first(items, x =>
                x.field == BrandRow.Fields.CategoryList);

            genreListFilter.handler = h => {
                const request = (h.request as BrandListRequest);
                const values = (h.widget as Serenity.LookupEditor).values;
                request.Categories = values.map(x => parseInt(x, 10));
                h.handled = true;
            };

            return items;
        }
    }
}