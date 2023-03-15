using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeInfotechOrnek
{
    [AttributeUsage(AttributeTargets.Field,
        AllowMultiple = true,
        Inherited = true)]
    public class ZorunAlanAttribute : Attribute
    {
       
    }
}
