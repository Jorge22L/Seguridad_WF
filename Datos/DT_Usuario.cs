using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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

        public void EditarUsuario(usuario modelo)
        {
            
            using (SeguridadEntities contexto = new SeguridadEntities())
            {
                var consulta = contexto.usuario.Find(modelo.idusuario);
                if(consulta != null)
                {
                    try
                    {
                        consulta.nombre = modelo.nombre ?? consulta.nombre;
                        consulta.apellido = modelo.apellido ?? consulta.apellido;
                        consulta.nombreusuario = modelo.nombreusuario ?? consulta.nombreusuario;
                        consulta.fechaCreacion = modelo.fechaCreacion ?? consulta.fechaCreacion;
                        consulta.pwd = modelo.pwd ?? consulta.pwd;
                        consulta.estado = modelo.estado ?? consulta.estado;

                        contexto.usuario.AddOrUpdate(consulta);
                        contexto.SaveChanges();
                    }
                    catch (Exception e)
                    {
                        throw new Exception(message: "Error en capa de datos usuario: " + e.Message);
                    }
                }
                else
                {
                    return;
                }
            }
        }

        public void EliminarUsuario(usuario modelo)
        {
            using (SeguridadEntities contexto = new SeguridadEntities())
            {
                var consulta = contexto.usuario.Find(modelo.idusuario);
                if(consulta != null)
                {
                    try
                    {
                        consulta.nombre = modelo.nombre ?? consulta.nombre;
                        consulta.apellido = modelo.apellido ?? consulta.apellido;
                        consulta.nombreusuario = modelo.nombreusuario ?? consulta.nombreusuario;
                        consulta.fechaCreacion = modelo.fechaCreacion ?? consulta.fechaCreacion;
                        consulta.pwd = modelo.pwd ?? consulta.pwd;
                        consulta.estado = modelo.estado ?? consulta.estado;
                        contexto.usuario.AddOrUpdate(consulta);
                        contexto.SaveChanges();
                    }
                    catch (Exception e)
                    {

                        throw new Exception(message: "Error en capa de datos usuario: " + e.Message);
                    }
                }
                else
                {
                    return;
                }
            }
        }

        public List<usuario> listarUsuario()
        {
            using (SeguridadEntities contexto = new SeguridadEntities())
            {
                return contexto.usuario.Where(u=>u.estado != 3).ToList();
            }
        }
    }
}
