using NovinBar.Domain.Entities.SendingShipments;
using NovinBar.Domain.Entities.ValueObject;
using System;
using System.Collections;
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
        public Name SenderFirstName { get; private set; }
        public LastName SenderLastName { get; private set; }
        public PhoneNumber SenderPhoneNumber { get; private set; }
        // Receiver //
        public Name ReceiverFirstName { get; private set; }
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
        public Name? DriverFirstName { get; private set; }
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
        public ICollection<SendingCommoditie> SendingCommodities { get; private set; }


        public SendingShipment(
            Name senderFirstName,
            LastName senderLastName,
            PhoneNumber senderPhoneNumber,
            Name receiverFirstName,
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
            Name? driverFirstName,
            LastName? driverLastName,
            PhoneNumber? driverPhoneNumber,
            Payment? driverFee,
            Payment? prePayment,
            Payment? afterPayment,
            Payment? insurance,
            Payment? storage,
            Payment? packing,
            Payment? interCity)
        {
            SenderFirstName = senderFirstName;
            SenderLastName = senderLastName;
            SenderPhoneNumber = senderPhoneNumber;
            ReceiverFirstName= receiverFirstName;
            ReceiverLastName = receiverLastName;
            ReceiverPhoneNumber = receiverPhoneNumber;
            OriginCity= originCity;
            OriginWarehouse = originWarehouse;
            DestinationCity1= destinationCity1;
            DestinationCity2= destinationCity2;
            DestinationWarehouse1= destinationWarehouse1;
            DestinationWarehouse2= destinationWarehouse2;
            Date= date;
            Time= time;
            DriverFirstName= driverFirstName;
            DriverLastName= driverLastName;
            DriverPhoneNumber= driverPhoneNumber;
            DriverFee= driverFee;
            if (prePayment == null && afterPayment != null ||
                prePayment != null && afterPayment == null)
            {
                PrePayment = prePayment;
                AfterPayment = afterPayment;
            }
            else
            {
                throw new Exception("");
            }
            Insurance= insurance;
            Storage= storage;
            Packing= packing;
            InterCity= interCity;

        }
        public void UpdateSendingShipment(
            Name senderFirstName,
            LastName senderLastName,
            PhoneNumber senderPhoneNumber,
            Name receiverFirstName,
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
            Name? driverFirstName,
            LastName? driverLastName,
            PhoneNumber? driverPhoneNumber,
            Payment? driverFee,
            Payment? prePayment,
            Payment? afterPayment,
            Payment? insurance,
            Payment? storage,
            Payment? packing,
            Payment? interCity)
        {
            SenderFirstName = senderFirstName;
            SenderLastName = senderLastName;
            SenderPhoneNumber = senderPhoneNumber;
            ReceiverFirstName = receiverFirstName;
            ReceiverLastName = receiverLastName;
            ReceiverPhoneNumber = receiverPhoneNumber;
            OriginCity = originCity;
            OriginWarehouse = originWarehouse;
            DestinationCity1 = destinationCity1;
            DestinationCity2 = destinationCity2;
            DestinationWarehouse1 = destinationWarehouse1;
            DestinationWarehouse2 = destinationWarehouse2;
            Date = date;
            Time = time;
            DriverFirstName = driverFirstName;
            DriverLastName = driverLastName;
            DriverPhoneNumber = driverPhoneNumber;
            DriverFee = driverFee;
            if (prePayment == null && afterPayment != null ||
                prePayment != null && afterPayment == null)
            {
                PrePayment = prePayment;
                AfterPayment = afterPayment;
            }
            else
            {
                throw new Exception("");
            }
            Insurance = insurance;
            Storage = storage;
            Packing = packing;
            InterCity = interCity;
        }



    }
}
