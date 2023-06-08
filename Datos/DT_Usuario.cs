using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Dt_Usuario
    {
        AES aes = new AES();
        DT_Aes aesDt = new DT_Aes();

        public usuario VerUsuario(int idusuario)
        {
            using (SeguridadEntities contexto = new SeguridadEntities())
            {
                usuario consulta = contexto.usuario.Find(idusuario);
                if(consulta != null)
                {
                    return consulta;
                }
                else
                {
                    return null;
                }
            }
        }

        public int guardarUsuario(usuario modelo)
        {

            using(SeguridadEntities contexto = new SeguridadEntities())
            {
                int idUsuarioGuardado = 0;
                try
                {
                    contexto.usuario.Add(modelo);
                    contexto.SaveChanges();
                    idUsuarioGuardado = modelo.idusuario;
                    Console.WriteLine($"idUsuarioGuardado: '{idUsuarioGuardado}'");
                }
                catch (DbEntityValidationException dbEx)
                {
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            Trace.TraceInformation("Property: {0} Error: {1}",
                                validationError.PropertyName,
                                validationError.ErrorMessage);
                        }
                    }
                }

                return idUsuarioGuardado;

            }
        }

        public bool InsertarAES(AES aes)
        {
            bool guardado = false;
            using (SeguridadEntities modelo = new SeguridadEntities())
            {
                modelo.AES.Add(aes);
                modelo.SaveChanges();
                guardado = true;
            }
            
            return guardado;
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
                    
                    catch (DbEntityValidationException dbEx)
                    {
                        foreach (var validationErrors in dbEx.EntityValidationErrors)
                        {
                            foreach (var validationError in validationErrors.ValidationErrors)
                            {
                                Trace.TraceInformation("Property: {0} Error: {1}",
                                    validationError.PropertyName,
                                    validationError.ErrorMessage);
                            }
                        }
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

        public bool ValidarCredenciales(string usuario, string pwd, int rol)
        {
            bool entrar = false;
            string pwdDecrypt = "";
            int rolSelected = rol;
            Debug.WriteLine("Rol seleccionado: " + rol);
          

            using (SeguridadEntities modelo = new SeguridadEntities())
            {
                usuario user = modelo.usuario.Where(u => u.nombreusuario.Equals(usuario)).FirstOrDefault();
                AES aes = modelo.AES.Where(a => a.idUsuario == user.idusuario).FirstOrDefault();

                pwdDecrypt = aesDt.Decrypt_Aes(user.pwd, aes.token, aes.iv);

                if (usuario.Equals(user.nombreusuario) && pwd.Equals(pwdDecrypt))
                {
                    entrar = true;
                }
                else
                {
                    entrar = false;
                }

                return entrar;
            }
        }
    }

    
}
