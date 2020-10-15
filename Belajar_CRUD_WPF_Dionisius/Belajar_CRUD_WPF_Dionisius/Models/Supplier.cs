﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belajar_CRUD_WPF_Dionisius.Models
{
    [Table("TB_M_Supplier")]
    public class Supplier
    {
        [Key]
        public int Id{get; set;}
        public string Name {get; set;}
    }
}
