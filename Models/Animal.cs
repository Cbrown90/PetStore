//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PetStore.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Animal
    {
        public Animal()
        {
            this.Vaccinations = new HashSet<Vaccination>();
            this.Date_Arrived = DateTime.Now;
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<int> Sex { get; set; }
        public Nullable<int> TypeID { get; set; }
        public Nullable<int> OwnerID { get; set; }
        public System.DateTime Date_Arrived { get; set; }
    
        public virtual AnimalType AnimalType { get; set; }
        public virtual Owner Owner { get; set; }
        public virtual ICollection<Vaccination> Vaccinations { get; set; }
    }
}
