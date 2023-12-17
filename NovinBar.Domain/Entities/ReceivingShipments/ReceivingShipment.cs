using NovinBar.Domain.Entities.ValueObject;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovinBar.Domain.Entities.ReceivingShipments
{
    public class ReceivingShipment
    {
        [Key]
        public int Code { get; private set; }
        public int Barname { get; private set; }
        // Sender //
        public FirstName SenderFirstName { get; private set; }
        public LastName SenderLastName { get; private set; }
        public PhoneNumber SenderPhoneNumber { get; private set; }
        // Receiver //
        public FirstName ReceiverFirstName { get; private set; }
        public LastName ReceiverLastName { get; private set; }
        public PhoneNumber ReceiverPhoneNumber { get; private set; }
        // Origin //
        public OriginCity OriginCity { get; private set; }
        // Destination //
        public DestinationCity DestinationCity { get; private set; }
        // Date and Time //
        public string Date { get; private set; }
        public string Time { get; private set; }
        // Driver //
        public int? DriverCode { get; private set; }
        public FirstName? DriverFirstName { get; private set; }
        public LastName? DriverLastName { get; private set; }
        public PhoneNumber? DriverPhoneNumber { get; private set; }
        // Payment //
        public decimal? PrePayment { get; private set; }
        public decimal? AfterPayment { get; private set; }
        public decimal? Insurance { get; private set; }
        public decimal? Storage { get; private set; }
        public decimal? packing { get; private set; }
        public decimal? InterCity { get; private set; }
        // Authentication
        public string? AuthenticationMethod { get; private set; }
        public string? AuthenticationText { get; private set; }
        public ReceivingShipment(SenderCode? senderCode, FirstName senderFirstName, LastName SenderLastName
            , PhoneNumber senderPhoneNumber, FirstName receiverFirstName)
        {

        }
    }
}
