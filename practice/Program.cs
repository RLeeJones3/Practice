using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "10@G798H4";
            string userID = "BDowds";

            Console.WriteLine("Please enter your user ID:");
            string userIdInput = Console.ReadLine();

            Console.WriteLine("Please enter your password:");
            string passwordInput = Console.ReadLine();

            if (userIdInput == userID && passwordInput == password)
            {
                Console.WriteLine("Logging in...");
            }
            else
            {
                Console.WriteLine("Incorrect UserID or Password!");
            }
        }
    }
} 