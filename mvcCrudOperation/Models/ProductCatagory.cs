namespace mvcCrudOperation.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductCatagory")]
    public partial class ProductCatagory
    {
        [Key]
        public int productCatId { get; set; }

        [StringLength(500)]
        public string productCatName { get; set; }
    }
}
