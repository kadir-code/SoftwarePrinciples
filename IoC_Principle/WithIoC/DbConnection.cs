using IoC_Principle.AppDbContext;
using IoC_Principle.WithIoC;
using IoC_Principle.WithIoC.Interface;
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

        //As we use the IConnection interface, we have prevented DbConnection from knowing about MongoDb and MsSQLDb classes.
        private IConnection _connection;
        public DbConnection()
        {
            _connection = ConnectionFactory.GetConnection();
        }

        public string GetData()
        {
            return _connection.GetData();
        }
    }
}
