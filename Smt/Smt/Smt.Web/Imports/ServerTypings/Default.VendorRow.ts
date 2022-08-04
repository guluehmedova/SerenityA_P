namespace Smt.Default {
    export interface VendorRow {
        VendorId?: number;
        UserName?: string;
        Email?: string;
        Password?: string;
        ConfirmPassword?: string;
        Name?: string;
        UserImage?: string;
    }

    export namespace VendorRow {
        export const idProperty = 'VendorId';
        export const nameProperty = 'UserName';
        export const localTextPrefix = 'Default.Vendor';
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
            UserImage = "UserImage"
        }
    }
}
