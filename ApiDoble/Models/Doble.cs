using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDoble.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class Doble
    {
        [Key]
        public string Email { get; set; }
        [Required]
        public string Name { get; set; }
        [DataType(DataType.DateTime)]
        [Required]
        public DateTime DateTime { get; set; }
        [Required]
        public int Step { get; set; }

    }

}
