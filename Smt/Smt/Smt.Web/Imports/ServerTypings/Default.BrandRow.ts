namespace Smt.Default {
    export interface BrandRow {
        BrandId?: number;
        Title?: string;
        BrandImage?: string;
        Check?: boolean;
        CategoryList?: number[];
        RequestList?: number[];
    }

    export namespace BrandRow {
        export const idProperty = 'BrandId';
        export const nameProperty = 'Title';
        export const localTextPrefix = 'Default.Brand';
        export const lookupKey = 'Default.Brand';

        export function getLookup(): Q.Lookup<BrandRow> {
            return Q.getLookup<BrandRow>('Default.Brand');
        }
        export const deletePermission = 'Brand';
        export const insertPermission = 'Brand';
        export const readPermission = 'Brand';
        export const updatePermission = 'Brand';

        export declare const enum Fields {
            BrandId = "BrandId",
            Title = "Title",
            BrandImage = "BrandImage",
            Check = "Check",
            CategoryList = "CategoryList",
            RequestList = "RequestList"
        }
    }
}
