//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BD
{
    using System;
    using System.Collections.Generic;
    
    public partial class SECCION
    {
        public SECCION()
        {
            this.DET_EMPRESA = new HashSet<DET_EMPRESA>();
        }
    
        public short ID_SECCION { get; set; }
        public string NOMBRE_SECCION { get; set; }
        public short DEPARTAMENTO_ID_DEPARTAMENTO { get; set; }
        public short SUBDEPARTAMENTO_ID_SUBDEPTO { get; set; }
    
        public virtual DEPARTAMENTO DEPARTAMENTO { get; set; }
        public virtual ICollection<DET_EMPRESA> DET_EMPRESA { get; set; }
        public virtual SUBDEPTO SUBDEPTO { get; set; }
    }
}
