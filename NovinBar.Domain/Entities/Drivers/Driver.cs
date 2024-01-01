using NovinBar.Domain.Entities.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovinBar.Domain.Entities.Drivers
{
    public class Driver
    {
        public Code DriverCode { get; private set; }
        public Name DriverFirstName { get; private set; }
        public LastName DriverLastName { get; private set; }
        public PhoneNumber DriverPhoneNumber { get; private set; }
        public Payment DriverFee { get; private set; }
        public Driver(Code driverCode, Name driverFirstName, LastName driverLastName, PhoneNumber driverPhoneNumber)
        {
            DriverCode = driverCode;
            DriverFirstName = driverFirstName;
            DriverLastName = driverLastName;
            DriverPhoneNumber = driverPhoneNumber;
        }
        public void UpdateDriver(Name driverFirstName, LastName driverLastName, PhoneNumber driverPhoneNumber)
        {
            DriverFirstName = driverFirstName;
            DriverLastName = driverLastName;
            DriverPhoneNumber = driverPhoneNumber;
        }

    }
}
