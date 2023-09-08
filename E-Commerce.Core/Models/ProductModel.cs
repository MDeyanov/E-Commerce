using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static E_Commerce.Infrastructure.Data.Common.ValidationConstants.ProductConstrains;

namespace E_Commerce.Core.Models
{
    public class ProductModel
    {
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(NameMaxLength, ErrorMessage = "Name length exceeds the maximum limit.")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Description is required.")]
        [StringLength(DescriptionMaxLength, ErrorMessage = "Description length exceeds the maximum limit.")]
        public string Description { get; set; } = null!;

        [Required(ErrorMessage = "Price is required.")]
        [Range(0, double.MaxValue, ErrorMessage = "Price must be non-negative.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "StockQuantity is required.")]
        [Range(0, int.MaxValue, ErrorMessage = "StockQuantity must be non-negative.")]
        public int StockQuantity { get; set; }

        [Required(ErrorMessage = "ImageURL is required.")]
        public string ImageURL { get; set; } = null!;

        [Required(ErrorMessage = "CategoryID is required.")]
        public int CategoryID { get; set; }
    }
}
