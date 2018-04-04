using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvcCrudOperation.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Product Name")]
        [StringLength(500)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Product Code")]
        [StringLength(50)]
        public string Code { get; set; }

        [Required]
        [Display(Name = "Product Price")]
        public decimal? Price { get; set; }

        public bool IsDeleted { get; set; }
    }
}