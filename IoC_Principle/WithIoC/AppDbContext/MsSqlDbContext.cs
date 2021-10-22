using IoC_Principle.WithIoC.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC_Principle.AppDbContext
{
    public class MsSqlDbContext : IConnection
    {
        public string GetData()
        {
            return "From MsSql";
        }
    }
}
