
namespace Smt.Default {

    @Serenity.Decorators.registerClass()
    export class DisplayModelDialog extends Serenity.EntityDialog<DisplayModelRow, any> {
        protected getFormKey() { return DisplayModelForm.formKey; }
        protected getIdProperty() { return DisplayModelRow.idProperty; }
        protected getLocalTextPrefix() { return DisplayModelRow.localTextPrefix; }
        protected getService() { return DisplayModelService.baseUrl; }
        protected getDeletePermission() { return DisplayModelRow.deletePermission; }
        protected getInsertPermission() { return DisplayModelRow.insertPermission; }
        protected getUpdatePermission() { return DisplayModelRow.updatePermission; }

        protected form = new DisplayModelForm(this.idPrefix);

    }
}