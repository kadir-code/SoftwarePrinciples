using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRY_Principle.WrongExample
{
    class Checkout
    {/*
      If it is necessary to define another number instead of 1000 in the project codes, it will be difficult to organize this repetition from a center.
      */
        public int GetUserCredit()
        {
            var userCredit = 15;

            return userCredit + 1000;
        }
    }
}
