
namespace Smt.Default {

    @Serenity.Decorators.registerClass()
    export class DisplayModelGrid extends Serenity.EntityGrid<DisplayModelRow, any> {
        protected getColumnsKey() { return DisplayModelColumns.columnsKey; }
        protected getDialogType() { return DisplayModelDialog; }
        protected getIdProperty() { return DisplayModelRow.idProperty; }
        protected getInsertPermission() { return DisplayModelRow.insertPermission; }
        protected getLocalTextPrefix() { return DisplayModelRow.localTextPrefix; }
        protected getService() { return DisplayModelService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}