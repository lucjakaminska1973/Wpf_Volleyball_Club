﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class VolleyballClubEntities : DbContext
    {
        public VolleyballClubEntities()
            : base("name=VolleyballClubEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Coach> Coaches { get; set; }
        public virtual DbSet<Coach_Contact_Info> Coach_Contact_Info { get; set; }
        public virtual DbSet<Guardian> Guardians { get; set; }
        public virtual DbSet<Month> Months { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Player_Contact_Info> Player_Contact_Info { get; set; }
        public virtual DbSet<Result> Results { get; set; }
        public virtual DbSet<Rival> Rivals { get; set; }
        public virtual DbSet<Season> Seasons { get; set; }
        public virtual DbSet<Tab_Result> Tab_Result { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<Team_members> Team_members { get; set; }
        public virtual DbSet<Active_Players> Active_Players { get; set; }
    
        public virtual ObjectResult<Candidate_To_Cadet_Result> Candidate_To_Cadet()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Candidate_To_Cadet_Result>("Candidate_To_Cadet");
        }
    
        public virtual ObjectResult<Candidate_To_Junior_Result> Candidate_To_Junior()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Candidate_To_Junior_Result>("Candidate_To_Junior");
        }
    
        public virtual ObjectResult<Candidate_To_Pair_Result> Candidate_To_Pair()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Candidate_To_Pair_Result>("Candidate_To_Pair");
        }
    
        public virtual ObjectResult<Candidate_To_Pinky_Result> Candidate_To_Pinky()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Candidate_To_Pinky_Result>("Candidate_To_Pinky");
        }
    
        public virtual ObjectResult<Candidate_To_Triple_Result> Candidate_To_Triple()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Candidate_To_Triple_Result>("Candidate_To_Triple");
        }
    }
}
