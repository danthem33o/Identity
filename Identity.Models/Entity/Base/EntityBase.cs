using System;
using System.ComponentModel.DataAnnotations;

namespace Identity.Models.Entity.Base
{
    public abstract class EntityBase <TId>
    {
        [Key]
        public TId Id { get; set; }

        public DateTime DateTimeCreate { get; set; }
    }
}
