namespace Smt.Default {
    export interface ModelRow {
        ModelId?: number;
        Title?: string;
        Code?: string;
        ModelImage?: string;
        CategoryId?: number;
        Check?: boolean;
        CategoryTitle?: string;
        CategoryCheck?: boolean;
        RequestList?: number[];
    }

    export namespace ModelRow {
        export const idProperty = 'ModelId';
        export const nameProperty = 'Title';
        export const localTextPrefix = 'Default.Model';
        export const lookupKey = 'Default.Model';

        export function getLookup(): Q.Lookup<ModelRow> {
            return Q.getLookup<ModelRow>('Default.Model');
        }
        export const deletePermission = 'Model';
        export const insertPermission = 'Model';
        export const readPermission = 'Model';
        export const updatePermission = 'Model';

        export declare const enum Fields {
            ModelId = "ModelId",
            Title = "Title",
            Code = "Code",
            ModelImage = "ModelImage",
            CategoryId = "CategoryId",
            Check = "Check",
            CategoryTitle = "CategoryTitle",
            CategoryCheck = "CategoryCheck",
            RequestList = "RequestList"
        }
    }
}
