using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WS1
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class WSPersonas : IWSPersonas
    {
        public Persona ObtenerPersona(string ID)
        {
            if (ID == "0")
            {
                return new Persona() { ID = "0", Name = "Kevin", Description = "Fullstack programmer", topSecret = "KHS16" };
            }
            else if (ID == "1")
            {
                return new Persona() { ID = "1", Name = "Josue", Description = "BDA", topSecret = "KHS16i" };
            }
            else
            {
                return new Persona() { Error = "Persona no encontrada" };
            }
        }
    }
}
