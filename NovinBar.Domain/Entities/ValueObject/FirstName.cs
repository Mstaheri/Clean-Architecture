using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovinBar.Domain.Entities.ValueObject
{
    public class SenderFirstName
    {
        public string Value { get; private set; }
        public SenderFirstName(string value)
        {
            var result = CheckSenderFirstName(value);
            if (result.Success == true)
            {

            }
            else
            {

            }
        }
        private OperationResult CheckSenderFirstName(string value)
        {
            return new OperationResult
            {
                Success = true,
            };
        }

        public static implicit operator SenderFirstName(string value)
        => new SenderFirstName(value);

        public static implicit operator string(SenderFirstName senderFirstName)
            => senderFirstName.Value;
    }
}
