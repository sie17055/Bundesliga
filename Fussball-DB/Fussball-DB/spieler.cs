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
    
    public partial class spieler
    {
        public int Spieler_ID { get; set; }
        public int Vereins_ID { get; set; }
        public Nullable<int> Trikot_Nr { get; set; }
        public string Spieler_Name { get; set; }
        public string Land { get; set; }
        public Nullable<int> Spiele { get; set; }
        public Nullable<int> Tore { get; set; }
        public Nullable<int> Vorlagen { get; set; }
    
        public virtual verein verein { get; set; }
    }
}