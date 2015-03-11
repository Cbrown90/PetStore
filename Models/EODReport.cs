using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetStore.Models
{
    public partial class EODReport
    {
        public int? TypeID { get; set; }
        public string AnimalTypeString
        {
            get
            {
                if (TypeID != null)
                {
                    Entities context = new Entities();
                    var AnimalType = context.AnimalTypes.First(a => a.Id == TypeID);

                    return AnimalType.Type;
                }
                else return "No Type Set";
            }
            set
            {
                if (value != null)
                {
                    Entities context = new Entities();
                    var AnimalType = context.AnimalTypes.First(a => a.Type == value);

                    if (AnimalType != null)
                    {
                        TypeID = AnimalType.Id;
                    }
                }
            }
        }
        public int InStock { get; set; }
        public int SoldToday { get; set; }
    }
}
