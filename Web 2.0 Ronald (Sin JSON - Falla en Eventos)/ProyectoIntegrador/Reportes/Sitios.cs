//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoIntegrador.Reportes
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sitios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sitios()
        {
            this.Administra = new HashSet<Administra>();
            this.Fotos = new HashSet<Fotos>();
            this.ubicaciones = new HashSet<ubicaciones>();
        }
    
        public int IdSitio { get; set; }
        public string Descripcion { get; set; }
        public string Nombre { get; set; }
        public string Estatus { get; set; }
        public Nullable<int> IdEstablecimiento { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Administra> Administra { get; set; }
        public virtual Establecimientos Establecimientos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fotos> Fotos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ubicaciones> ubicaciones { get; set; }
    }
}
