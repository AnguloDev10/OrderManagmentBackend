using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Entities
{
    
    public enum TypeEmployee
    {
        GERENTE, CAJERO
    }


    public class Employee: EntityBase
    {
        [StringLength(100)]
        [Required]
        public string Nombres { get; set; }

        [StringLength(100)]
        [Required]
        public string Apellidos { get; set; }

        [StringLength(50)]
        [Required]
        public string Correo { get; set; }

        [Required]
        public int Dni { get; set; }

        public int PhoneNumber { get; set; }

        [EnumDataType(typeof(TypeEmployee))]
        public TypeEmployee Type { get; set; }

    }
}
