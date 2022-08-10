namespace Smt.Default {
    export interface BrandCategoryRow {
        BrandCategoryId?: number;
        BrandId?: number;
        CategoryId?: number;
        BrandTitle?: string;
        BrandBrandImage?: string;
        BrandCheck?: boolean;
        CategoryTitle?: string;
        CategoryCheck?: boolean;
    }

    export namespace BrandCategoryRow {
        export const idProperty = 'BrandCategoryId';
        export const localTextPrefix = 'Default.BrandCategory';
        export const deletePermission = 'BrandCategory';
        export const insertPermission = 'BrandCategory';
        export const readPermission = 'BrandCategory';
        export const updatePermission = 'BrandCategory';

        export declare const enum Fields {
            BrandCategoryId = "BrandCategoryId",
            BrandId = "BrandId",
            CategoryId = "CategoryId",
            BrandTitle = "BrandTitle",
            BrandBrandImage = "BrandBrandImage",
            BrandCheck = "BrandCheck",
            CategoryTitle = "CategoryTitle",
            CategoryCheck = "CategoryCheck"
        }
    }
}
