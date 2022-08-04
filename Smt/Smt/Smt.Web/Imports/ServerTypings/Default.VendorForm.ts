namespace Smt.Default {
    export interface VendorForm {
        UserName: Serenity.StringEditor;
        Email: Serenity.StringEditor;
        Password: Serenity.StringEditor;
        ConfirmPassword: Serenity.StringEditor;
        Name: Serenity.StringEditor;
        UserImage: Serenity.StringEditor;
    }

    export class VendorForm extends Serenity.PrefixedContext {
        static formKey = 'Default.Vendor';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!VendorForm.init)  {
                VendorForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(VendorForm, [
                    'UserName', w0,
                    'Email', w0,
                    'Password', w0,
                    'ConfirmPassword', w0,
                    'Name', w0,
                    'UserImage', w0
                ]);
            }
        }
    }
}
