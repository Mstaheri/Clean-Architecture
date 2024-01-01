using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovinBar.Domain.helper;

namespace NovinBar.Domain.Entities.ValueObject
{
    public class Name
    {
        public string Value { get; private set; }
        public Name(string value)
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
                    Message = ConstMessages.IsNullName
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

        public static implicit operator Name(string value)
        => new Name(value);

        public static implicit operator string(Name senderFirstName)
            => senderFirstName.Value;
    }
}
