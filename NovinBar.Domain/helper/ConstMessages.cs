using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovinBar.Domain.helper
{
    public class ConstMessages
    {
        // IsNull
        public const string IsNullFirstName = "شما نام را وارد نکردید";
        public const string IsNullLastName = "شما نام خانوادگی را وارد نکردید";
        public const string IsNullUserName = "شما نام کاربری را وارد نکردید";
        public const string IsNullPassWord = "شما رمز عبور را وارد نکردید";
        public const string IsNullPhoneNumber = "شما شماره همراه را وارد نکردید";
        public const string IsNullOriginCity = "شما شهر مبدا را وارد نکردید";
        public const string IsNullOriginWarehouse = "شما انبار مبدا را وارد نکردید";
        public const string IsNullDestinationCity = "شما شهر مقصد را وارد نکردید";
        public const string IsNullDestinationWarehouse = "شما انبار مقصد را وارد نکردید";
        public const string IsNullCodeSender = "شما کد فرستنده را وارد نکردید";

        //Format
        public const string PhoneNumberFormat = "شماره موبایل را درست وارد کنید";

        //Eror
        public const string ErorInDB = "خطایی رخ داده است";
    }
}
