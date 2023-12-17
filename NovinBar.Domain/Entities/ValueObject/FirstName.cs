using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovinBar.Domain.helper;

namespace NovinBar.Domain.Entities.ValueObject
{
    public class FirstName
    {
        public string Value { get; private set; }
        public FirstName(string value)
        {
            var result = CheckSenderFirstName(value);
            if (result.Success == true)
            {
                Value = value;
            }
            else
            {
                throw new Exception(result.Message);
            }
        }
        private OperationResult CheckSenderFirstName(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
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
                    Success = true
                };
            }
            
        }

        public static implicit operator FirstName(string value)
        => new FirstName(value);

        public static implicit operator string(FirstName senderFirstName)
            => senderFirstName.Value;
    }
}
