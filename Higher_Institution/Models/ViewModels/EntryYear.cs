﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Higher_Institution.Models.ViewModels
{
    public class EntryYear
    {
        public int EntryYearID { get; set; }


        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }


    }
}
