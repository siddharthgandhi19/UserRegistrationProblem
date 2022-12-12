using System;
using System.Reflection.Metadata;

namespace UserRegistrationProblem
{
    class Program
    {
        public static string emailsFilePath = @"E:\Bridgelabz\UserRegistrationProblem\UserRegistrationProblem\emailsValidList.txt";
      
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Problem Statements");
            Console.WriteLine("Select Below Mention Options");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine(" 1. First Name\n 2. LastName\n 3. Email\n 4. Mobile Number\n 5. Password\n 6. Valid Email Showcase\n 7.Registeration Through Lambda Method");
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
                    case 4:
                        Console.WriteLine("Enter Mobile Number");
                        string opt3 = Convert.ToString(Console.ReadLine());
                        UserRegistration mobile = new UserRegistration();
                        mobile.Mobile(opt3);
                        break;
                    case 5:
                        Console.WriteLine("Enter Password");
                        string opt4 = Convert.ToString(Console.ReadLine());
                        UserRegistration password = new UserRegistration();
                        password.Password(opt4);
                        break;
                    case 6:
                        UserRegistration validEmail = new UserRegistration();
                        validEmail.ReadEmailsData(emailsFilePath);
                        break;
                    case 7:
                        UserRegistration userRegistration = new UserRegistration();
                        userRegistration.RegisterationThroughLambdaMethod("Sid");
                        Console.WriteLine("Enter Below Data");
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
