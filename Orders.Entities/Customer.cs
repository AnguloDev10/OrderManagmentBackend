using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Entities
{
    public class Customer : EntityBase
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

    }
}
