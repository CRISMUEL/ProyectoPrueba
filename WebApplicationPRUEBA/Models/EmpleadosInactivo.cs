//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplicationPRUEBA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmpleadosInactivo
    {
        public int id { get; set; }
        public string codigoEmpleado { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string telefono { get; set; }
        public int idDepartamento { get; set; }
        public int idCargo { get; set; }
        public Nullable<System.DateTime> fechaIngreso { get; set; }
        public Nullable<decimal> salario { get; set; }
        public string estatus { get; set; }
        public Nullable<int> idManager { get; set; }
    }
}
