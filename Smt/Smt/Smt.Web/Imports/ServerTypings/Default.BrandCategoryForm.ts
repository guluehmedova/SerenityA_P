namespace Smt.Default {
    export interface BrandCategoryForm {
        BrandId: Serenity.IntegerEditor;
        CategoryId: Serenity.IntegerEditor;
    }

    export class BrandCategoryForm extends Serenity.PrefixedContext {
        static formKey = 'Default.BrandCategory';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!BrandCategoryForm.init)  {
                BrandCategoryForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;

                Q.initFormType(BrandCategoryForm, [
                    'BrandId', w0,
                    'CategoryId', w0
                ]);
            }
        }
    }
}
