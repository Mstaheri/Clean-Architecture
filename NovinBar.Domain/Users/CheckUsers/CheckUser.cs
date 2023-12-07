using NovinBar.Domain.OperationResults;
using NovinBar.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovinBar.Domain.Validations
{
    public class CheckUser
    {
        public CheckUser()
        {

        }

        public static OperationResult CheckUserFirstName(string firstName)
        {
            if (string.IsNullOrEmpty(firstName))
            {
                return new OperationResult
                {
                    Success = false,
                    Message = "نام را وارد کنید"
                };
            }
            else
            {
                return new OperationResult
                {
                    Success = true,
                };
            }
        }
        public static OperationResult CheckUserLastName(string lastName)
        {
            if (string.IsNullOrEmpty(lastName))
            {
                return new OperationResult
                {
                    Success = false,
                    Message = "نام خانوادگی را وارد کنید"
                };
            }
            else
            {
                return new OperationResult
                {
                    Success = true,
                };
            }
        }
        public static OperationResult CheckUserUserName(string userName)
        {
            if (string.IsNullOrEmpty(userName))
            {
                return new OperationResult
                {
                    Success = false,
                    Message = "نام کاربری را وارد کنید"
                };
            }
            else
            {
                return new OperationResult
                {
                    Success = true,
                };
            }
        }
        public static OperationResult CheckUserPassword(string passWord)
        {
            if (string.IsNullOrEmpty(passWord))
            {
                return new OperationResult
                {
                    Success = false,
                    Message = "رمز عبور را وارد کنید"
                };
            }
            else
            {
                return new OperationResult
                {
                    Success = true,
                };
            }
        }
        public static OperationResult CheckPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrEmpty(phoneNumber))
            {
                return new OperationResult
                {
                    Success = false,
                    Message = "شماره تلفن را وارد کنید"
                };
            }
            else if (Validation.CheckPhoneNumberFormat(phoneNumber))
            {
                return new OperationResult
                {
                    Success = false,
                    Message = "شماره موبایل را درست وارد کنید"
                };
            }
            else
            {
                return new OperationResult
                {
                    Success = true,
                };
            }
        }
    }
    
}
