using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TallerAzure2.Models;

namespace TallerAzure2.Datos
{
    public class TramiteAdmin
    {
        /// <summary>
        /// Consula todo los tramites
        /// </summary>
        /// <returns>Listado de tramites</returns>
        public IEnumerable<Tramite> Consultar()
        {
            using (TallerAzureDB1Entities contexto = new TallerAzureDB1Entities())
            {
                return contexto.Tramite.AsNoTracking().ToList();
            }
        }

        /// <summary>
        /// Consulta un tramite especifico
        /// </summary>
        /// <param name="id">id del tramite</param>
        /// <returns>Los datos del tramite</returns>
        public Tramite Consultar(int id)
        {
            using (TallerAzureDB1Entities contexto = new TallerAzureDB1Entities())
            {
                return contexto.Tramite.AsNoTracking().FirstOrDefault(c=>c.Id==id);
            }
        }

        /// <summary>
        /// Guarda un tramite
        /// </summary>
        /// <param name="modelo">datos del tramite</param>
        public void Guardar(Tramite modelo)
        {
            using (TallerAzureDB1Entities contexto = new TallerAzureDB1Entities())
            {
                contexto.Tramite.Add(modelo);
                contexto.SaveChanges();
            }
        }

        /// <summary>
        /// Modificar los datos de un tramite
        /// </summary>
        /// <param name="modelo"> datos del tramite</param>
        public void Modificar(Tramite modelo)
        {
            using (TallerAzureDB1Entities contexto = new TallerAzureDB1Entities())
            {
                contexto.Entry(modelo).State= EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        /// <summary>
        /// Elimina los datos de un tramite
        /// </summary>
        /// <param name="modelo">datos del tramite</param>
        public void Eliminar(Tramite modelo)
        {
            using (TallerAzureDB1Entities contexto = new TallerAzureDB1Entities())
            {
                contexto.Entry(modelo).State = EntityState.Deleted;
                contexto.SaveChanges();
            }
        }

    }
}