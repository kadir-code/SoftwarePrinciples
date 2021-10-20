using Solid_Principles._2_OpenClosed.CorrectImplementation.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles._2_OpenClosed.CorrectImplementation.Concrete
{
    public class PermanentEmployee : BaseEmployee
    {
        public PermanentEmployee(int id, string name) : base(id, name)
        {
            
        }
        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .1M;
        }
    }
}
