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
    
    public partial class PropertyTemplate
    {
        public PropertyTemplate()
        {
            this.PropertyTemplateItems = new HashSet<PropertyTemplateItem>();
        }
    
        public int RecordID { get; set; }
        public string TemplateName { get; set; }
        public string TemplateDescription { get; set; }
    
        public virtual ICollection<PropertyTemplateItem> PropertyTemplateItems { get; set; }
    }
}
