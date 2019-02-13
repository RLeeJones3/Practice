using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int password = 123;
            string userID = "BDowds";

            Console.WriteLine("Please enter your user ID:");
            string userIdInput = Console.ReadLine();

            Console.WriteLine("Please enter your password:");
            int passwordInput = int.Parse(Console.ReadLine());

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