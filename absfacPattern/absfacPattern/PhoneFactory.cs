using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Name: Chase Perritt
 * Date: 3 February 2020
 * File: PhoneFactory.cs
 * Description: This is the PhoneFactory file, which keeps track of all classes of the IPhoneFactory interface
 * 
 * Note: I don't know what manufacturers create what phones, so I just went from left-to-right on the .dia file.
 *       Just imagine this is an alternate universe in which companies came up with different nomenclature.
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
            return new Lumia();
        }
        IDumb IPhoneFactory.GetDumb()
        {
            return new Asha();
        }
    }

    class HTCFactory : IPhoneFactory
    {
        ISmart IPhoneFactory.GetSmart()
        {
            return new GalaxyS2();
        }
        IDumb IPhoneFactory.GetDumb()
        {
            return new Genie();
        }
    }

    class NokiaFactory : IPhoneFactory
    {
        ISmart IPhoneFactory.GetSmart()
        {
            return new Titan();
        }
        IDumb IPhoneFactory.GetDumb()
        {
            return new Primo();
        }
    }
}
