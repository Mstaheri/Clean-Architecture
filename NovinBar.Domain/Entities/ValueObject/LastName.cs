using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovinBar.Domain.helper;

namespace NovinBar.Domain.Entities.ValueObject
{
    public class LastName
    {
        public string Value { get; private set; }
        public LastName(string value)
        {
            var result = CheckSenderLastName(value);
            if (result.Success == true)
            {
                Value = value;
            }
            else
            {
                throw new Exception(result.Message);
            }
        }
        private OperationResult CheckSenderLastName(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
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
                    Success = true
                };
            }

        }

        public static implicit operator LastName(string value)
        => new LastName(value);

        public static implicit operator string(LastName senderLastName)
            => senderLastName.Value;
    }
}
