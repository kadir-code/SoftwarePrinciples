using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC_Principle.AppDbContext
{
    public class MsSqlDbContext
    {
        public string GetData()
        {
            return "From MsSql";
        }
    }
}
