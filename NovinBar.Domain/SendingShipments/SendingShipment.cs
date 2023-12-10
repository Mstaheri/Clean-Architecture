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
        public int? SenderCode { get; private set; }
        public string SenderFirstName { get; private set; }
        public string SenderLastName { get; private set; }
        public string SenderPhoneNumber { get; private set; }
        // Receiver //
        public string ReceiverFirstName { get; private set; }
        public string ReceiverLastName { get; private set; }
        public string ReceiverPhoneNumber { get; private set; }
        // Origin //
        public string OriginCity { get; private set; }
        public string OriginWarehouse { get; private set; }
        // Destination //
        public string DestinationCity1 { get; private set; }
        public string DestinationWarehouse1 { get; private set; }
        public string? DestinationCity2 { get; private set; }
        public string? DestinationWarehouse2 { get; private set; }
        // Date and Time //
        public string Date { get; private set; }
        public string Time { get; private set; }
        // Driver //
        public int? DriverCode { get; private set; }
        public string? DriverFirstName { get; private set; }
        public string? DriverLastName { get; private set; }
        public string? DriverPhoneNumber { get; private set; }
        public decimal? DriverFee { get; private set; }
        // Payment //
        public decimal? PrePayment { get; private set; }
        public decimal? AfterPayment { get; private set; }
        public decimal? Insurance { get; private set; }
        public decimal? Storage { get; private set; }
        public decimal? packing { get; private set; }
        public decimal? InterCity { get; private set; }
        public SendingShipment()
        {

        }



    }
}
