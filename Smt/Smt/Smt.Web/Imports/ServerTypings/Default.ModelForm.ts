namespace Smt.Default {
    export interface ModelForm {
        Title: Serenity.StringEditor;
        Code: Serenity.StringEditor;
        ModelImage: Serenity.ImageUploadEditor;
        CategoryId: Serenity.LookupEditor;
    }

    export class ModelForm extends Serenity.PrefixedContext {
        static formKey = 'Default.Model';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ModelForm.init)  {
                ModelForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.ImageUploadEditor;
                var w2 = s.LookupEditor;

                Q.initFormType(ModelForm, [
                    'Title', w0,
                    'Code', w0,
                    'ModelImage', w1,
                    'CategoryId', w2
                ]);
            }
        }
    }
}
