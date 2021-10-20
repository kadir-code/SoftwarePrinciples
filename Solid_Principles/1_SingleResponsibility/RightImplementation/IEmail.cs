using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles._1_SingleResponsibility.RightImplementation
{
    interface IEmail
    {
        bool SendEmail(string emailContent);

    }
}
