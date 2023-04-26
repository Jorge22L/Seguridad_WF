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

        public void guardarUsuario(usuario modelo)
        {
            using(SeguridadEntities contexto = new SeguridadEntities())
            {
                contexto.usuario.Add(modelo);
                contexto.SaveChanges();
            }
        }

        public List<usuario> listarUsuario()
        {
            using (SeguridadEntities contexto = new SeguridadEntities())
            {
                return contexto.usuario.AsNoTracking().ToList();
            }
        }
    }
}
