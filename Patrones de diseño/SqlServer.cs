using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_de_diseño
{
    public class SqlServer : DataBases
    {
        public override string DBSelected()
        {
            return "Base de datos seleccionada => Sql Server";
        }
    }
}
