using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRY_Principle.CorrectExample
{
    class Cart
    {/*
      We have moved the manipulation functions of methods that return credit information into UserHelper.GetUserCredit, so if we need to change the manipulation formula, we only need to change the body of UserHelper.GetUserCredit. Then we used it via UserHelper.GetUserCredit wherever we needed this function.
      */
        public double GetUserCredit()
        {
            var userCredit = 25;

            return UserHelper.GetUserCredit(userCredit);
        }
    }
}
