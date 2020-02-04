using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Name: Chase Perritt
 * Date: 3 February 2020
 * File: PhoneTypeChecker.cs
 * Description: This is the PhoneTypeChecker file used to manage the IPhoneFactory interface and keep track of the Manufacturers enumerator.
 */
namespace absfacPattern
{
    class PhoneTypeChecker
    {
        public IPhoneFactory factory;
        public Manufacturers manu;

        public PhoneTypeChecker(Manufacturers m)
        {
            manu = m;

            if (manu == Manufacturers.SAMSUNG) factory = new SamsungFactory();
            else if (manu == Manufacturers.HTC) factory = new HTCFactory();
            else if (manu == Manufacturers.NOKIA) factory = new NokiaFactory();
            else factory = null;
        }
        public void CheckProducts()
        {
            Console.Write("Production: ");
            Console.WriteLine(manu);
        }
    }

    enum Manufacturers
    {
        SAMSUNG,
        HTC,
        NOKIA
    }
}
