using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles._5_DependencyInversion.WrongExample
{
    public class Notification
    {
        //Whenewer we vant to ad a class in our program we need to change the notificatio class at all

        private Email _email;
        private SMS _sms;
        public Notification()
        {
            _email = new Email();
            _sms = new SMS();
        }

        public void Send()
        {
            _email.SendEmail();
            _sms.SendSMS();
        }
    }
}
