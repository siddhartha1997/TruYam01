﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TruYam.Models
{
    public class MenuItem
    {
        [Key]
        public int Id { get; set; }
        //[Required]
        public string Name { get; set; }
        //[Display(Name = "Free Delivery")]
        public string FreeDelivery { get; set; }
        //[Required]
        public double Price { get; set; }
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString =
        //"{0:yyyy-MM-dd}",
        //ApplyFormatInEditMode = true)]
        public string DateofLaunch { get; set; }
        public string Category { get; set; }
        public string Active { get; set; }
    }
}
