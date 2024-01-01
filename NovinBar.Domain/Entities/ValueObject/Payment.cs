using NovinBar.Domain.helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovinBar.Domain.Entities.ValueObject
{
    public class Payment
    {
        public decimal? Value { get; private set; }
        public Payment(string value)
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                var result = CheckPayment(value);
                if (result.Success == true)
                {
                    Value = int.Parse(value);
                }
                else
                {
                    throw new Exception(result.Message);
                }
            }
            else
            {
                Value = null;
            }

        }
        private OperationResult CheckPayment(string value)
        {
            if (!Validation.CheckNumberFormat(value))
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

        public static implicit operator Payment(string value)
            => new Payment(value);

        public static implicit operator decimal?(Payment senderCode)
            => senderCode.Value;

    }
}
