using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public enum FaqOwnershipRespModelCode
    {
        [EnumMember(Value = @"success")]
        Success = 0,

        [EnumMember(Value = @"internalServerError")]
        InternalServerError = 1,

        [EnumMember(Value = @"applicationExceptions")]
        ApplicationExceptions = 2,

        [EnumMember(Value = @"userNotExists")]
        UserNotExists = 3,

        [EnumMember(Value = @"originalPasswordError")]
        OriginalPasswordError = 4,

        [EnumMember(Value = @"newPasswordEqual")]
        NewPasswordEqual = 5,

        [EnumMember(Value = @"blogLiked")]
        BlogLiked = 6,

        [EnumMember(Value = @"blogNotLike")]
        BlogNotLike = 7,

        [EnumMember(Value = @"companyNotExists")]
        CompanyNotExists = 8,

        [EnumMember(Value = @"companyStatusError")]
        CompanyStatusError = 9,

        [EnumMember(Value = @"companyRegistrationfailure")]
        CompanyRegistrationfailure = 10,

        [EnumMember(Value = @"companyAlreadyExists")]
        CompanyAlreadyExists = 11,

        [EnumMember(Value = @"companyCodeFull")]
        CompanyCodeFull = 12,

        [EnumMember(Value = @"cardError")]
        CardError = 13,

        [EnumMember(Value = @"mailboxSubscribed")]
        MailboxSubscribed = 14,

        [EnumMember(Value = @"faqModelAlreadyExists")]
        FaqModelAlreadyExists = 15,

        [EnumMember(Value = @"faqNotExists")]
        FaqNotExists = 16,

        [EnumMember(Value = @"publicFaqCannotBeUpdate")]
        PublicFaqCannotBeUpdate = 17,

    }
}