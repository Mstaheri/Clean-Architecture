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
        public string? Value { get; private set; }
        public DestinationWarehouse(string value)
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                //var result = CheckOriginWarehouse(value);
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
                Value= null;
            }
            
        }
        //private OperationResult CheckOriginWarehouse(string value)
        //{
            
        //}

        public static implicit operator DestinationWarehouse(string value)
            => new DestinationWarehouse(value);

        public static implicit operator string?(DestinationWarehouse destinationWarehouse)
            => destinationWarehouse.Value;
    }
}
