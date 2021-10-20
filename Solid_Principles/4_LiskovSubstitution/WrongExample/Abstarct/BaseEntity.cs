using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles._4_LiskovSubstitution.WrongExample.Abstarct
{
    public abstract class BaseEntity
    {
        public string Sound()
        {
            return "Quick";
        }
        public abstract string ChargeBattery();
    }
}
