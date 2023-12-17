using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovinBar.Domain.Entities.ValueObject
{
    public class SenderCode
    {
        public int Value { get; private set; }
        public SenderCode(int value)
        {
            var result = CheckSenderCode(value);
            if (result.Success == true)
            {
                Value = value;
            }
            else
            {
                throw new Exception(result.Message);
            }
        }
        private OperationResult CheckSenderCode(int value)
        {
            return new OperationResult
            {
                Success = true
            };
        }

        public static implicit operator SenderCode(int value)
            => new SenderCode(value);

        public static implicit operator int(SenderCode senderCode)
            => senderCode.Value;

    }
}
