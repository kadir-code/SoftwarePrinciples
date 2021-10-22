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

        /*
        private IConnection _connection;
        public DbConnection()
        {
            _connection = ConnectionFactory.GetConnection();
        }

        public string GetData()
        {
            return _connection.GetData();
        }*/

        //After Dependency Injejtion
        //There are 3 methods to inject, by property, method and constructor.
        private IConnection _connection;
        //Here we will give parameters to the constructor.
        public DbConnection(IConnection connection)
        {
            _connection =connection;
        }

        public string GetData()
        {
            return _connection.GetData();
        }
        /*Here, we have loosened the bond between the two classes a little more.
         * If we want to convert our database source to MsSQLDb, 
         * we need to do this by giving the MsSQLDbContext class 
         * as a parameter where the object of the DbConnection class is created.
         */
    }
}
