namespace Smt.Default {
    export interface DisplayModelRow {
        DisplayModelId?: number;
        ModelId?: number;
        VendorId?: number;
        ModelTitle?: string;
        ModelCode?: string;
        ModelModelImage?: string;
        ModelCategoryId?: number;
        ModelCheck?: boolean;
        VendorUserName?: string;
        VendorEmail?: string;
        VendorConfirmPassword?: string;
        VendorName?: string;
        VendorUserImage?: string;
    }

    export namespace DisplayModelRow {
        export const idProperty = 'DisplayModelId';
        export const localTextPrefix = 'Default.DisplayModel';
        export const deletePermission = 'DisplayModel';
        export const insertPermission = 'DisplayModel';
        export const readPermission = 'DisplayModel';
        export const updatePermission = 'DisplayModel';

        export declare const enum Fields {
            DisplayModelId = "DisplayModelId",
            ModelId = "ModelId",
            VendorId = "VendorId",
            ModelTitle = "ModelTitle",
            ModelCode = "ModelCode",
            ModelModelImage = "ModelModelImage",
            ModelCategoryId = "ModelCategoryId",
            ModelCheck = "ModelCheck",
            VendorUserName = "VendorUserName",
            VendorEmail = "VendorEmail",
            VendorConfirmPassword = "VendorConfirmPassword",
            VendorName = "VendorName",
            VendorUserImage = "VendorUserImage"
        }
    }
}
