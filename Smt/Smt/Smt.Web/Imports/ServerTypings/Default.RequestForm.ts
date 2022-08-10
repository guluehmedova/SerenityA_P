namespace Smt.Default {
    export interface RequestForm {
        Theme: Serenity.StringEditor;
        RequestImages: Serenity.StringEditor;
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
                var w1 = s.BooleanEditor;
                var w2 = s.EnumEditor;
                var w3 = s.DateEditor;
                var w4 = s.LookupEditor;

                Q.initFormType(RequestForm, [
                    'Theme', w0,
                    'RequestImages', w0,
                    'ForwardedTo', w1,
                    'Status', w2,
                    'Date', w3,
                    'Text', w0,
                    'CreationDate', w3,
                    'ModelId', w4,
                    'CategoryId', w4,
                    'BrandId', w4
                ]);
            }
        }
    }
}
