using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRY_Principle.CorrectExample
{
    class Checkout
    {
        public double GetUserCredit()
        {
            var userCredit = 15;

            return UserHelper.GetUserCredit(userCredit);
        }
    }
}
