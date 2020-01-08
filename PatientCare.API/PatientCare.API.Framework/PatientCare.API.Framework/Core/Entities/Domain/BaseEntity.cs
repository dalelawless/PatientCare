using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatientCare.API.Framework.Core.Entities.Domain
{
    public class BaseEntity
    {
        [Column("INSERTTS")]
        public DateTime InsertTS { get; set; }

        [Column("MODIFYTS")]
        public DateTime? ModifyTS { get; set; }

        public BaseEntity()
        {
            InsertTS = DateTime.Now;
            ModifyTS = DateTime.Now;
        }
    }
}