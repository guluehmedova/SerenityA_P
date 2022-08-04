
namespace Smt.Default {

    @Serenity.Decorators.registerClass()
    export class BrandCategoryDialog extends Serenity.EntityDialog<BrandCategoryRow, any> {
        protected getFormKey() { return BrandCategoryForm.formKey; }
        protected getIdProperty() { return BrandCategoryRow.idProperty; }
        protected getLocalTextPrefix() { return BrandCategoryRow.localTextPrefix; }
        protected getService() { return BrandCategoryService.baseUrl; }
        protected getDeletePermission() { return BrandCategoryRow.deletePermission; }
        protected getInsertPermission() { return BrandCategoryRow.insertPermission; }
        protected getUpdatePermission() { return BrandCategoryRow.updatePermission; }

        protected form = new BrandCategoryForm(this.idPrefix);

    }
}