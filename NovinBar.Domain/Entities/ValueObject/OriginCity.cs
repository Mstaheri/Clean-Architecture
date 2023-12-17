using NovinBar.Domain.helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovinBar.Domain.Entities.ValueObject
{
    public class OriginCity
    {
        public string Value { get; private set; }
        public OriginCity(string value)
        {
            var result = CheckOriginCity(value);
            if (result.Success == true)
            {
                Value = value;
            }
            else
            {
                throw new Exception(result.Message);
            }
        }
        private OperationResult CheckOriginCity(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return new OperationResult
                {
                    Success = false,
                    Message = ConstMessages.IsNullOriginCity
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

        public static implicit operator OriginCity(string value)
            => new OriginCity(value);

        public static implicit operator string(OriginCity originCity)
            => originCity.Value;
    }
}
