namespace Smt.Default {
    export interface CommonFaqForm {
        Question: Serenity.StringEditor;
        Answer: Serenity.StringEditor;
    }

    export class CommonFaqForm extends Serenity.PrefixedContext {
        static formKey = 'Default.CommonFaq';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!CommonFaqForm.init)  {
                CommonFaqForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(CommonFaqForm, [
                    'Question', w0,
                    'Answer', w0
                ]);
            }
        }
    }
}
