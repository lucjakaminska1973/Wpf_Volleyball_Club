//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wpf_VolleyballClub
{
    using System;
    using System.Collections.Generic;
    
    public partial class Payment
    {
        public long payment_number { get; set; }
        public Nullable<System.DateTime> payment_date { get; set; }
        public decimal amount { get; set; }
        public string month_ID { get; set; }
        public byte season_ID { get; set; }
        public long player_ID { get; set; }
    
        public virtual Month Month { get; set; }
        public virtual Player Player { get; set; }
        public virtual Season Season { get; set; }
    }
}
