﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CustSilcoTime
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Cust_Silco_PYEntities : DbContext
    {
        public Cust_Silco_PYEntities()
            : base("name=Cust_Silco_PYEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<SelectTimeSheetForManagerPayweek_Result> SelectTimeSheetForManagerPayweek(string manager, Nullable<int> payweekid)
        {
            var managerParameter = manager != null ?
                new ObjectParameter("manager", manager) :
                new ObjectParameter("manager", typeof(string));
    
            var payweekidParameter = payweekid.HasValue ?
                new ObjectParameter("payweekid", payweekid) :
                new ObjectParameter("payweekid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectTimeSheetForManagerPayweek_Result>("SelectTimeSheetForManagerPayweek", managerParameter, payweekidParameter);
        }
    }
}
