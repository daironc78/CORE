using App_Uno.Models.Home;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace App_Uno.Methods
{
    public interface IGlobal
    {
        public IList<Metrica> ConvertXML(string routeXML);
    }
}
