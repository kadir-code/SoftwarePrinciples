using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC_Principle.WithIoC.Interface
{
    public interface IConnection
    {
        //While the ConnectionFactory class returns a concrete object, it will now return an abstract object (IConnection) thanks to this interface.
        string GetData();
    }
}
