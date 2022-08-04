
namespace Smt.Default {

    @Serenity.Decorators.registerClass()
    export class CommonFaqDialog extends Serenity.EntityDialog<CommonFaqRow, any> {
        protected getFormKey() { return CommonFaqForm.formKey; }
        protected getIdProperty() { return CommonFaqRow.idProperty; }
        protected getLocalTextPrefix() { return CommonFaqRow.localTextPrefix; }
        protected getNameProperty() { return CommonFaqRow.nameProperty; }
        protected getService() { return CommonFaqService.baseUrl; }
        protected getDeletePermission() { return CommonFaqRow.deletePermission; }
        protected getInsertPermission() { return CommonFaqRow.insertPermission; }
        protected getUpdatePermission() { return CommonFaqRow.updatePermission; }

        protected form = new CommonFaqForm(this.idPrefix);

    }
}