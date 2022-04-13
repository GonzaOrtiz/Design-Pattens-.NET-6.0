using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_de_diseño
{
    public class HandleDataBase
    {
        public const int MongoDb = 1;
        public const int SqlServer = 2;

        public static DataBases Selector(int selector)
        {
            if (selector == MongoDb)
               return new MongoDb();
            if (selector == SqlServer)
                return new SqlServer();
            else
                return null;
        }
    }
}
