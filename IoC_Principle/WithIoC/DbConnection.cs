using IoC_Principle.AppDbContext;
using IoC_Principle.WithIoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC_Principle
{
    public class DbConnection
    {
        //Now the helper class is designed to import the DbConnection object instance.


        private MongoDbContext _mContext;
        public DbConnection()
        {
            _mContext = ConnectionFactory.GetConnection();
        }

        public string GetData()
        {
            return _mContext.GetData();
        }
    }
}
