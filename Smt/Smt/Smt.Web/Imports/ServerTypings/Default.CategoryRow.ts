namespace Smt.Default {
    export interface CategoryRow {
        CategoryId?: number;
        Title?: string;
        BrandList?: number[];
    }

    export namespace CategoryRow {
        export const idProperty = 'CategoryId';
        export const nameProperty = 'Title';
        export const localTextPrefix = 'Default.Category';
        export const lookupKey = 'Default.Category';

        export function getLookup(): Q.Lookup<CategoryRow> {
            return Q.getLookup<CategoryRow>('Default.Category');
        }
        export const deletePermission = 'Category';
        export const insertPermission = 'Category';
        export const readPermission = 'Category';
        export const updatePermission = 'Category';

        export declare const enum Fields {
            CategoryId = "CategoryId",
            Title = "Title",
            BrandList = "BrandList"
        }
    }
}
