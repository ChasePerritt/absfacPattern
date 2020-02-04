using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Name: Chase Perritt
 * Date: 3 February 2020
 * File: DumbPhones.cs
 * Description: This is the DumbPhones file meant to keep up with the classes under the IDumb interface
 */
namespace absfacPattern
{
    interface IDumb
    {
        string getName();
    }
    class Asha : IDumb
    {
        string IDumb.getName()
        {
            return null;
        }
    }
    class Genie : IDumb
    {
        string IDumb.getName()
        {
            return null;
        }
    }
    class Primo : IDumb
    {
        string IDumb.getName()
        {
            return null;
        }
    }
}
