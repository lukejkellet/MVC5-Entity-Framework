using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductApp.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("product name")]
        [StringLength(50)]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Price is required")]
        [Range(1, 1000, ErrorMessage = "Price must be between 1 and 1000")]
        public decimal Price { get; set; }
        [DisplayName("product description")]
        [StringLength(200)]
        public string Description { get; set; }
    }
}