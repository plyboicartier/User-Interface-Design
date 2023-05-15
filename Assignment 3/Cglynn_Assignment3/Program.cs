// Carter Glynn
// PROG2325 User Interface
// Assignment 3 - Sales/Orders
// Created 2022 - 10 - 11

using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Net;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
class Order 
{
    public static string name;
    public static string phone;
    public static string prod1Str;
    public static string prod2Str;
    public static int prod1Int;
    public static int prod2Int;
    public static int subtotal;
    
    public static void Prompt () //prompts salesperson to do another or quit
    {
        Console.WriteLine("\nWould you like to accept another order?\n\t1. Start another order\n\t2. Exit program");
        int option = Convert.ToInt32(Console.ReadLine());
        if (option == 1)
        {
            Sales.Main();
        }
        else if (option == 2)
        {
            Sales.flag = false;
            Sales.Main();
        }
        else
        {
            Console.WriteLine("Invalid input.");
            Prompt();
        }

    }

    public static bool NameVerify(string name) //checks for letter charaters only
    {
        Regex regex = new Regex(@"^[A-Za-z ]+$");
        return regex.IsMatch(name);
    }
    public static bool NumberVerify(string num) //checks for digits only
    {
        Regex regex = new Regex(@"^[0-9]+$");
        return regex.IsMatch(num);
    }
}

class  Delivery : Order
{
    public static string address;
    public static string postCode;
    public void InsertAddress ()
    {
        Console.Clear();
        Console.Write("\nEnter 'b' to go back to Main Menu\nPlease enter street address: ");
        address = Console.ReadLine();
        Console.Clear();
        if (address == "b")
        {
            Console.Clear();
            Sales.Main();
        }
        do
        {
            Console.Write("\nEnter 'b' to go back to Main Menu\nPlease enter postal code: ");
            postCode = Console.ReadLine();
            if (PostcodeVerify(postCode) == false)
            {
                Console.Clear();
                Console.WriteLine("Invalid character input, remember a postal code looks like: L3L 2N2");
            }
        } while (PostcodeVerify(postCode) == false);
    }
    public static bool PostcodeVerify(string posCode)
    {
        Regex regex = new Regex(@"^[ABCEGHJKLMNPRSTVXY][0-9][ABCEGHJKLMNPRSTVWXYZ] ?[0-9][ABCEGHJKLMNPRSTVWXYZ][0-9]+$"); 
        return regex.IsMatch(posCode);
    }
    public void InsertInfo() //putting info into object
    {
        do //do while for name
        {
            Console.Clear();
            Console.Write("Enter 'b' to go back to Main Menu\nEnter name for order: ");
            name = Console.ReadLine();
            if (name == "b")
            {
                Sales.Main();
            }
            Console.Clear();
        } while (NameVerify(name) == false);
        do //do while for phone number
        {
            Console.Write("Enter 'b' to go back to Main Menu\nEnter phone number for order: ");
            phone = Console.ReadLine();
            int length = phone.Length;
            if (phone == "b")
            {
                Sales.Main();
            }
            Console.Clear();
            if (length == 10)
            {
                try
                {
                    int phoneInt = Convert.ToInt32(phone);
                }
                catch (OverflowException)
                {
                    Console.WriteLine("\nNumber is either too large or too small");
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nInvalid key entry");
                }
            }
            else if (length < 10)
            {
                Console.WriteLine("Phone number is too long! Pleade enter the number as one long 10 digit number!");
            }
            else if (length > 10)
            {
                Console.WriteLine("Phone number is too short! Pleade enter the number as one long 10 digit number!");
            }
        } while (NumberVerify(phone) == false);
        Console.Write("Enter 'b' to go back to Main Menu\nPlease insert quantity number of product 1: ");
        string prod1Str = Console.ReadLine();
        do //do while for product 1
        {
            if (prod1Str == "b")
            {
                Sales.Main();
            }
            Console.Clear();
            try
            {
                prod1Int = Convert.ToInt32(prod1Str);
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nNumber is either too large or too small");
                InsertInfo();
            }
            catch (FormatException)
            {
                Console.WriteLine("\nInvalid key entry");
                InsertInfo();
            }
        } while (NumberVerify(prod1Str) == false);
        Console.Write("Enter 'b' to go back to Main Menu\nPlease insert quantity number of product 2: ");
        string prod2Str = Console.ReadLine();
        do //do while for product 2
        {
            if (prod2Str == "b")
            {
                Sales.Main();
            }
            Console.Clear();
            try
            {
                prod2Int = Convert.ToInt32(prod2Str);
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nNumber is either too large or too small");
                InsertInfo();
            }
            catch (FormatException)
            {
                Console.WriteLine("\nInvalid key entry");
                InsertInfo();
            }
        } while (NumberVerify(prod2Str) == false);
        PrintReceipt();
    }
    public void PrintReceipt()
    {
        Console.Clear();
        Console.WriteLine("\t**********************************************************\t");
        Console.WriteLine("\t*\t\t\tRecepit\t\t\t\t*");
        Console.WriteLine("\t**********************************************************\t");
        Console.WriteLine("\t*\t\t{0}\t\t*\t", name);
        Console.WriteLine("\t*\t\t\t{0}\t\t\t\t*\t", phone);
        Console.WriteLine("\t*\t\t\t\t\t\t*\t");
        Console.WriteLine("\t*\tProduct 1 ({0})...................${1}\t*\t", prod1Int, prod1Int * 5);
        Console.WriteLine("\t*\t\t\t\t\t\t\t*\t");
        Console.WriteLine("\t*\tProduct 2 ({0})...................${1}\t*\t", prod2Int, prod2Int * 10);
        Console.WriteLine("\t*\t\t\t\t\t\t\t*\t");
        Console.WriteLine("\t*\t\t\t\t\t\t\t*\t");
        Console.WriteLine("\t*\tDelivery Fee ........................$15\t*\t");
        Console.WriteLine("\t*\t\t\t\t\t\t\t*\t");
        Console.WriteLine("\t*\t\t\t\t\t\t\t*\t");
        subtotal += 15 + (prod1Int * 5) + (prod2Int * 10);
        Console.WriteLine("\t*\tSubtotal...........................${0}\t\t*\t", subtotal);
        Console.WriteLine("\t*\t\t\t\t\t\t\t*\t");
        Console.WriteLine("\t*\tTotal..............................${0}\t*\t", subtotal * 1.13);
        Console.WriteLine("\t*\t\t\t\t\t\t\t*\t");
        Console.WriteLine("\t*\t\t\t{0}\t\t*\t", address);
        Console.WriteLine("\t*\t\t\t{0}\t\t\t\t*\t", postCode);
        Console.WriteLine("\t*\t\t\t\t\t\t\t*\t");
        Console.WriteLine("\t**********************************************************\t");
        Prompt();
    }
}
class PickUp : Order
{
    public static string dateString;
    public void InsertTime()
    {
        Console.Clear();
        Console.Write("Please enter time in YYYY/MM/DD HH:MM (24 hour clock): ");
        CultureInfo enUS = new CultureInfo("en-US");
        dateString = Console.ReadLine();
        DateTime result;
        if (DateTime.TryParseExact(dateString, "yyyy/M/d H:m", enUS, DateTimeStyles.None, out result))
        {
            Console.WriteLine("Time has been set!");
        }
        else
        {
            Console.WriteLine("{0} is not in the correct format.", dateString);
            InsertTime();
        }
    }
    public void InsertInfo() //putting info into object
    {
        do //do while for name
        {
            Console.Clear();
            Console.Write("Enter 'b' to go back to Main Menu\nEnter name for order: ");
            name = Console.ReadLine();
            if (name == "b")
            {
                Sales.Main();
            }
            Console.Clear();
        } while (NameVerify(name) == false);
        do //do while for phone number
        {
            Console.Write("Enter 'b' to go back to Main Menu\nEnter phone number for order: ");
            phone = Console.ReadLine();
            int length = phone.Length;
            if (phone == "b")
            {
                Sales.Main();
            }
            Console.Clear();
            if (length == 10)
            {
                try
                {
                    long phoneInt = Convert.ToInt64(phone);
                }
                catch (OverflowException)
                {
                    Console.WriteLine("\nNumber is either too large or too small");
                    InsertInfo();
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nInvalid key entry");
                    InsertInfo();
                }
            }
            else if (length < 10)
            {
                Console.WriteLine("Phone number is too long! Pleade enter the number as one long 10 digit number!");
            }
            else if (length > 10)
            {
                Console.WriteLine("Phone number is too short! Pleade enter the number as one long 10 digit number!");
            }
        } while (NumberVerify(phone) == false);

        Console.Write("Enter 'b' to go back to Main Menu\nPlease insert quantity number of product 1: ");
        string prod1Str = Console.ReadLine();
        do //do while for product 1
        {
            if (prod1Str == "b")
            {
                Sales.Main();
            }
            Console.Clear();
            try
            {
                prod1Int = Convert.ToInt32(prod1Str);
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nNumber is either too large or too small");
                InsertInfo();
            }
            catch (FormatException)
            {
                Console.WriteLine("\nInvalid key entry");
                InsertInfo();
            }
        } while (NumberVerify(prod1Str) == false);
        Console.Write("Enter 'b' to go back to Main Menu\nPlease insert quantity number of product 2: ");
        string prod2Str = Console.ReadLine();
        do //do while for product 2
        {
            if (prod2Str == "b")
            {
                Sales.Main();
            }
            Console.Clear();
            try
            {
                prod2Int = Convert.ToInt32(prod2Str);
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nNumber is either too large or too small");
            }
            catch (FormatException)
            {
                Console.WriteLine("\nInvalid key entry");
            }
        } while (NumberVerify(prod2Str) == false);
        PrintReceipt();
    }
    public void PrintReceipt()
    {
        Console.Clear();
        Console.WriteLine("\t*****************************************************\t");
        Console.WriteLine("*\t\t\tRecepit\t\t\t*");
        Console.WriteLine("\t*****************************************************\t");
        Console.WriteLine("\t*\t\t{0}\t\t*\t", name);
        Console.WriteLine("\t*\t\t{0}\t\t*\t", phone);
        Console.WriteLine("\t*\t\t\t\t\t*\t");
        Console.WriteLine("\t*\tProduct 1 ({0})...................${1}\t*\t", prod1Int, prod1Int * 5);
        Console.WriteLine("\t*\t\t\t\t\t*\t");
        Console.WriteLine("\t*\tProduct 2 ({0})...................${1}\t*\t", prod2Int, prod2Int * 10);
        Console.WriteLine("\t*\t\t\t\t\t*\t");
        Console.WriteLine("\t*\t\t\t\t\t*\t");
        subtotal += (prod1Int * 5) + (prod2Int * 10);
        Console.WriteLine("\t*\tSubtotal...........................${0}\t*\t", subtotal);
        Console.WriteLine("\t*\t\t\t\t\t*\t");
        Console.WriteLine("\t*\tTotal..............................${0}\t*\t", subtotal * 1.13);
        Console.WriteLine("\t*\t\t\t\t\t*\t");
        Console.WriteLine("\t*\tPick-Up Time: {0}\t\t*\t", dateString);
        Console.WriteLine("\t*\t\t\t\t\t*\t");
        Console.WriteLine("\t*****************************************************\t");
        Prompt();
    }
}
class Sales 
{
    public static bool flag = true;
    public static int Main()
    {
        if (flag == false)
        {
            return 0;
        }
        do
        {
            Console.Clear();
            Console.WriteLine("Welcome to Sales Program! Please choose an option. \n\t1. Customer is picking-up their order\n\t2. Customer is having the order delivered\n\t3. Exit program");
            try
            {
                int option = Convert.ToInt32(Console.ReadLine());
                if (option == 1)
                {
                    PickUp pickup = new PickUp();
                    pickup.InsertTime();
                    pickup.InsertInfo();
                }
                else if (option == 2)
                {
                    Delivery delivery = new Delivery();
                    delivery.InsertAddress();
                    delivery.InsertInfo();
                }
                else if (option == 3)
                {
                    return 0;
                }
            }
            catch (OverflowException)
            {
                Console.Clear();
                Console.WriteLine("\nNumber is either too large or too small, please select one of the two options.");
                Main();
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("\nInvalid key entry, please select one of the two options.");
                Main();
            }
        } while (flag);
        return 0;
    }
}
