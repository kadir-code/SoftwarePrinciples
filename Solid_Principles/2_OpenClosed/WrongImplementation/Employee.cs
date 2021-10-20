using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles._2_OpenClosed.WrongImplementation
{
    public class Employee
    {
        /*
         The employee class here contains a formula that calculates the salary of the workers, 
        and we have to make new additions to the existing calculete part according to the type 
        of incoming worker. Although it is not a problem for one or two employee types,
        this method becomes unable to meet our requests when we work with dozens of different types.
        We need to rewrite the coda based on the single repsonsibiliyy principle.
        */
        Employee() { }
        public Employee(int id, string name, string type)
        {
            this.ID = id;
            this.Name = name;
            this.EmployeeType = type;
        }

        public int ID { get; set; }
        public string EmployeeType { get; set; }
        public string Name { get; set; }

        public decimal CalculateBonus(decimal salary)
        {
            if (this.EmployeeType == "Permanent")
                return salary * .1M;
            else
                return salary * .05M;
        }
    }
}

