namespace Smt.Default {
    export interface DisplayModelForm {
        ModelId: Serenity.IntegerEditor;
        VendorId: Serenity.IntegerEditor;
    }

    export class DisplayModelForm extends Serenity.PrefixedContext {
        static formKey = 'Default.DisplayModel';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!DisplayModelForm.init)  {
                DisplayModelForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;

                Q.initFormType(DisplayModelForm, [
                    'ModelId', w0,
                    'VendorId', w0
                ]);
            }
        }
    }
}
