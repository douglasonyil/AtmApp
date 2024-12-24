using ATMApp.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp.App
{
    internal class Entry
    {
        static void Main(string[] args)
        {
            AppScreen.Welcome();
            ATMApp atmAPP = new ATMApp();

            atmAPP.InitializeData();

            atmAPP.CheckUserCardNumAndPassword();

            atmAPP.Welcome();
            //long cardNumber = Validator.Convert<long>("your card number");
            //Console.WriteLine($"Your card number is {cardNumber}");

            Utility.PressEnterToContinue();
        }
    }
}
