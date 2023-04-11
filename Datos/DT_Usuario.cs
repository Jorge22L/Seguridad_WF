using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Dt_Usuario
    {
        public IQueryable<usuario> getUsuario()
        {
            SeguridadEntities db = new SeguridadEntities();
            IQueryable<usuario> query = db.usuario;
            return query;
        }
    }
}
