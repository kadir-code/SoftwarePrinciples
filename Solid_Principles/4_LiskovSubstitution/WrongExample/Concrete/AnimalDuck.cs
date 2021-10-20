using Solid_Principles._4_LiskovSubstitution.WrongExample.Abstarct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles._4_LiskovSubstitution.WrongExample.Concrete
{
    class AnimalDuck : BaseEntity
    {
        //the animal duck does need a battery ?
        public override string ChargeBattery()
        {
            throw new NotImplementedException();
        }
    }
}
