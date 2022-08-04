namespace Smt.Default {
    export interface BrandCategoryRow {
        BrandCategoryId?: number;
        BrandId?: number;
        CategoryId?: number;
        BrandTitle?: string;
        BrandBrandImage?: string;
        CategoryTitle?: string;
    }

    export namespace BrandCategoryRow {
        export const idProperty = 'BrandCategoryId';
        export const localTextPrefix = 'Default.BrandCategory';
        export const lookupKey = 'Default.BrandCategory';

        export function getLookup(): Q.Lookup<BrandCategoryRow> {
            return Q.getLookup<BrandCategoryRow>('Default.BrandCategory');
        }
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
            CategoryTitle = "CategoryTitle"
        }
    }
}
