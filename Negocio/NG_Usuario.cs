using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NG_Usuario
    {
        AES aes = new AES();
        DT_Aes aesDt = new DT_Aes();
        Dt_Usuario dtu = new Dt_Usuario();
        usuario u = new usuario();

        public List<usuario> ListaUsuarios()
        {
            List<usuario> usuarios = dtu.listarUsuario();
            return usuarios;
        }

        public bool GuardarUsuario(usuario modelo)
        {
            int idUsuarioGuardado = 0;
            bool guardado = false;
            string privateKey = "";
            string myIv = "";
            string pwdEncrypted = "";
            try
            {
                using(Aes myAes = Aes.Create())
                {
                    privateKey = aesDt.randomAlphaNumeric(32);
                    myIv = Convert.ToBase64String(myAes.IV);
                    pwdEncrypted = aesDt.Encrypt_Aes(modelo.pwd, privateKey, myIv);

                    Console.WriteLine($"Encrypted: '{pwdEncrypted}'");
                    Console.WriteLine($"Private Key: '{privateKey}'");
                    Console.WriteLine($"My IV: '{myIv}'");
                    Console.WriteLine($"pwdOriginal: '{modelo.pwd}'");
                }

                //Asignamos al objeto la contraseña encriptada
                modelo.pwd = pwdEncrypted;
                idUsuarioGuardado = dtu.guardarUsuario(modelo);
                //Construimos el objeto AES con los datos de seguridad del usuario
                aes.idUsuario = idUsuarioGuardado;
                aes.token = privateKey;
                aes.iv = myIv;
                guardado = dtu.InsertarAES(aes);
            }
            catch (Exception e)
            {

                throw new Exception(message: "Error en NG_Usuario: " +e.Message.ToString());
            }

            return guardado;
        }

        public void NG_EditarUsuario(usuario modelo)
        {
            try
            {
                dtu.EditarUsuario(modelo);
            }
            catch (Exception e)
            {

                throw new Exception(message: "Error en NG_Usuario - Editar : " + e.Message.ToString());
            }
        }

        public void NG_EliminarUsuario(usuario modelo)
        {
            try
            {
                dtu.EditarUsuario(modelo);
            }
            catch (Exception e)
            {

                throw new Exception(message: "Error en NG_Usuario - Eliminar : " + e.StackTrace);
            }
        }

        public usuario NG_VerUsuario(int idusuario)
        {
            try
            {
                usuario ng_usuario =  dtu.VerUsuario(idusuario);
                return ng_usuario;
            }
            catch (Exception)
            {

                throw new Exception("Error al obtener usuario");
            }
        }

        
        public bool ValidarCredencialesNeg(string usuario, string pwd, int rol)
        {
            bool entrar = false;
            try
            {
                entrar = dtu.ValidarCredenciales(usuario, pwd, rol);
            }
            catch (Exception e)
            {

                throw new Exception("Error al validar credenciales " + e.Message);
            }

            return entrar;
        }
       
    }
}
