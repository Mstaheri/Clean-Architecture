using NovinBar.Domain.OperationResults;
using NovinBar.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovinBar.Domain.Entities.SendingShipments
{
    public class CheckSendingShipment
    {
        public static OperationResult Barname(string Barname)
        {
            if (string.IsNullOrWhiteSpace(Barname))
            {
                return new OperationResult
                {
                    Success = false,
                    Message = "بارنامه را وارد کنید"
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
        // Sender //
        public static OperationResult SenderCode(string Code)
        {
            if (string.IsNullOrWhiteSpace(Code))
            {
                return new OperationResult
                {
                    Success = false,
                    Message = "کد فرستنده را وارد کنید"
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
        public static OperationResult SenderFirstName(string FirstName)
        {
            if (string.IsNullOrWhiteSpace(FirstName))
            {
                return new OperationResult
                {
                    Success = false,
                    Message = "نام فرستنده را وارد کنید"
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
        public static OperationResult SenderLastName(string LastName)
        {
            if (string.IsNullOrWhiteSpace(LastName))
            {
                return new OperationResult
                {
                    Success = false,
                    Message = "فامیلی فرستنده را وارد کنید"
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
        public static OperationResult SenderPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                return new OperationResult
                {
                    Success = false,
                    Message = "شماره تلفن فرستنده را وارد کنید"
                };
            }
            else if (Validation.CheckPhoneNumberFormat(phoneNumber))
            {
                return new OperationResult
                {
                    Success = false,
                    Message = "شماره موبایل فرستنده را درست وارد کنید"
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
