using Solid_Principles._5_DependencyInversion.CorrectExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solid_Principles._5_DependencyInversion.CorrectExample.Concrete
{
    class Sms : IMessage
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }

        public void SendMessage()
        {
            MessageBox.Show("Mail Message");
        }
    }
}
