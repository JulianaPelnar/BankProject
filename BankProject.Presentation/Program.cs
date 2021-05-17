﻿using System;

namespace BankProject.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------- Bank -------------------------");
            Console.WriteLine("::Login Page::");

            string userName = null; string password = null;

            Console.Write("Username: ");
            userName = Console.ReadLine();

            if(userName != "")
            {
                Console.Write("Password: ");
                password = Console.ReadLine();
            }

            if (userName == "system" && password == "manager")
            {
                int mainMenuChoice = -1;
                do
                {
                    Console.WriteLine("\n :::Main menu here:::");
                    Console.WriteLine("1. Customers");
                    Console.WriteLine("2. Accounts");
                    Console.WriteLine("3. Funds Transfer");
                    Console.WriteLine("4. Funds Transfer Statement");
                    Console.WriteLine("5. Account Statement");
                    Console.WriteLine("0. Exit");

                    Console.Write("Enter choice: ");
                    mainMenuChoice = int.Parse(Console.ReadLine());

                    switch (mainMenuChoice)
                    {
                        case 1:
                            CustomersMenu();
                            break;
                        case 2:
                            AccountsMenu();
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            break;
                        default:
                            break;
                    }
                } while (mainMenuChoice != 0);
            }
            else
            {
                Console.WriteLine("Invalid username or password");
            }

                Console.WriteLine("Thank you! Visit again.");
            Console.ReadKey();

            static void CustomersMenu()
            {
                int customerMenuChoice = -1;
                do
                {
                    Console.WriteLine("\n:::Customers menu:::");
                    Console.WriteLine("1. Add Customer");
                    Console.WriteLine("2. Delete Customer");
                    Console.WriteLine("3. Update Customer");
                    Console.WriteLine("4. View Customers");
                    Console.WriteLine("0. Back to Main Menu");

                    Console.Write("Enter choice: ");
                    customerMenuChoice = Convert.ToInt32(Console.ReadLine());
                } while (customerMenuChoice != 0);
            }

            static void AccountsMenu()
            {
                int accountMenuChoice = -1;
                do
                {
                    Console.WriteLine("\n:::Accounts menu:::");
                    Console.WriteLine("1. Add Account");
                    Console.WriteLine("2. Delete Account");
                    Console.WriteLine("3. Update Account");
                    Console.WriteLine("4. View Accounts");
                    Console.WriteLine("0. Back to Main Menu");

                    Console.Write("Enter choice: ");
                    accountMenuChoice = Convert.ToInt32(Console.ReadLine());
                } while (accountMenuChoice != 0);
            }
        }
    }
}
