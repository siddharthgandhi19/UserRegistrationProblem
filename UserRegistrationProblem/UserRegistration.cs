using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    public  class UserRegistration
    {
        const string FIRST_NAME = "^[A-Z]{1}[a-z]{2,}$";
        const string LAST_NAME = "^[A-Z]{1}[a-z]{2,}$";
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
    }
}
