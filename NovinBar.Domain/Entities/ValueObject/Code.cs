using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovinBar.Domain.helper;

namespace NovinBar.Domain.Entities.ValueObject
{
    public class SenderCode
    {
        public int Value { get; private set; }
        public SenderCode(string value)
        {
            var result = CheckSenderCode(value);
            if (result.Success == true)
            {
                Value = int.Parse(value);
            }
            else
            {
                throw new Exception(result.Message);
            }
        }
        private OperationResult CheckSenderCode(string value)
        {
            if (Validation.CheckNumberFormat(value))
            {
                return new OperationResult
                {
                    Success = false,
                    Message = ConstMessages.IsNullCodeSender
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

        public static implicit operator SenderCode(string value)
            =>  new SenderCode(value);

        public static implicit operator int(SenderCode senderCode)
            => senderCode.Value;
        
    }
}
