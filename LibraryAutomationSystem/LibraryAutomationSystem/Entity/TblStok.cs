//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryAutomationSystem.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblStok
    {
        public int StokID { get; set; }
        public Nullable<int> KitapID { get; set; }
        public Nullable<byte> Adet { get; set; }
    
        public virtual TblKitaplar TblKitaplar { get; set; }
    }
}
