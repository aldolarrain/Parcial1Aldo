﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDoble.Models
{
    using NUnit.Framework;
    using System;
    using System.ComponentModel.DataAnnotations;
    public class Doble
    {
        [Key]
        [DataType(DataType.DateTime)]
        public DateTime DateTime { get; set; }
        [Required]
        public int Random { get; set; }
    }

}
