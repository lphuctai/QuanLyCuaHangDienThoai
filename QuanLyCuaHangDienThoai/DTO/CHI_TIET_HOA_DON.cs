//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class CHI_TIET_HOA_DON
    {
        public int MA_HOA_DON { get; set; }
        public string IMEI { get; set; }
        public Nullable<int> GIA { get; set; }
        public string GHI_CHU { get; set; }
    
        public virtual HOA_DON HOA_DON { get; set; }
        public virtual SAN_PHAM SAN_PHAM { get; set; }
    }
}
