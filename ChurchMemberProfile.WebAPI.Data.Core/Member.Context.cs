﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChurchMemberProfile.WebAPI.Data.Core
{
    using ChurchMemberProfile.WebAPI.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ChurchMemberProfileEntities : DbContext
    {
        public ChurchMemberProfileEntities()
            : base("name=ChurchMemberProfileEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<MemberProfile> MemberProfiles { get; set; }
        public virtual DbSet<MemberProfilePropertyValue> MemberProfilePropertyValues { get; set; }
        public virtual DbSet<PropertyTemplate> PropertyTemplates { get; set; }
        public virtual DbSet<PropertyTemplateItem> PropertyTemplateItems { get; set; }
    }
}
