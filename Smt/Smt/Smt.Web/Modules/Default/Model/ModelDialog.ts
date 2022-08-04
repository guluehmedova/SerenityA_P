
namespace Smt.Default {

    @Serenity.Decorators.registerClass()
    export class ModelDialog extends Serenity.EntityDialog<ModelRow, any> {
        protected getFormKey() { return ModelForm.formKey; }
        protected getIdProperty() { return ModelRow.idProperty; }
        protected getLocalTextPrefix() { return ModelRow.localTextPrefix; }
        protected getNameProperty() { return ModelRow.nameProperty; }
        protected getService() { return ModelService.baseUrl; }
        protected getDeletePermission() { return ModelRow.deletePermission; }
        protected getInsertPermission() { return ModelRow.insertPermission; }
        protected getUpdatePermission() { return ModelRow.updatePermission; }

        protected form = new ModelForm(this.idPrefix);

    }
}