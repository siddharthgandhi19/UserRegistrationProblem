using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    public class UserRegistration
    {
        const string FIRST_NAME = "^[A-Z]{1}[a-z]{2,}$";
        const string LAST_NAME = "^[A-Z]{1}[a-z]{2,}$";
        const string EMAIL = "^[a-z]{3,}[.]{0,}[a-z]{0,}[@]{1}[a-z]{2,}[.]{1}[a-z]{2,}[.]{0,}[a-z]{0,}$";
        const string MOBILE_NUMBER = "^[0-9]{2}[ ]{1}[0-9]{10}$";
        const string PASSWORD_PROTECTED = "^(?=.*[!@#$%])(?=.*[0-9])(?=.*[A-Z])[A-Za-z0-9!@#$%]{8,}$";
        const string EMAIL_VALIDATING = "^[a-zA-Z]+[.+_-]{0,1}[a-z0-9]+[@][a-zA-Z0-9]+[.][a-z]{2,3}([.][a-z]{2,3}){0,1}$";
        string[] emailsValidList;
        //const string PASSWORD_PROTECTED = "^[a-z]{8,}$"; (?=.*[0-9])  (?=.*[A-Z])//at least one

        public void FirstName(string input)
        {
            if (Regex.IsMatch(input, FIRST_NAME))
                Console.WriteLine("First Name : " + input);
            else
                Console.WriteLine("Enter First Name In Valid Format");
        }
        public void LastName(string input)
        {
            if (Regex.IsMatch(input, LAST_NAME))
                Console.WriteLine("Last Name : " + input);
            else
                Console.WriteLine("Enter Last Name In Valid Format");
        }
        public void Email(string input)
        {
            if (Regex.IsMatch(input, EMAIL))
                Console.WriteLine("Email : " + input);
            else
                Console.WriteLine("Enter Email In Valid Format");
        }
        public void Mobile(string input)
        {
            if (Regex.IsMatch(input, MOBILE_NUMBER))
                Console.WriteLine("Mobile Number : " + input);
            else
                Console.WriteLine("Enter Mobile Number In Valid Format");
        }
        public void Password(string input)
        {
            if (Regex.IsMatch(input, PASSWORD_PROTECTED))
                Console.WriteLine("Password : " + input);
            else
                Console.WriteLine("Password Length Should Be Min. 8 Characters. Enter Again");
        }
        public void ReadEmailsData(string filepath)
        {
            var email = File.ReadAllText(filepath);
            emailsValidList = email.Split(",");
            ValidateEmailData(emailsValidList);
        }
        public void ValidateEmailData(string[] input)
        {
            foreach (var email in input)
            {
                if (Regex.IsMatch(email, EMAIL_VALIDATING))
                    Console.WriteLine("{0} as Email Id is valid", email);
                else
                    Console.WriteLine("{0} as Email Id is invalid ", email);
            }
        }
        public bool RegisterationThroughLambdaMethod(string name) => Regex.IsMatch(name, "^[A-Z]{1}[a-z]{2,}$") ? true : false;

    }
}
