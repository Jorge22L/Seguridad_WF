//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class rol_opcion
    {
        public int idrol_opcion { get; set; }
        public int idrol { get; set; }
        public int idopcion { get; set; }
    
        public virtual opcion opcion { get; set; }
        public virtual rol rol { get; set; }
    }
}