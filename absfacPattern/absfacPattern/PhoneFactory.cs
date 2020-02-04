using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Name: Chase Perritt
 * Date: 3 February 2020
 * File: PhoneFactory.cs
 * Description: This is the PhoneFactory file, which keeps track of all classes of the IPhoneFactory interface
 */
namespace absfacPattern
{
    interface IPhoneFactory
    {
        ISmart GetSmart();
        IDumb GetDumb();
    }

    class SamsungFactory : IPhoneFactory
    {
        ISmart IPhoneFactory.GetSmart()
        {
            return null;
        }
        IDumb IPhoneFactory.GetDumb()
        {
            return null;
        }
    }

    class HTCFactory : IPhoneFactory
    {
        ISmart IPhoneFactory.GetSmart()
        {
            return null;
        }
        IDumb IPhoneFactory.GetDumb()
        {
            return null;
        }
    }

    class NokiaFactory : IPhoneFactory
    {
        ISmart IPhoneFactory.GetSmart()
        {
            return null;
        }
        IDumb IPhoneFactory.GetDumb()
        {
            return null;
        }
    }
}
