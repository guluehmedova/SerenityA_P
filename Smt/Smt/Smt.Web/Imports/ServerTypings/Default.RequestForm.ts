namespace Smt.Default {
    export interface RequestForm {
        Theme: Serenity.StringEditor;
        RequestImages: Serenity.MultipleImageUploadEditor;
        ForwardedTo: Serenity.BooleanEditor;
        Status: Serenity.EnumEditor;
        Date: Serenity.DateEditor;
        Text: Serenity.StringEditor;
        CreationDate: Serenity.DateEditor;
        ModelId: Serenity.LookupEditor;
        CategoryId: Serenity.LookupEditor;
        BrandId: Serenity.LookupEditor;
    }

    export class RequestForm extends Serenity.PrefixedContext {
        static formKey = 'Default.Request';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!RequestForm.init)  {
                RequestForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.MultipleImageUploadEditor;
                var w2 = s.BooleanEditor;
                var w3 = s.EnumEditor;
                var w4 = s.DateEditor;
                var w5 = s.LookupEditor;

                Q.initFormType(RequestForm, [
                    'Theme', w0,
                    'RequestImages', w1,
                    'ForwardedTo', w2,
                    'Status', w3,
                    'Date', w4,
                    'Text', w0,
                    'CreationDate', w4,
                    'ModelId', w5,
                    'CategoryId', w5,
                    'BrandId', w5
                ]);
            }
        }
    }
}
