using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Name: Chase Perritt
 * Date: 3 February 2020
 * File: Program.cs
 * Description: This is the main driver file of the abstract factory pattern testing program.
 */
namespace absfacPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneTypeChecker samsungPTC = new PhoneTypeChecker(Manufacturers.SAMSUNG);
            PhoneTypeChecker htcPTC = new PhoneTypeChecker(Manufacturers.HTC);
            PhoneTypeChecker nokiaPTC = new PhoneTypeChecker(Manufacturers.NOKIA);

            samsungPTC.CheckProducts();
            Console.WriteLine();
            Console.ReadKey();
            htcPTC.CheckProducts();
            Console.WriteLine();
            Console.ReadKey();
            nokiaPTC.CheckProducts();
            Console.WriteLine();
            Console.ReadKey();

            // The above lines test the three PTCs for the three factory types.
        }
    }
}
