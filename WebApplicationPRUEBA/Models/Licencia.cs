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
    
    public partial class Licencia
    {
        public int id { get; set; }
        public int idEmpleado { get; set; }
        public Nullable<System.DateTime> desde { get; set; }
        public Nullable<System.DateTime> hasta { get; set; }
        public string motivos { get; set; }
        public string comentarios { get; set; }
    }
}
