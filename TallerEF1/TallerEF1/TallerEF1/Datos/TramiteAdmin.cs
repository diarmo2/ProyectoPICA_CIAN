using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TallerEF1.Models;

namespace TallerEF1.Datos
{
    public class TramiteAdmin
    {

        public IEnumerable<Tramite> Consultar()
        {
            using (TallerAzureDB1Entities contexto = new TallerAzureDB1Entities())
            {
                //Cuando solo necesito los datos de la tabla 
                //y que no los guarde en memoria se usa AsNoTracking 
                return contexto.Tramite.AsNoTracking().ToList();
            }
        }
    }
}