using Solid_Principles._5_DependencyInversion.CorrectExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solid_Principles._5_DependencyInversion.CorrectExample.Concrete
{
    class Email:IMessage
    {
        public string ToAddress { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }

        public void SendMessage()
        {
            MessageBox.Show("Mail Message");
        }
    }
}
