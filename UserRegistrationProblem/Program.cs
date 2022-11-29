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
                Console.WriteLine(" 1. First Name");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter First Name");
                        string opt = Convert.ToString(Console.ReadLine());
                        UserRegistration firstname = new UserRegistration();
                        firstname.FirstName(opt);
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
