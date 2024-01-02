using NovinBar.Domain.Entities.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovinBar.Domain.Entities.SendingShipments
{
    public class SendingCommoditie
    {
        public Code Code { get; private set; }
        public int Barname { get; private set; }
        public Name Name { get; private set; }
        public Number Number { get; private set; }
        public Payment? Value { get; private set; }
        public SendingCommoditie(Code code, int barname , Name name, Number number, Payment? value)
        {
            Code = code;
            Barname = barname;
            Name = name;
            Number = number;
            Value = value;
        }
        public void UpdateSendingCommoditie(Name name, Number number, Payment? value)
        {
            Name = name;
            Number = number;
            Value = value;
        }

    }
}
