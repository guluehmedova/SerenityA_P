
namespace Smt.Default {

    @Serenity.Decorators.registerClass()
    export class CommonFaqGrid extends Serenity.EntityGrid<CommonFaqRow, any> {
        protected getColumnsKey() { return CommonFaqColumns.columnsKey; }
        protected getDialogType() { return CommonFaqDialog; }
        protected getIdProperty() { return CommonFaqRow.idProperty; }
        protected getInsertPermission() { return CommonFaqRow.insertPermission; }
        protected getLocalTextPrefix() { return CommonFaqRow.localTextPrefix; }
        protected getService() { return CommonFaqService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}