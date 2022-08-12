namespace Smt.Texts {

    declare namespace Db {

        namespace Administration {

            namespace Language {
                export const Id: string;
                export const LanguageId: string;
                export const LanguageName: string;
            }

            namespace Role {
                export const RoleId: string;
                export const RoleName: string;
            }

            namespace RolePermission {
                export const PermissionKey: string;
                export const RoleId: string;
                export const RolePermissionId: string;
                export const RoleRoleName: string;
            }

            namespace Translation {
                export const CustomText: string;
                export const EntityPlural: string;
                export const Key: string;
                export const OverrideConfirmation: string;
                export const SaveChangesButton: string;
                export const SourceLanguage: string;
                export const SourceText: string;
                export const TargetLanguage: string;
                export const TargetText: string;
            }

            namespace User {
                export const DisplayName: string;
                export const Email: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const LastDirectoryUpdate: string;
                export const Password: string;
                export const PasswordConfirm: string;
                export const PasswordHash: string;
                export const PasswordSalt: string;
                export const Source: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
                export const UserId: string;
                export const UserImage: string;
                export const Username: string;
            }

            namespace UserPermission {
                export const Granted: string;
                export const PermissionKey: string;
                export const User: string;
                export const UserId: string;
                export const UserPermissionId: string;
                export const Username: string;
            }

            namespace UserRole {
                export const RoleId: string;
                export const User: string;
                export const UserId: string;
                export const UserRoleId: string;
                export const Username: string;
            }
        }

        namespace Default {

            namespace Brand {
                export const BrandId: string;
                export const BrandImage: string;
                export const CategoryList: string;
                export const Check: string;
                export const RequestList: string;
                export const Title: string;
            }

            namespace BrandCategory {
                export const BrandBrandImage: string;
                export const BrandCategoryId: string;
                export const BrandCheck: string;
                export const BrandId: string;
                export const BrandTitle: string;
                export const CategoryCheck: string;
                export const CategoryId: string;
                export const CategoryTitle: string;
            }

            namespace Category {
                export const BrandList: string;
                export const CategoryId: string;
                export const Check: string;
                export const ModelList: string;
                export const RequestList: string;
                export const Title: string;
            }

            namespace CommonFaq {
                export const Answer: string;
                export const CommonFaqId: string;
                export const Question: string;
            }

            namespace DisplayModel {
                export const DisplayModelId: string;
                export const ModelCategoryId: string;
                export const ModelCheck: string;
                export const ModelCode: string;
                export const ModelId: string;
                export const ModelModelImage: string;
                export const ModelTitle: string;
                export const VendorConfirmPassword: string;
                export const VendorEmail: string;
                export const VendorId: string;
                export const VendorName: string;
                export const VendorUserImage: string;
                export const VendorUserName: string;
            }

            namespace Model {
                export const CategoryCheck: string;
                export const CategoryId: string;
                export const CategoryTitle: string;
                export const Check: string;
                export const Code: string;
                export const ModelId: string;
                export const ModelImage: string;
                export const RequestList: string;
                export const Title: string;
            }

            namespace Request {
                export const BrandBrandImage: string;
                export const BrandCheck: string;
                export const BrandId: string;
                export const BrandTitle: string;
                export const CategoryCheck: string;
                export const CategoryId: string;
                export const CategoryTitle: string;
                export const CreationDate: string;
                export const Date: string;
                export const ForwardedTo: string;
                export const ModelCategoryId: string;
                export const ModelCheck: string;
                export const ModelCode: string;
                export const ModelId: string;
                export const ModelModelImage: string;
                export const ModelTitle: string;
                export const RequestId: string;
                export const RequestImages: string;
                export const Status: string;
                export const Text: string;
                export const Theme: string;
            }

            namespace Vendor {
                export const ConfirmPassword: string;
                export const Email: string;
                export const ModelList: string;
                export const Name: string;
                export const Password: string;
                export const UserImage: string;
                export const UserName: string;
                export const VendorId: string;
            }
        }
    }

    declare namespace Forms {

        namespace Membership {

            namespace ChangePassword {
                export const FormTitle: string;
                export const SubmitButton: string;
                export const Success: string;
            }

            namespace ForgotPassword {
                export const BackToLogin: string;
                export const FormInfo: string;
                export const FormTitle: string;
                export const SubmitButton: string;
                export const Success: string;
            }

            namespace Login {
                export const FacebookButton: string;
                export const ForgotPassword: string;
                export const GoogleButton: string;
                export const LoginToYourAccount: string;
                export const OR: string;
                export const RememberMe: string;
                export const SignInButton: string;
                export const SignUpButton: string;
            }

            namespace ResetPassword {
                export const BackToLogin: string;
                export const EmailSubject: string;
                export const FormTitle: string;
                export const SubmitButton: string;
                export const Success: string;
            }

            namespace SignUp {
                export const AcceptTerms: string;
                export const ActivateEmailSubject: string;
                export const ActivationCompleteMessage: string;
                export const BackToLogin: string;
                export const ConfirmEmail: string;
                export const ConfirmPassword: string;
                export const DisplayName: string;
                export const Email: string;
                export const FormInfo: string;
                export const FormTitle: string;
                export const Password: string;
                export const SubmitButton: string;
                export const Success: string;
            }
        }
    }

    declare namespace Navigation {
        export const LogoutLink: string;
        export const SiteTitle: string;
    }

    declare namespace Site {

        namespace AccessDenied {
            export const ClickToChangeUser: string;
            export const ClickToLogin: string;
            export const LackPermissions: string;
            export const NotLoggedIn: string;
            export const PageTitle: string;
        }

        namespace BasicProgressDialog {
            export const CancelTitle: string;
            export const PleaseWait: string;
        }

        namespace BulkServiceAction {
            export const AllHadErrorsFormat: string;
            export const AllSuccessFormat: string;
            export const ConfirmationFormat: string;
            export const ErrorCount: string;
            export const NothingToProcess: string;
            export const SomeHadErrorsFormat: string;
            export const SuccessCount: string;
        }

        namespace Dashboard {
            export const ContentDescription: string;
        }

        namespace Layout {
            export const FooterCopyright: string;
            export const FooterInfo: string;
            export const FooterRights: string;
            export const GeneralSettings: string;
            export const Language: string;
            export const Theme: string;
            export const ThemeBlack: string;
            export const ThemeBlackLight: string;
            export const ThemeBlue: string;
            export const ThemeBlueLight: string;
            export const ThemeGreen: string;
            export const ThemeGreenLight: string;
            export const ThemePurple: string;
            export const ThemePurpleLight: string;
            export const ThemeRed: string;
            export const ThemeRedLight: string;
            export const ThemeYellow: string;
            export const ThemeYellowLight: string;
        }

        namespace RolePermissionDialog {
            export const DialogTitle: string;
            export const EditButton: string;
            export const SaveSuccess: string;
        }

        namespace UserDialog {
            export const EditPermissionsButton: string;
            export const EditRolesButton: string;
        }

        namespace UserPermissionDialog {
            export const DialogTitle: string;
            export const Grant: string;
            export const Permission: string;
            export const Revoke: string;
            export const SaveSuccess: string;
        }

        namespace UserRoleDialog {
            export const DialogTitle: string;
            export const SaveSuccess: string;
        }

        namespace ValidationError {
            export const Title: string;
        }
    }

    declare namespace Validation {
        export const AuthenticationError: string;
        export const CantFindUserWithEmail: string;
        export const CurrentPasswordMismatch: string;
        export const DeleteForeignKeyError: string;
        export const EmailConfirm: string;
        export const EmailInUse: string;
        export const InvalidActivateToken: string;
        export const InvalidResetToken: string;
        export const MinRequiredPasswordLength: string;
        export const SavePrimaryKeyError: string;
    }

    Smt['Texts'] = Q.proxyTexts(Texts, '', {Db:{Administration:{Language:{Id:1,LanguageId:1,LanguageName:1},Role:{RoleId:1,RoleName:1},RolePermission:{PermissionKey:1,RoleId:1,RolePermissionId:1,RoleRoleName:1},Translation:{CustomText:1,EntityPlural:1,Key:1,OverrideConfirmation:1,SaveChangesButton:1,SourceLanguage:1,SourceText:1,TargetLanguage:1,TargetText:1},User:{DisplayName:1,Email:1,InsertDate:1,InsertUserId:1,IsActive:1,LastDirectoryUpdate:1,Password:1,PasswordConfirm:1,PasswordHash:1,PasswordSalt:1,Source:1,UpdateDate:1,UpdateUserId:1,UserId:1,UserImage:1,Username:1},UserPermission:{Granted:1,PermissionKey:1,User:1,UserId:1,UserPermissionId:1,Username:1},UserRole:{RoleId:1,User:1,UserId:1,UserRoleId:1,Username:1}},Default:{Brand:{BrandId:1,BrandImage:1,CategoryList:1,Check:1,RequestList:1,Title:1},BrandCategory:{BrandBrandImage:1,BrandCategoryId:1,BrandCheck:1,BrandId:1,BrandTitle:1,CategoryCheck:1,CategoryId:1,CategoryTitle:1},Category:{BrandList:1,CategoryId:1,Check:1,ModelList:1,RequestList:1,Title:1},CommonFaq:{Answer:1,CommonFaqId:1,Question:1},DisplayModel:{DisplayModelId:1,ModelCategoryId:1,ModelCheck:1,ModelCode:1,ModelId:1,ModelModelImage:1,ModelTitle:1,VendorConfirmPassword:1,VendorEmail:1,VendorId:1,VendorName:1,VendorUserImage:1,VendorUserName:1},Model:{CategoryCheck:1,CategoryId:1,CategoryTitle:1,Check:1,Code:1,ModelId:1,ModelImage:1,RequestList:1,Title:1},Request:{BrandBrandImage:1,BrandCheck:1,BrandId:1,BrandTitle:1,CategoryCheck:1,CategoryId:1,CategoryTitle:1,CreationDate:1,Date:1,ForwardedTo:1,ModelCategoryId:1,ModelCheck:1,ModelCode:1,ModelId:1,ModelModelImage:1,ModelTitle:1,RequestId:1,RequestImages:1,Status:1,Text:1,Theme:1},Vendor:{ConfirmPassword:1,Email:1,ModelList:1,Name:1,Password:1,UserImage:1,UserName:1,VendorId:1}}},Forms:{Membership:{ChangePassword:{FormTitle:1,SubmitButton:1,Success:1},ForgotPassword:{BackToLogin:1,FormInfo:1,FormTitle:1,SubmitButton:1,Success:1},Login:{FacebookButton:1,ForgotPassword:1,GoogleButton:1,LoginToYourAccount:1,OR:1,RememberMe:1,SignInButton:1,SignUpButton:1},ResetPassword:{BackToLogin:1,EmailSubject:1,FormTitle:1,SubmitButton:1,Success:1},SignUp:{AcceptTerms:1,ActivateEmailSubject:1,ActivationCompleteMessage:1,BackToLogin:1,ConfirmEmail:1,ConfirmPassword:1,DisplayName:1,Email:1,FormInfo:1,FormTitle:1,Password:1,SubmitButton:1,Success:1}}},Navigation:{LogoutLink:1,SiteTitle:1},Site:{AccessDenied:{ClickToChangeUser:1,ClickToLogin:1,LackPermissions:1,NotLoggedIn:1,PageTitle:1},BasicProgressDialog:{CancelTitle:1,PleaseWait:1},BulkServiceAction:{AllHadErrorsFormat:1,AllSuccessFormat:1,ConfirmationFormat:1,ErrorCount:1,NothingToProcess:1,SomeHadErrorsFormat:1,SuccessCount:1},Dashboard:{ContentDescription:1},Layout:{FooterCopyright:1,FooterInfo:1,FooterRights:1,GeneralSettings:1,Language:1,Theme:1,ThemeBlack:1,ThemeBlackLight:1,ThemeBlue:1,ThemeBlueLight:1,ThemeGreen:1,ThemeGreenLight:1,ThemePurple:1,ThemePurpleLight:1,ThemeRed:1,ThemeRedLight:1,ThemeYellow:1,ThemeYellowLight:1},RolePermissionDialog:{DialogTitle:1,EditButton:1,SaveSuccess:1},UserDialog:{EditPermissionsButton:1,EditRolesButton:1},UserPermissionDialog:{DialogTitle:1,Grant:1,Permission:1,Revoke:1,SaveSuccess:1},UserRoleDialog:{DialogTitle:1,SaveSuccess:1},ValidationError:{Title:1}},Validation:{AuthenticationError:1,CantFindUserWithEmail:1,CurrentPasswordMismatch:1,DeleteForeignKeyError:1,EmailConfirm:1,EmailInUse:1,InvalidActivateToken:1,InvalidResetToken:1,MinRequiredPasswordLength:1,SavePrimaryKeyError:1}});
}
