namespace Smt.Default {
    export interface CommonFaqRow {
        CommonFaqId?: number;
        Question?: string;
        Answer?: string;
    }

    export namespace CommonFaqRow {
        export const idProperty = 'CommonFaqId';
        export const nameProperty = 'Question';
        export const localTextPrefix = 'Default.CommonFaq';
        export const deletePermission = 'CommonFaq';
        export const insertPermission = 'CommonFaq';
        export const readPermission = 'CommonFaq';
        export const updatePermission = 'CommonFaq';

        export declare const enum Fields {
            CommonFaqId = "CommonFaqId",
            Question = "Question",
            Answer = "Answer"
        }
    }
}
