//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ССЕИЯ1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Obshii
    {
        public int Id { get; set; }
        public int IdInfoPropusk { get; set; }
        public int IdReceivingParty { get; set; }
        public int IdAuthorization { get; set; }
        public Nullable<int> IdDocs { get; set; }
        public int IdSotrudnik { get; set; }
        public int IdInfoClient { get; set; }
    
        public virtual Authorizations Authorizations { get; set; }
        public virtual Docs Docs { get; set; }
        public virtual InfoClient InfoClient { get; set; }
        public virtual InfoPropusk InfoPropusk { get; set; }
        public virtual ReceivingParty ReceivingParty { get; set; }
        public virtual Sotrudnik Sotrudnik { get; set; }
    }
}
