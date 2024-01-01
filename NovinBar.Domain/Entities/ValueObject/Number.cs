using NovinBar.Domain.helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovinBar.Domain.Entities.ValueObject
{
    public class Number
    {
        public int Value { get; private set; }
        public Number(string value)
        {
            var result = CheckNumber(value);
            if (result.Success == true)
            {
                Value = int.Parse(value);
            }
            else
            {
                throw new Exception(result.Message);
            }

        }
        private OperationResult CheckNumber(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return new OperationResult
                {
                    Success = false,
                    Message = ConstMessages.Number
                };
            }
            else if (!Validation.CheckNumberFormat(value))
            {
                return new OperationResult
                {
                    Success = false,
                    Message = ConstMessages.Payment
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

        public static implicit operator Number(string value)
            => new Number(value);

        public static implicit operator int(Number senderCode)
            => senderCode.Value;
    }
}
