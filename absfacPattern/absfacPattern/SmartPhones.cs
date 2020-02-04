using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Name: Chase Perritt
 * Date: 3 February 2020
 * File: SmartPhones.cs
 * Description: This is the SmartPhones file which keeps track of all classes under the ISmart interface
 */
namespace absfacPattern
{
    interface ISmart
    {
        string getName();
    }
    class Lumia : ISmart
    {
        string ISmart.getName()
        {
            return "Lumia";
        }
    }
    class GalaxyS2 : ISmart
    {
        string ISmart.getName()
        {
            return "GalaxyS2";
        }
    }
    class Titan : ISmart
    {
        string ISmart.getName()
        {
            return "Titan";
        }
    }
}
