//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace prog7311
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int userID { get; set; }
        public Nullable<int> cartID { get; set; }
        public string username { get; set; }
        public string userRole { get; set; }
        public string userPassword { get; set; }
    
        public virtual Cart Cart { get; set; }
    }
}
