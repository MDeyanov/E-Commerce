using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static E_Commerce.Infrastructure.Data.Common.ValidationConstants.CategoryConstrains;

namespace E_Commerce.Infrastructure.Data.Entity
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [Required]
        [StringLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
