//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SnE.Component.DocumentsManager.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Mirror
    {
        public int Id { get; set; }
        public System.Guid RowGuid { get; set; }
        public int Curator { get; set; }
        public string DocumentToken { get; set; }
        public string OriginalName { get; set; }
        public string Extension { get; set; }
        public byte[] DocumentBytes { get; set; }
        public string DocumentEntityType { get; set; }
        public System.DateTime CreationDate { get; set; }
        public string Interface { get; set; }
    }
}
