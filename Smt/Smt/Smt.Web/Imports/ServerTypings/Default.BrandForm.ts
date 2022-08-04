namespace Smt.Default {
    export interface BrandForm {
        Title: Serenity.StringEditor;
        BrandImage: Serenity.ImageUploadEditor;
        CategoryList: Serenity.LookupEditor;
    }

    export class BrandForm extends Serenity.PrefixedContext {
        static formKey = 'Default.Brand';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!BrandForm.init)  {
                BrandForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.ImageUploadEditor;
                var w2 = s.LookupEditor;

                Q.initFormType(BrandForm, [
                    'Title', w0,
                    'BrandImage', w1,
                    'CategoryList', w2
                ]);
            }
        }
    }
}
