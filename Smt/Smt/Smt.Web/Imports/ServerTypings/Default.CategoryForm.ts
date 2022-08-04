namespace Smt.Default {
    export interface CategoryForm {
        Title: Serenity.StringEditor;
        BrandList: Serenity.LookupEditor;
    }

    export class CategoryForm extends Serenity.PrefixedContext {
        static formKey = 'Default.Category';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!CategoryForm.init)  {
                CategoryForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.LookupEditor;

                Q.initFormType(CategoryForm, [
                    'Title', w0,
                    'BrandList', w1
                ]);
            }
        }
    }
}
