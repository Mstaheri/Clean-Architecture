using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovinBar.Domain.SendingShipments
{
    public class SendingShipment
    {
        [Key]
        public int Barname { get; private set; }
        public int? SenderCode { get; private set; }
        public string SenderFirstName { get; private set; }
        public string SenderLastName { get; private set; }
        public string SenderPhoneNumber { get; private set; }
        public string ReceiverFirstName { get; private set; }
        public string ReceiverLastName { get; private set; }
        public string ReceiverPhoneNumber { get; private set; }
        
    }
}
