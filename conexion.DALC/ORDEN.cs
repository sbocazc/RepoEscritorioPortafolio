//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace conexion.DALC
{
    using System;
    using System.Collections.Generic;
    
    public partial class ORDEN
    {
        public long ID_ORDEN { get; set; }
        public string TAREA { get; set; }
        public string NOTA { get; set; }
        public string ESTADO { get; set; }
        public long FUNCIONARIO_ID_FUNCIONARIO { get; set; }
        public long AREA_ID_AREA { get; set; }
    
        public virtual AREA AREA { get; set; }
        public virtual FUNCIONARIO FUNCIONARIO { get; set; }
    }
}
