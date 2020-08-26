using App_Uno.Models.Home;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace App_Uno.Methods 
{
    public class Global : IGlobal
    {
        public IList<Metrica> ConvertXML(string routeXML)
        {
            IList<Metrica> metricas = null;
            try
            {
                var documentXML = XDocument.Load(routeXML);

                metricas = (IList<Metrica>) documentXML.Descendants("Target").Select(xml => new Metrica
                {
                    NamespaceProyect = xml.Element("Namespaces").Name.ToString()
                });
            }
            catch (Exception e)
            {
                _ = e.Message;
            }

            return metricas;
        }

        // LLOC: 7 LINEAS DE CODIGO
        // LOC: 11 LINEAS DE CODIGO
        // 2 LINEAS DE CODIGO EJECUTABLE
        public bool Confirmacion(int num)
        {
            // VALIDACION NUMERO
            if (num >= 50)
            {
                // PRIMERA EJECUCION
                return true;
            }

            // SEGUNDA EJECUCION
            return false;
        }
    }
}
