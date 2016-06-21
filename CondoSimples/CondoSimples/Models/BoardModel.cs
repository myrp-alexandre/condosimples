﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondoSimples.Models
{
    public class BoardModel
    {
        public int Id { get; set; }
        [Display(Name="Publicação")]
        [Required]
        public string Post { get; set; }
        public DateTime DatePost { get; set; }
        public DateTime DateExpires { get; set; }
        [Display(Name = "Publicado")]
        public bool Published { get; set; }

        public ApplicationUser User { get; set; }
    }
}
