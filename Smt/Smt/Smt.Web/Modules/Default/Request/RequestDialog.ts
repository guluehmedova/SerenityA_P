
namespace Smt.Default {

    @Serenity.Decorators.registerClass()
    export class RequestDialog extends Serenity.EntityDialog<RequestRow, any> {
        protected getFormKey() { return RequestForm.formKey; }
        protected getIdProperty() { return RequestRow.idProperty; }
        protected getLocalTextPrefix() { return RequestRow.localTextPrefix; }
        protected getNameProperty() { return RequestRow.nameProperty; }
        protected getService() { return RequestService.baseUrl; }
        protected getDeletePermission() { return RequestRow.deletePermission; }
        protected getInsertPermission() { return RequestRow.insertPermission; }
        protected getUpdatePermission() { return RequestRow.updatePermission; }

        protected form = new RequestForm(this.idPrefix);

    }
}