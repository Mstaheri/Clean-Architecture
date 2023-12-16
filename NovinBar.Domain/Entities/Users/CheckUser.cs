using NovinBar.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovinBar.Domain.Entities.Users
{
    public class CheckUser
    {
        public static OperationResult FirstName(string firstName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
            {
                return new OperationResult
                {
                    Success = false,
                    Message = ConstMessages.IsNullFirstName
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
        public static OperationResult LastName(string lastName)
        {
            if (string.IsNullOrWhiteSpace(lastName))
            {
                return new OperationResult
                {
                    Success = false,
                    Message = ConstMessages.IsNullLastName
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
        public static OperationResult UserName(string userName)
        {
            if (string.IsNullOrWhiteSpace(userName))
            {
                return new OperationResult
                {
                    Success = false,
                    Message = ConstMessages.IsNullUserName
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
        public static OperationResult Password(string passWord)
        {
            if (string.IsNullOrWhiteSpace(passWord))
            {
                return new OperationResult
                {
                    Success = false,
                    Message = ConstMessages.IsNullPassWord
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
        public static OperationResult PhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                return new OperationResult
                {
                    Success = false,
                    Message = ConstMessages.IsNullPhoneNumber
                };
            }
            else if (Validation.CheckPhoneNumberFormat(phoneNumber))
            {
                return new OperationResult
                {
                    Success = false,
                    Message = ConstMessages.PhoneNumberFormat
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
