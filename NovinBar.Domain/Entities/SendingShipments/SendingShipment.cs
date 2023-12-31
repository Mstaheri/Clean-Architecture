using NovinBar.Domain.Entities.ValueObject;
using NovinBar.Domain.SendingCommoditys;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NovinBar.Domain.SendingShipments
{
    public class SendingShipment
    {
        [Key]
        public int Barname { get; private set; }
        // Sender //
        public SenderCode? SenderCode { get; private set; }
        public FirstName SenderFirstName { get; private set; }
        public LastName SenderLastName { get; private set; }
        public PhoneNumber SenderPhoneNumber { get; private set; }
        // Receiver //
        public FirstName ReceiverFirstName { get; private set; }
        public LastName ReceiverLastName { get; private set; }
        public PhoneNumber ReceiverPhoneNumber { get; private set; }
        // Origin //
        public OriginCity OriginCity { get; private set; }
        public OriginWarehouse OriginWarehouse { get; private set; }
        // Destination //
        public DestinationCity DestinationCity1 { get; private set; }
        public DestinationWarehouse DestinationWarehouse1 { get; private set; }
        public DestinationCity? DestinationCity2 { get; private set; }
        public DestinationWarehouse? DestinationWarehouse2 { get; private set; }
        // Date and Time //
        public string Date { get; private set; }
        public string Time { get; private set; }
        // Driver //
        public int? DriverCode { get; private set; }
        public FirstName? DriverFirstName { get; private set; }
        public LastName? DriverLastName { get; private set; }
        public PhoneNumber? DriverPhoneNumber { get; private set; }
        public Payment? DriverFee { get; private set; }
        // Payment //
        public Payment? PrePayment { get; private set; }
        public Payment? AfterPayment { get; private set; }
        public Payment? Insurance { get; private set; }
        public Payment? Storage { get; private set; }
        public Payment? Packing { get; private set; }
        public Payment? InterCity { get; private set; }
        public List<SendingCommoditie> SendingCommoditie { get; private set; }

        public SendingShipment(
            SenderCode? senderCode,
            FirstName senderFirstName,
            LastName senderLastName,
            PhoneNumber senderPhoneNumber,
            FirstName receiverFirstName,
            LastName receiverLastName,
            PhoneNumber receiverPhoneNumber,
            OriginCity originCity,
            OriginWarehouse originWarehouse,
            DestinationCity destinationCity1,
            DestinationWarehouse destinationWarehouse1,
            DestinationCity destinationCity2,
            DestinationWarehouse destinationWarehouse2,
            string date,
            string time,
            int? driverCode,
            FirstName? driverFirstName,
            LastName? driverLastName,
            PhoneNumber? driverPhoneNumber,
            Payment? driverFee,
            Payment? orePayment,
            Payment? afterPayment,
            Payment? insurance,
            Payment? storage,
            Payment? oacking,
            Payment? interCity)
        {
            SenderCode = senderCode;
            SenderFirstName = senderFirstName;
            SenderLastName = senderLastName;
            SenderPhoneNumber = senderPhoneNumber;
            ReceiverFirstName= receiverFirstName;
            ReceiverLastName = receiverLastName;
            ReceiverPhoneNumber = receiverPhoneNumber;
            OriginCity= originCity;
            OriginWarehouse = originWarehouse;

        }



    }
}
