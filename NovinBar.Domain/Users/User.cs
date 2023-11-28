using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovinBar.Domain.Users
{
    public class User
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string UserName { get; private set; }
        public string PassWord { get; private set; }
        public string PhoneNumber { get; private set; }

        public User(string firstName, string lastName, string userName, string passWord, string phoneNumber)
        {
            if (CheckUserInInsert(firstName, lastName, userName, passWord, phoneNumber))
            {
                FirstName = firstName;
                LastName = lastName;
                UserName = userName;
                PassWord = passWord;
                PhoneNumber = phoneNumber;
            }
            else
            {
                throw new Exception("The data is not valid");
            }
        }
        public void UpdateUser(string firstName, string lastName, string passWord, string phoneNumber)
        {
            if (CheckUserInUpdate(firstName, lastName, passWord, phoneNumber))
            {
                FirstName = firstName;
                LastName = lastName;
                PassWord = passWord;
                PhoneNumber = phoneNumber;
            }
            else
            {
                throw new Exception("The data is not valid");
            }
        }
        private static bool CheckUserInInsert(string firstName, string lastName, string userName, string passWord, string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(passWord))
            {
                return false;
            }
            else if (Validations.Validation.CheckPhoneNumberFormat(phoneNumber))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private static bool CheckUserInUpdate(string firstName, string userName, string passWord, string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(passWord))
            {
                return false;
            }
            else if (Validations.Validation.CheckPhoneNumberFormat(phoneNumber))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
