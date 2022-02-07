using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_3
{
    internal class Program
    {
        enum Errors : ushort
        {
            Bad_Request400 = 400,
            Unauthorized_Error401 = 401,
            Payment_Required402 = 402,
            Forbidden403 = 403,
            Not_Found404 =404
        }
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter the Error number from 400-404: ");
            number = Convert.ToInt32(Console.ReadLine());

            Errors error = (Errors)number;

            switch (error)
            {
                case Errors.Bad_Request400:
                    Console.WriteLine("Bad_Request");
                    break;
                case Errors.Unauthorized_Error401:
                    Console.WriteLine("Unauthorized_Error");
                    break;
                case Errors.Payment_Required402:
                    Console.WriteLine("Payment_Required");
                    break;
                case Errors.Forbidden403:
                    Console.WriteLine("Forbidden");
                    break;
                case Errors.Not_Found404:
                    Console.WriteLine("Not_Found");
                    break;
            }
        }
    }
}
