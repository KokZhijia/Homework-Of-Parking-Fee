using System;
namespace Homework_Of_Parking_Fee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Parkingtime = int.Parse(Console.ReadLine());
            int Parkingfee = (Parkingtime / 30);
            int charges = (Parkingfee *20 );
            if (Parkingtime>=30)
            {

                Console.WriteLine($"NT$: {charges}");

            }
            else
            {

                Console.WriteLine("Free");

            }
            

        }
    }
}