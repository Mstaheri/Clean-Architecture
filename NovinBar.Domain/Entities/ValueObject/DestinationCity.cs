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
        public string? Value { get; private set; }
        public DestinationCity(string value)
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                //var result = CheckDestinationCity(value);
                //if (result.Success == true)
                //{
                //    Value = value;
                //}
                //else
                //{
                //    throw new Exception(result.Message);
                //}
            }
            else
            {
                Value = null;
            }
            
        }
        //private OperationResult CheckDestinationCity(string value)
        //{
            
        //}

        public static implicit operator DestinationCity(string value)
            => new DestinationCity(value);

        public static implicit operator string?(DestinationCity destinationCity)
            => destinationCity.Value;
    }
}
