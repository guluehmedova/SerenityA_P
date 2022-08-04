
namespace Smt.Default {

    @Serenity.Decorators.registerClass()
    export class BrandCategoryGrid extends Serenity.EntityGrid<BrandCategoryRow, any> {
        protected getColumnsKey() { return BrandCategoryColumns.columnsKey; }
        protected getDialogType() { return BrandCategoryDialog; }
        protected getIdProperty() { return BrandCategoryRow.idProperty; }
        protected getInsertPermission() { return BrandCategoryRow.insertPermission; }
        protected getLocalTextPrefix() { return BrandCategoryRow.localTextPrefix; }
        protected getService() { return BrandCategoryService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}