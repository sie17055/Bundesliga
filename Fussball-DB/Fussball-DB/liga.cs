//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fussball_DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class liga
    {
        public liga()
        {
            this.vereins = new HashSet<verein>();
        }
    
        public int Liga_Nr { get; set; }
        public string Verband { get; set; }
        public System.DateTime Erstaustragung { get; set; }
        public Nullable<int> Meister { get; set; }
        public string Rekordspieler { get; set; }
        public Nullable<int> Spiele_Rekordspieler { get; set; }
    
        public virtual verein verein { get; set; }
        public virtual ICollection<verein> vereins { get; set; }
    }
}
