using ATMApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp.UI
{
    public static class AppScreen
    {
        internal static void Welcome()
        {
            //Clears the console screen 
            Console.Clear();
            //Sets the title of the console window
            Console.ForegroundColor = ConsoleColor.White;
            //Set the welcome message
            Console.WriteLine("\n\n------------------Welcome To Yours Bank ATM App------------------\n\n");
            //Prompts the user to insert atm card
            Console.WriteLine("Please Enter Your ATM Card");
            Console.WriteLine("Note: Actual ATM MACHINE will accept and validate a physical ATM Card, read the card number and validate it.");
            Utility.PressEnterToContinue();
        }

        internal static UserAccount UserLoginForm()
        {
            UserAccount tempUserAccount = new UserAccount();
            tempUserAccount.CardNumber = Validator.Convert<long>("your card number.");

            tempUserAccount.CardPin = Convert.ToInt32(Utility.GetSecretInput("Enter your card pin"));

            return tempUserAccount;
        }

        internal static void LoginProgress()
        {
            Console.WriteLine("\n\nChecking card number and PIN ...");
            Utility.PrintDotAnimation();
        }

        internal static void PrintLockScreen()
        {
            Console.Clear();
            Utility.PrintMessage("Your account is locked. Please go to the nearest branch to unlock your account. Thank you. ", true);
            Utility.PressEnterToContinue();
            Environment.Exit(1);
        }
    }
}
