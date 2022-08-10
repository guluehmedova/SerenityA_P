namespace Smt.Default {
    export interface RequestRow {
        RequestId?: number;
        Theme?: string;
        RequestImages?: string;
        ForwardedTo?: boolean;
        Status?: Status;
        Date?: string;
        Text?: string;
        CreationDate?: string;
        ModelId?: number;
        CategoryId?: number;
        BrandId?: number;
        ModelTitle?: string;
        ModelCode?: string;
        ModelModelImage?: string;
        ModelCategoryId?: number;
        ModelCheck?: boolean;
        CategoryTitle?: string;
        CategoryCheck?: boolean;
        BrandTitle?: string;
        BrandBrandImage?: string;
        BrandCheck?: boolean;
    }

    export namespace RequestRow {
        export const idProperty = 'RequestId';
        export const nameProperty = 'Theme';
        export const localTextPrefix = 'Default.Request';
        export const lookupKey = 'Default.Request';

        export function getLookup(): Q.Lookup<RequestRow> {
            return Q.getLookup<RequestRow>('Default.Request');
        }
        export const deletePermission = 'Request';
        export const insertPermission = 'Request';
        export const readPermission = 'Request';
        export const updatePermission = 'Request';

        export declare const enum Fields {
            RequestId = "RequestId",
            Theme = "Theme",
            RequestImages = "RequestImages",
            ForwardedTo = "ForwardedTo",
            Status = "Status",
            Date = "Date",
            Text = "Text",
            CreationDate = "CreationDate",
            ModelId = "ModelId",
            CategoryId = "CategoryId",
            BrandId = "BrandId",
            ModelTitle = "ModelTitle",
            ModelCode = "ModelCode",
            ModelModelImage = "ModelModelImage",
            ModelCategoryId = "ModelCategoryId",
            ModelCheck = "ModelCheck",
            CategoryTitle = "CategoryTitle",
            CategoryCheck = "CategoryCheck",
            BrandTitle = "BrandTitle",
            BrandBrandImage = "BrandBrandImage",
            BrandCheck = "BrandCheck"
        }
    }
}
