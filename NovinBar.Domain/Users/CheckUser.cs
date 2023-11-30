using NovinBar.Domain.OperationResults;
using NovinBar.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovinBar.Domain.Validations
{
    public class CheckUser
    {
        public CheckUser()
        {

        }

        public static void CheckUserFirstName(string firstName)
        {
            if (string.IsNullOrEmpty(firstName))
            {
                throw new Exception("");
            }
        }
        public static void CheckUserLastName(string lastName)
        {
            if (string.IsNullOrEmpty(lastName))
            {
                throw new Exception("");
            }
        }
        public static void CheckUserUserName(string userName)
        {
            if (string.IsNullOrEmpty(userName))
            {
                throw new Exception("");
            }
        }
        public static void CheckUserPassword(string passWord)
        {
            if (string.IsNullOrEmpty(passWord))
            {
                throw new Exception("");
            }
        }
        public static void CheckPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrEmpty(phoneNumber))
            {
                throw new Exception("");
            }
            else if (Validation.CheckPhoneNumberFormat(phoneNumber))
            {
                throw new Exception("");
            }
        }
    }
    
}
