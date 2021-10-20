using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles._2_OpenClosed.CorrectImplementation.Abstract
{
    public abstract class  BaseEmployee
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public BaseEmployee(int id, string name)
        {
            this.ID = id; this.Name = name;
        }
        //Here we define method as abstract to create the body based on needs of the child classes
        public abstract decimal CalculateBonus(decimal salary);

        public override string ToString()
        {
            return string.Format("ID : {0} Name : {1}", this.ID, this.Name);
        }
    }
}
