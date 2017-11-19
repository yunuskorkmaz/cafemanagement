﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Masa
    {
        [Key]
        public int ID { get; set; }
        public string Adi { get; set; }
        public int AdditionCount { get; set; }
    }
}
