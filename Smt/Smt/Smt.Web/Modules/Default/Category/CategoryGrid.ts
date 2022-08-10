
namespace Smt.Default {

    @Serenity.Decorators.registerClass()
    export class CategoryGrid extends Serenity.EntityGrid<CategoryRow, any> {
        protected getColumnsKey() { return CategoryColumns.columnsKey; }
        protected getDialogType() { return CategoryDialog; }
        protected getIdProperty() { return CategoryRow.idProperty; }
        protected getInsertPermission() { return CategoryRow.insertPermission; }
        protected getLocalTextPrefix() { return CategoryRow.localTextPrefix; }
        protected getService() { return CategoryService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
        protected getQuickFilters() {
            let items = super.getQuickFilters();

            const genreListFilter = Q.first(items, x =>
                x.field == CategoryRow.Fields.BrandList);

            genreListFilter.handler = h => {
                const request = (h.request as CategoryListRequest);
                const values = (h.widget as Serenity.LookupEditor).values;
                request.Brands = values.map(x => parseInt(x, 10));
                h.handled = true;
            };

            return items;
        }
    }
}