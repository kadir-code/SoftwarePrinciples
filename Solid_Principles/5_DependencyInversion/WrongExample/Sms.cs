using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles._5_DependencyInversion.WrongExample
{
    public class SMS
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }

        public void SendSMS()
        {
            //Send sms
        }
    }
}
