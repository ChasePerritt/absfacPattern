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
        public IPhoneFactory factory = null;
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
            if (factory != null)    // Checks to see if factory is null because no factory means no products.
            {
                ISmart sPhone = factory.GetSmart();
                IDumb dPhone = factory.GetDumb();
                Console.Write("Smartphone: ");
                Console.WriteLine(manu + sPhone.getName()); // Prints out the Manufacturer and Model of Smartphone
                Console.Write("Dumb-Phone: ");
                Console.WriteLine(manu + dPhone.getName()); // Prints out the Manufacturer and Model of Dumbphone
            }
            else
            {
                Console.WriteLine("No factory. No products.");
            }
        }
    }

    enum Manufacturers
    {
        SAMSUNG,
        HTC,
        NOKIA
    }
}
