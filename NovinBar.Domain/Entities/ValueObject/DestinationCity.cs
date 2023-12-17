using NovinBar.Domain.helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovinBar.Domain.Entities.ValueObject
{
    public class DestinationCity
    {
        public string Value { get; private set; }
        public DestinationCity(string value)
        {
            var result = CheckDestinationCity(value);
            if (result.Success == true)
            {
                Value = value;
            }
            else
            {
                throw new Exception(result.Message);
            }
        }
        private OperationResult CheckDestinationCity(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return new OperationResult
                {
                    Success = false,
                    Message = ConstMessages.IsNullDestinationCity
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

        public static implicit operator DestinationCity(string value)
            => new DestinationCity(value);

        public static implicit operator string(DestinationCity destinationCity)
            => destinationCity.Value;
    }
}
