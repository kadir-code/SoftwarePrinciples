using IoC_Principle.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC_Principle
{
    public class DbConnection
    {
        //In this example, there is a tight bond between the two classes.
        /*
         *As soon as we change the class we use here to MsSQLDbContext
         *instead of MongoDbContext, it will be necessary to make manual
         *changes to the code in the DbConnection class and in all places 
         *where it is used in other classes, if any. Therefore, changes made 
         *in the MongoDbContext class will also be reflected in our DbConnection class.
         */
        private MongoDbContext _mContext;
        public DbConnection()
        {
            _mContext = new MongoDbContext();
        }

        public string GetData()
        {
            return _mContext.GetData();
        }
    }
}
