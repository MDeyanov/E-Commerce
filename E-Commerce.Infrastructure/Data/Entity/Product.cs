using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static E_Commerce.Infrastructure.Data.Common.ValidationConstants.ProductConstrains;

namespace E_Commerce.Infrastructure.Data.Entity
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required]
        [StringLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Precision(18, 2)]
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }

        [Required]
        public string ImageURL { get; set; } = null!;

        [Required]
        public int CategoryID { get; set; }

        [Required]
        [ForeignKey(nameof(CategoryID))]
        public Category Category { get; set; } = null!;
        public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}
