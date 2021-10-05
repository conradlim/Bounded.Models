using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Bounded.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name="Category Name")]
        [MaxLength(50)]
        public string Name{ get; set; }
    }
}
