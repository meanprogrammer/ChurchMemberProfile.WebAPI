//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChurchMemberProfile.WebAPI.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class PropertyTemplateItem
    {
        public int RecordID { get; set; }
        public int TemplateID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public byte Enabled { get; set; }
    
        public virtual PropertyTemplate PropertyTemplate { get; set; }
    }
}
