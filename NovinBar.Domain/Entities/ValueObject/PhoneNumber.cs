using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovinBar.Domain.helper;

namespace NovinBar.Domain.Entities.ValueObject
{
    public class PhoneNumber
    {
        public string Value { get; private set; }
        public PhoneNumber(string value)
        {
            var result = CheckSenderPhoneNumber(value);
            if (result.Success == true)
            {
                Value = value;
            }
            else
            {
                throw new Exception(result.Message);
            }
        }
        private OperationResult CheckSenderPhoneNumber(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return new OperationResult
                {
                    Success = false,
                    Message = ConstMessages.IsNullPhoneNumber
                };
            }
            else if (!Validation.CheckPhoneNumberFormat(value))
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
                    Success = true
                };
            }

        }

        public static implicit operator PhoneNumber(string value)
        => new PhoneNumber(value);

        public static implicit operator string(PhoneNumber senderPhoneNumber)
            => senderPhoneNumber.Value;
    }
}
