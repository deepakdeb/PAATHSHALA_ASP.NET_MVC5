//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace a1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class qa_comment
    {
        public int C_id { get; set; }
        public int U_id { get; set; }
        public int Qa_id { get; set; }
        public string Comment { get; set; }
    
        public virtual qa qa { get; set; }
        public virtual user_t user_t { get; set; }
    }
}
