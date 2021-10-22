using IoC_Principle.AppDbContext;
using IoC_Principle.WithIoC.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC_Principle.WithIoC
{
    public class ConnectionFactory
    {
        public static IConnection GetConnection()
        {
            return new MongoDbContext();
        }
    }
}
