
namespace Smt.Default {

    @Serenity.Decorators.registerClass()
    export class ModelGrid extends Serenity.EntityGrid<ModelRow, any> {
        protected getColumnsKey() { return ModelColumns.columnsKey; }
        protected getDialogType() { return ModelDialog; }
        protected getIdProperty() { return ModelRow.idProperty; }
        protected getInsertPermission() { return ModelRow.insertPermission; }
        protected getLocalTextPrefix() { return ModelRow.localTextPrefix; }
        protected getService() { return ModelService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}