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
    
    public partial class spiel
    {
        public int Spiel_ID { get; set; }
        public Nullable<int> Spieltag { get; set; }
        public Nullable<System.DateTime> Datum { get; set; }
        public Nullable<System.TimeSpan> Uhrzeit { get; set; }
        public int Heim { get; set; }
        public int Gast { get; set; }
        public Nullable<int> Tore_Heim { get; set; }
        public Nullable<int> Tore_Gast { get; set; }
    
        public virtual verein verein { get; set; }
        public virtual verein verein1 { get; set; }
    }
}