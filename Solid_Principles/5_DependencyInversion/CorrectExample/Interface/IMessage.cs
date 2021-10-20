using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles._5_DependencyInversion.CorrectExample.Interface
{
   public  interface IMessage
    {
        //we need to separate notification class
        void SendMessage();
    }
}
