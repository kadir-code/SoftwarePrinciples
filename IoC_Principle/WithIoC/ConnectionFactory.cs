using IoC_Principle.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC_Principle.WithIoC
{
    public class ConnectionFactory
    {
        public static MongoDbContext GetConnection()
        {
            return new MongoDbContext();
        }
    }
}
