using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static E_Commerce.Infrastructure.Data.Common.ValidationConstants.CategoryConstrains;

namespace E_Commerce.Core.Models
{
    public class CategoryModel
    {
        public int CategoryID { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Description is required.")]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength)]
        public string Description { get; set; } = null!;

    }
}
