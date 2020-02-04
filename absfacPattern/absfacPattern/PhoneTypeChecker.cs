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

        }
        public void CheckProducts()
        {

        }
    }

    enum Manufacturers
    {
        SAMSUNG,
        HTC,
        NOKIA
    }
}
