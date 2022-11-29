using System;
using System.Reflection.Metadata;

namespace UserRegistrationProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Problem Statements");
            Console.WriteLine("Select Below Mention Options");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine(" 1. First Name\n 2. LastName\n 3. Email");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter First Name");
                        string opt = Convert.ToString(Console.ReadLine());
                        UserRegistration firstname = new UserRegistration();
                        firstname.FirstName(opt);
                        break;
                    case 2:
                        Console.WriteLine("Enter Last Name");
                        string opt1 = Convert.ToString(Console.ReadLine());
                        UserRegistration lastname = new UserRegistration();
                        lastname.LastName(opt1);
                        break;
                    case 3:
                        Console.WriteLine("Enter Email");
                        string opt2 = Convert.ToString(Console.ReadLine());
                        UserRegistration email = new UserRegistration();
                        email.Email(opt2);
                        break;
                    default:
                        flag = false;
                        Console.WriteLine("Try Again");
                        break;
                }

            }

        }
    }
}
