//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class registro
    {
        public registro()
        {
            this.estudiantes = new HashSet<estudiante>();
        }
    
        public int id_registro { get; set; }
        public System.DateTime fechayhora { get; set; }
        public string tipo { get; set; }
    
        public virtual ICollection<estudiante> estudiantes { get; set; }
    }
}
