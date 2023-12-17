using NovinBar.Domain.helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovinBar.Domain.Entities.ValueObject
{
    public class OriginWarehouse
    {
        public string Value { get; private set; }
        public OriginWarehouse(string value)
        {
            var result = CheckOriginWarehouse(value);
            if (result.Success == true)
            {
                Value = value;
            }
            else
            {
                throw new Exception(result.Message);
            }
        }
        private OperationResult CheckOriginWarehouse(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return new OperationResult
                {
                    Success = false,
                    Message = ConstMessages.IsNullOriginWarehouse
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

        public static implicit operator OriginWarehouse(string value)
            => new OriginWarehouse(value);

        public static implicit operator string(OriginWarehouse originWarehouse)
            => originWarehouse.Value;
    }
}
