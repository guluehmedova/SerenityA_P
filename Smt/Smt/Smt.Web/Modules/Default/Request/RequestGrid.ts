
namespace Smt.Default {

    @Serenity.Decorators.registerClass()
    export class RequestGrid extends Serenity.EntityGrid<RequestRow, any> {
        protected getColumnsKey() { return RequestColumns.columnsKey; }
        protected getDialogType() { return RequestDialog; }
        protected getIdProperty() { return RequestRow.idProperty; }
        protected getInsertPermission() { return RequestRow.insertPermission; }
        protected getLocalTextPrefix() { return RequestRow.localTextPrefix; }
        protected getService() { return RequestService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}