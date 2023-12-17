using NovinBar.Domain.helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovinBar.Domain.Entities.ValueObject
{
    public class DestinationWarehouse
    {
        public string Value { get; private set; }
        public DestinationWarehouse(string value)
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
                    Message = ConstMessages.IsNullDestinationWarehouse
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

        public static implicit operator DestinationWarehouse(string value)
            => new DestinationWarehouse(value);

        public static implicit operator string(DestinationWarehouse destinationWarehouse)
            => destinationWarehouse.Value;
    }
}
