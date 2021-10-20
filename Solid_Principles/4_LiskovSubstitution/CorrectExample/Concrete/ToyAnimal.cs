using Solid_Principles._4_LiskovSubstitution.CorrectExample.Abstract;
using Solid_Principles._4_LiskovSubstitution.CorrectExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles._4_LiskovSubstitution.CorrectExample.Concrete
{
    class ToyAnimal : BaseEntity, IChargeBattery
    {
        public string ChargeBattery()
        {
            return "Charged";
        }
    }
}
