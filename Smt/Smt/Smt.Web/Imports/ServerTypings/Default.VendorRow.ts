namespace Smt.Default {
    export interface VendorRow {
        VendorId?: number;
        UserName?: string;
        Email?: string;
        Password?: string;
        ConfirmPassword?: string;
        Name?: string;
        UserImage?: string;
        ModelList?: number[];
    }

    export namespace VendorRow {
        export const idProperty = 'VendorId';
        export const nameProperty = 'UserName';
        export const localTextPrefix = 'Default.Vendor';
        export const lookupKey = 'Default.Vendor';

        export function getLookup(): Q.Lookup<VendorRow> {
            return Q.getLookup<VendorRow>('Default.Vendor');
        }
        export const deletePermission = 'Vendor';
        export const insertPermission = 'Vendor';
        export const readPermission = 'Vendor';
        export const updatePermission = 'Vendor';

        export declare const enum Fields {
            VendorId = "VendorId",
            UserName = "UserName",
            Email = "Email",
            Password = "Password",
            ConfirmPassword = "ConfirmPassword",
            Name = "Name",
            UserImage = "UserImage",
            ModelList = "ModelList"
        }
    }
}
