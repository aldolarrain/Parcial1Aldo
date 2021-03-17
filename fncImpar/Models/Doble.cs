using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace fncImpar.Models
{
    class Doble
    {
        [Key]
        [DataType(DataType.DateTime)]
        public DateTime DateTime { get; set; }
        [Required]
        public int Random { get; set; }
    }
}
