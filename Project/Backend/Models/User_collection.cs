//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PixelSpot1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User_collection
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User_collection()
        {
            this.Photos = new HashSet<Photo>();
        }
    
        public int uc_id { get; set; }
        public Nullable<int> u_id { get; set; }
        public Nullable<int> cc_id { get; set; }
    
        public virtual Collection_category Collection_category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Photo> Photos { get; set; }
        public virtual User User { get; set; }
    }
}
